import axios from 'axios'

const state = {
  user: null,
}
const getters = {
  isAuthenticated: state => !!state.email,
  StateUser: state => state.email,
}
const actions = {
  async SignUp({dispatch}, form){
    await axios.post('/Authenticate/Register', form)
    await dispatch('LogIn', form)
  },
  async LogIn({commit}, form){
    await axios.post('/Authenticate/Login', form)
    await commit('setUser', form.email)
  },
  async LogOut({commit}){
    commit('logout')
  },
}
const mutations = {
  setUser(state, email){
    state.user = email
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
