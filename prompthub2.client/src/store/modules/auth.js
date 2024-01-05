import axios from 'axios'
import Cookies from 'universal-cookie'
import parseJwt from '@/helpers/parseJwt.js'
import { ROLE_SCHEMA, EMAIL_SCHEMA } from '@/data/schemas'
const cookies = new Cookies()

const state = () => ({
  user: null,
})
const getters = {
  isAuthenticated: state => !!state.user,
  StateUser: state => state.user,
}
const actions = {
  async SignUp(_, form){
    try{
      const response = await axios.post('/Authenticate/Register', form)

      return response.data
    }
    catch(error){
      return error.response.data
    }
    
  },
  async LogIn({commit}, form){
    try{
      const response = await axios.post('/Authenticate/Login', form)
      const tokenString = response.data.token 
      const token = parseJwt(tokenString)
      const expires = new Date(token.exp * 1000)
      cookies.set('token', tokenString, { expires })

      await commit('setUser', {
        email: token[EMAIL_SCHEMA],
        token: response.data.token,
        role: token[ROLE_SCHEMA] ?? null,
      })

      return response.data
    }
    catch(error){
      return error.response.data
    }
  },
  async LogOut({commit}){
    cookies.remove('token')
    commit('LogOut')
  },
  async ConfirmEmail(_, payload){
    try{
      const response = await axios.post('/Authenticate/ConfirmEmail', payload)

      return response.data
    }
    catch(error){
      return error.response.data
    }
  },
}
const mutations = {
  setUser(state, user){
    state.user = user
  },
  LogOut(state){
    state.user = null
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
