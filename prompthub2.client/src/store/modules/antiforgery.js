import axios from 'axios'
import handleRequest from '@/helpers/handleRequest'

const state = () => ({
  antiForgeryToken: null,
})
const getters = {
  StateAntiForgeryToken: state => state.antiForgeryToken,
}
const actions = {
  async GetAntiForgeryToken({ getters, commit }){
    if(!getters.StateAntiForgeryToken && 
       getters.isAuthenticated)
    {
      const { result } = await handleRequest(axios.get, '/antiforgery/token')

      if(result?.token){
        commit('SetAntiForgeryToken', result.token)
        return result.token
      }
    }

    return null
  },
}
const mutations = {
  SetAntiForgeryToken(state, token){
    state.antiForgeryToken = token
  },
  RemoveAntiForgeryToken(state){
    state.antiForgeryToken = null
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
