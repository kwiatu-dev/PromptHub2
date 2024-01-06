import axios from 'axios'

const state = () => ({
  
})
const getters = {

}
const actions = {
  async ForgotPassword(_, payload){
    try{
      const response = await axios.post('/Account/ForgotPassword', payload)

      return response.data
    }
    catch(error){
      return error.response.data
    }
  },
  async ResetPassword(_, payload){
    try{
      const response = await axios.post('/Account/ResetPassword', payload)

      return response.data
    }
    catch(error){
      return error.response.data
    }
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
