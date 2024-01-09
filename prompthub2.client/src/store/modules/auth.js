import axios from 'axios'
import parseJwt from '@/helpers/parseJwt.js'
import { ROLE_SCHEMA, EMAIL_SCHEMA } from '@/constants/schemas'
import { RemoveJWTCookie, SetJWTCookie } from '@/helpers/tokens'

const state = () => ({
  user: null,
})
const getters = {
  isAuthenticated: state => !!state.user,
  isAdmin: state => state.user?.role === 'admin',
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
      SetJWTCookie(tokenString, { expires })

      await commit('SetUser', {
        email: token[EMAIL_SCHEMA],
        token: tokenString,
        role: token[ROLE_SCHEMA] ?? null,
      })

      return response.data
    }
    catch(error){
      return error.response.data
    }
  },
  async LogOut({commit}){
    RemoveJWTCookie()
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
  SetUser(state, user){
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
