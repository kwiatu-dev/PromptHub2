import axios from 'axios'

const state = () => ({
  project: null,
  projects: null,
})
const getters = {
  StateProjects: state => state.projects,
  StateProject: state => state.project,
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
      return []
    }
  },
  async GetProject({ commit }, uuid){
    try{
      const response = await axios.get(`/projects/${uuid}`)
      const project = response.data
      commit('SetProject', project)

      return project
    }
    catch(error){
      return null
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
      return null
    }
  },
  async DeleteProject({ commit }, uuid){
    try{
      await axios.delete(`/projects/${uuid}`)
      commit('DeleteProject', uuid)

      return true
    }
    catch(error){
      return false
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
      return null
    }
  },
}
const mutations = {
  SetProjects(state, projects){
    state.projects = projects
  },
  SetProject(state, project){
    state.project = project
  },
  AddProject(state, project){
    state.projects.push(project)
  },
  EditProject(state, data){
    const { uuid, project } = data

    if(state.projects){
      const index = state.projects.findIndex(project => project.id === uuid)

      if(index !== -1){
        state.projects[index] = project
      }
    }
    
    if(state.project?.id === uuid){
      state.project = project
    }
  },
  DeleteProject(state, uuid){
    if(state.projects){
      const index = state.projects.findIndex(project => project?.id === uuid)

      if(index !== -1){
        state.projects.splice(index, 1)
      }
    }

    if(state.project?.id === uuid){
      state.project = null
    }
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
