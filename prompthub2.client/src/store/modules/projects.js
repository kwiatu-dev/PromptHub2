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

      return project
    }
    catch(error){
      return error.response.data
    }
  },
  async DeleteProject({ commit }, uuid){
    try{
      const response = await axios.delete(`/projects/${uuid}`)
      commit('DeleteProject', uuid)

      return response.data
    }
    catch(error){
      return error.response.data
    }
  },
  async EditProject({ commit }, data){
    try{
      const { uuid, form } = data
      const response = await axios.put(`/projects/${uuid}`, form)
      const project = response.data
      commit('EditProject', { uuid, project })

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
  EditProject(state, data){
    const { uuid, project } = data
    const index = state.projects.findIndex(project => project.id === uuid)
    state.projects[index] = project
  },
  DeleteProject(state, uuid){
    const index = state.projects.findIndex(project => project.id === uuid)

    if(index !== -1){
      state.projects.splice(index, 1)
    }
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
