import store from '@/store'
import parseJwt from '@/helpers/parseJwt'

let refreshTokenTimeoutId = -1 

const start = () => {
  if(store.getters.isAuthenticated){
    const jwt = parseJwt(store.getters.StateAccessToken)
    const expires = new Date(jwt.exp * 1000)
    const timeout = expires.getTime() - Date.now() - (30 * 1000)
    
    refreshTokenTimeoutId = setTimeout(async () => { 
      await store.dispatch('TryToLogInWithRefreshToken')
    }, timeout)
  }
}

const stop = () => {
  if(refreshTokenTimeoutId !== -1){
    clearTimeout(refreshTokenTimeoutId)
    refreshTokenTimeoutId = -1
  }

}

export default {
  start,
  stop,
}