import axios from 'axios'

const state = () => ({
  projcets: null,
})
const getters = {
  StateProjects: state => state.projcets,
}
const actions = {
  async GetAllProjects({ commit }){
    try{
      const response = await axios.get('/projects')
      const projects = response.data
      commit('SetProjects', projects)

      return projects
    }
    catch(error){
      return error.response.data
    }
  },
}
const mutations = {
  SetProjects(state, projects){
    state.projcets = projects
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
