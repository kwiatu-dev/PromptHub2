import { createStore } from 'vuex'
import auth from '@/store/modules/auth.js'
import { userSessionPlugin } from '@/store/plugins/userSession.js'

const store = createStore({
  modules: {
    auth,
  },
  plugins: [userSessionPlugin],
})

export default store