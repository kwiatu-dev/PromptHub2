import router from '@/router/router.js'
import store from '@/store'
import axios from 'axios'
import Cookies from 'universal-cookie'
const cookies = new Cookies()

axios.defaults.withCredentials = true
axios.defaults.baseURL = import.meta.env.VITE_ENDPOINT_URL

axios.interceptors.request.use(function(config){
  const tokenString = cookies.get('token')

  if(tokenString){
    config.headers.Authorization = `Bearer ${tokenString}`
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