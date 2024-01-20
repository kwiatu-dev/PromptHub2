import { createApp } from 'vue'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import '@/icons/fontawesome.js'
import '@/assets/index.css'
import syncTabs from '@/helpers/syncTabs'
import router from '@/router/router.js'
import store from '@/store'
import App from '@/App.vue'

const start = async () => {
  const app = createApp(App)
  app.component('FontAwesomeIcon', FontAwesomeIcon)
  app.use(store)
  await store.dispatch('TryToLogInWithRefreshToken')
  syncTabs.startEventListener()
  app.use(router)
  app.mount('#app')
}

start()

