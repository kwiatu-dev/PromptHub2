import axios from 'axios'
import handleRequest from '@/helpers/handleRequest'

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
    const { success, result } = await handleRequest(axios.get, '/projects')

    if(success){
      commit('SetProjects', result)
    }

    return result
  },
  async GetProject({ commit }, guid){
    const { success, result } = await handleRequest(axios.get, `/projects/${guid}`)

    if(success){
      commit('SetProject', result)
    }

    return result
  },
  async CreateProject({ commit }, form){
    const { success, result } = await handleRequest(axios.post, '/projects', form)

    if(success){
      commit('AddProject', result)
    }

    return result
  },
  async DeleteProject({ commit }, guid){
    const { success, result } = await handleRequest(axios.delete, `/projects/${guid}`)

    if(success){
      commit('DeleteProject', guid)
    }

    return result
  },
  async EditProject({ commit }, data){
    const { guid, form } = data
    const { success, result } = await handleRequest(axios.put, `/projects/${guid}`, form)

    if(success){
      commit('EditProject', { guid, project: result })
    }

    return result
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
    const { guid, project } = data

    if(state.projects?.length){
      const index = state.projects.findIndex(project => project.id === guid)

      if(index !== -1){
        state.projects[index] = project
      }
    }
    
    if(state.project?.id === guid){
      state.project = project
    }
  },
  DeleteProject(state, guid){
    if(state.projects?.length){
      const index = state.projects.findIndex(project => project?.id === guid)

      if(index !== -1){
        state.projects.splice(index, 1)
      }
    }

    if(state.project?.id === guid){
      state.project = null
    }
  },
  ResetProjectState(state){
    state.project = null
  },
  ResetProjectsState(state){
    state.projects = null
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
