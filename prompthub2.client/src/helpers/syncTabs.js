import store from '@/store/index'
import router from '@/router/router'
import { LOGIN_EVENT, LOGOUT_EVENT } from '@/constants/localStorageEvents'

const storageEventListener = (event) => {
  if(event.storageArea == localStorage){
    if(event?.key && event.key == LOGOUT_EVENT){
      if(store.getters.isAuthenticated){
        store.dispatch('LogOut')
        router.push({ name: 'home' })
      }
    }
    else if(event?.key && event.key == LOGIN_EVENT){
      if(!store.getters.isAuthenticated){
        store.dispatch('TryToLogInWithRefreshToken')
        router.push({ name: 'home' })
      }
    }
  }
}

const startEventListener = () => {
  window.addEventListener('storage', storageEventListener)
}

const stopEventListener = () => {
  window.removeEventListener('storage', storageEventListener)
}

const emitLogoutEvent = () => {
  window.localStorage.setItem(LOGOUT_EVENT, Math.random().toString())
}

const emitLoginEvent = () => {
  window.localStorage.setItem(LOGIN_EVENT, Math.random().toString())
}

export default {
  startEventListener,
  stopEventListener,
  emitLogoutEvent,
  emitLoginEvent,
}