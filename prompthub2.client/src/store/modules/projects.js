import axios from 'axios'

const state = () => ({
  projects: null,
})
const getters = {
  StateProjects: state => state.projects,
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
  async CreateProject({ commit }, form){
    try{
      const response = await axios.post('/projects', form)
      const project = response.data
      commit('AddProject', project)
      console.log(project)

      return project
    }
    catch(error){
      return error.response.data
    }
  },
}
const mutations = {
  SetProjects(state, projects){
    state.projects = projects
  },
  AddProject(state, project){
    state.projects.push(project)
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
