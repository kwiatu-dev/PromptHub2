import axios from 'axios'
import Cookies from 'universal-cookie'
import parseJwt from '@/helpers/parseJwt.js'
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
        email: form.email,
        token: response.data.token,
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
