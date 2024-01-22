import store from '@/store/index'
import router from '@/router/router'
import { LOGIN_EVENT, LOGOUT_EVENT, PAGE_CHANGED_EVENT } from '@/constants/localStorageEvents'

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
    else if(event?.key && event.key == PAGE_CHANGED_EVENT){
      reload(router)
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

const emitPageChangedEvent = () => {
  const route = router.currentRoute.value
  window.localStorage.setItem(PAGE_CHANGED_EVENT, `${route.name}:${Math.random().toString()}`)
}

const reload = (router) => {
  const name = window.localStorage.getItem(PAGE_CHANGED_EVENT).split(':')[0]
  router.push({ name: 'empty' }).then(() => { router.push({ name }) })
}

export default {
  startEventListener,
  stopEventListener,
  emitLogoutEvent,
  emitLoginEvent,
  emitPageChangedEvent,
}