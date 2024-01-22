import { createApp } from 'vue'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import '@/icons/fontawesome.js'
import '@/assets/index.css'
import router from '@/router/router.js'
import store from '@/store'
import App from '@/App.vue'
import syncTabs from '@/helpers/syncTabs'

const init = async () => {
  const app = createApp(App)
  app.component('FontAwesomeIcon', FontAwesomeIcon)
  app.use(store)
  await store.dispatch('TryToLogInWithRefreshToken')
  app.use(router)
  syncTabs.startEventListener()
  app.mount('#app')
}

init()




