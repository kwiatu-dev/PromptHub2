import axios from 'axios'
import handleRequest from '@/helpers/handleRequest'
import logoutTabs from '@/helpers/logoutTabs'
import cookies from '@/helpers/cookies'

const state = () => ({
  user: null,
})
const getters = {
  isAuthenticated: state => !!state.user,
  isAdmin: state => state.user?.role === 'admin',
  StateUser: state => state.user,
}
const actions = {
  async SignUp(_, form){
    const { result } = await handleRequest(axios.post, '/Authenticate/Register', form)
    return result
  },
  async LogIn({commit}, form){
    const { result } = await handleRequest(axios.post, '/Authenticate/Login', form)
    
    if(result?.token){
      commit('SetUser', cookies.setUser(result.token))
    }

    return result
  },
  LogInFromCookie({ commit }){
    const user = cookies.getUser()

    if(user){
      commit('SetUser', user)
    }
  },
  async LogOut({ commit }){
    cookies.removeUser()
    commit('RemoveAntiForgeryToken')
    commit('ResetProjectState')
    commit('ResetProjectsState')
    commit('ResetPromptState')
    commit('ResetPromptsState')
    commit('LogOut')
  },
  async ConfirmEmail(_, payload){
    const { result } = await handleRequest(axios.post, '/Authenticate/ConfirmEmail', payload)
    return result
  },
}
const mutations = {
  SetUser(state, user){
    state.user = user
    logoutTabs.emitLoginEvent()
  },
  LogOut(state){
    state.user = null
    logoutTabs.emitLogoutEvent()
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
