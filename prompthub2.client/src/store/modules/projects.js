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
  async GetProject({ commit }, uuid){
    const { success, result } = await handleRequest(axios.get, `/projects/${uuid}`)

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
  async DeleteProject({ commit }, uuid){
    const { success, result } = await handleRequest(axios.delete, `/projects/${uuid}`)

    if(success){
      commit('DeleteProject', uuid)
    }

    return result
  },
  async EditProject({ commit }, data){
    const { uuid, form } = data
    const { success, result } = await handleRequest(axios.put, `/projects/${uuid}`, form)

    if(success){
      commit('EditProject', { uuid, project: result })
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
