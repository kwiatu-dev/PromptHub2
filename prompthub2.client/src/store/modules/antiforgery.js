import axios from 'axios'

const state = () => ({
  antiForgeryToken: null,
})
const getters = {
  StateAntiForgeryToken: state => state.antiForgeryToken,
}
const actions = {
  async GetAntiForgeryToken({ commit }){
    if(state.StateAntiForgeryToken) return

    try{
      const response = await axios.get('/antiforgery/token')

      const token = response.data.token
      commit('SetAntiForgeryToken', token)

      return token
    }
    catch(error){
      return error.response.data
    }
  },
}
const mutations = {
  SetAntiForgeryToken(state, token){
    state.antiForgeryToken = token
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
