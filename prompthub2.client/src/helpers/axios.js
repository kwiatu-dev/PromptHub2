import router from '@/router/router'
import store from '@/store'
import axios from 'axios'

axios.defaults.withCredentials = true
axios.defaults.baseURL = import.meta.env.VITE_ENDPOINT_URL

axios.interceptors.request.use(async config => {
  if(store.getters.isAuthenticated){
    config.headers.Authorization = `Bearer ${ store.getters.StateAccessToken }`
  }

  if(store.getters.StateAntiForgeryToken){
    config.headers['X-XSRF-TOKEN'] = store.getters.StateAntiForgeryToken
  }

  return config
}, undefined)

let isHandlingError = false

axios.interceptors.response.use(undefined, async error => {
  if(isHandlingError){
    return Promise.reject(error)
  }

  isHandlingError = true

  if(error){
    if(error.response.status === 401)
    {
      await unauthorized(router)
    }

    if(error.response.status === 403){
      forbidden(router)
    }
  }

  isHandlingError = false

  return Promise.reject(error)
})

const unauthorized = async (router) => {
  const { meta } = router.currentRoute.value

  if(store.getters.isAuthenticated){
    await store.dispatch('LogOut')
  }

  if(meta?.guest !== true){
    router.push({ name: 'login' })
  }
}

const forbidden = (router) => {
  router.push({ name: 'home' })
}

export default axios