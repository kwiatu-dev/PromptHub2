import '@/assets/index.css'
import '@/helpers/axios.js'
import { createApp } from 'vue'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import router from '@/router/router.js'
import store from '@/store'
import App from '@/App.vue'

const app = createApp(App)
app.use(router)
app.use(store)
app.component('FontAwesomeIcon', FontAwesomeIcon)
app.mount('#app')
