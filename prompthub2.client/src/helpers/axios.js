import router from '@/router/router'
import store from '@/store'
import axios from 'axios'
import cookies from '@/helpers/cookies'

axios.defaults.withCredentials = true
axios.defaults.baseURL = import.meta.env.VITE_ENDPOINT_URL

axios.interceptors.request.use(async function(config){
  const isAuthenticated = store.getters.isAuthenticated

  if(isAuthenticated){
    config.headers.Authorization = `Bearer ${ cookies.getJwt() }`
  }

  if(store.getters.StateAntiForgeryToken){
    config.headers['X-XSRF-TOKEN'] = store.getters.StateAntiForgeryToken
  }

  return config
}, undefined)

axios.interceptors.response.use(undefined, function(error){
  if(error){
    const originalRequest = error.config

    if((error.response.status === 401 
      || error.response.status === 403) 
      && !originalRequest._retry)
    {
      originalRequest._retry = true
      store.dispatch('LogOut')
      router.push({ name: 'login' })
    }
  }

  return Promise.reject(error)
})

export default axios