import router from '@/router/router.js'
import store from '@/store'
import axios from 'axios'
import { GetJWTFromCookie } from '@/helpers/tokens'

axios.defaults.withCredentials = true
axios.defaults.baseURL = import.meta.env.VITE_ENDPOINT_URL

axios.interceptors.request.use(async function(config){
  const isAuthenticated = store.getters.isAuthenticated

  if(isAuthenticated){
    config.headers.Authorization = `Bearer ${GetJWTFromCookie()}`
  }

  if (store.getters.StateAntiForgeryToken) {
    config.headers['X-XSRF-TOKEN'] = store.getters.StateAntiForgeryToken
  }

  return config
}, undefined)

axios.interceptors.response.use(undefined, function(error){
  if (error) {
    const originalRequest = error.config
    if (error.response.status === 401 && !originalRequest._retry) {
    
      originalRequest._retry = true
      store.dispatch('LogOut')
      router.push({ name: 'login' })
    }
  }

  return Promise.reject(error)
})

export default axios