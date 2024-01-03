require('dotenv').config()
import '@/assets/index.css'
import { createApp } from 'vue'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import router from '@/router/router.js'
import store from '@/store'
import axios from 'axios'
import App from '@/App.vue'

axios.defaults.withCredentials = true
axios.defaults.baseURL = process.env.ENDPOINT_URL

const app = createApp(App)
app.use(router)
app.use(store)
app.component('FontAwesomeIcon', FontAwesomeIcon)
app.mount('#app')
