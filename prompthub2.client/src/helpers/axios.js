import router from '@/router/router'
import store from '@/store'
import axios from 'axios'
import cookies from '@/helpers/cookies'

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

axios.interceptors.response.use(undefined, async error => {
  if(error){
    if(error.response.status === 401)
    {
      router.push({ name: 'login' })
    }

    if(error.response.status === 403){
      router.push({ name: 'home' })
    }
  }

  return Promise.reject(error)
})

export default axios