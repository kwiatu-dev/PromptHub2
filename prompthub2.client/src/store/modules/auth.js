import axios from 'axios'
import handleRequest from '@/helpers/handleRequest'
import logoutTabs from '@/helpers/syncTabs'
import { resetStore } from '@/helpers/resetStore'
import refreshTokenTimer from '@/helpers/refreshTokenTimer'

const state = () => ({
  accessToken: null,
  user: null,
})
const getters = {
  isAuthenticated: state => !!state.user && !!state.accessToken,
  isAdmin: state => state.user?.roles?.length && state.user?.roles.includes('admin'),
  StateUser: state => state.user,
  StateAccessToken: state => state.accessToken,
}
const actions = {
  async SignUp(_, form){
    const { result } = await handleRequest(axios.post, '/Authenticate/Register', form)
    return result
  },
  async LogIn({ dispatch }, form){
    const { success, result } = await handleRequest(axios.post, '/Authenticate/Login', form)
    
    if(success){
      dispatch('AfterSuccessfulLogIn', result)
    }

    return result
  },
  async AfterSuccessfulLogIn({ commit, dispatch }, result){
    if(result?.user && result?.token){
      commit('SetUser', result.user)
      commit('SetAccessToken', result.token)
      refreshTokenTimer.start()
      logoutTabs.emitLoginEvent()
    }
    
    await dispatch('GetAntiForgeryToken')
  },
  async TryToLogInWithRefreshToken({ dispatch }){
    const { success, result } = await handleRequest(axios.get, '/Authenticate/Refresh')

    if(success){
      await dispatch('AfterSuccessfulLogIn', result)
    }

    return result
  },
  async LogOut(){
    const { success } = await handleRequest(axios.delete, '/Authenticate/LogOut')

    if(success){
      resetStore()
      refreshTokenTimer.stop()
    }
  },
  async ConfirmEmail(_, payload){
    const { result } = await handleRequest(axios.post, '/Authenticate/ConfirmEmail', payload)
    return result
  },
}
const mutations = {
  SetUser(state, user){
    state.user = user
  },
  SetAccessToken(state, accessToken){
    state.accessToken = accessToken
  },
  LogOut(state){
    state.user = null
    state.accessToken = null
    logoutTabs.emitLogoutEvent()
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
