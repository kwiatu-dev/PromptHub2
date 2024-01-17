import axios from 'axios'
import handleRequest from '@/helpers/handleRequest'

const state = () => ({
  
})
const getters = {

}
const actions = {
  async ForgotPassword(_, payload){
    const { result } = await handleRequest(axios.post, '/Account/ForgotPassword', payload)
    return result
  },
  async ResetPassword(_, payload){
    const { result } = await handleRequest(axios.post, '/Account/ResetPassword', payload)
    return result
  },
}
const mutations = {
  
}
export default {
  state,
  getters,
  actions,
  mutations,
}
