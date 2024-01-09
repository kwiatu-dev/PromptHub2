import { createStore } from 'vuex'
import auth from '@/store/modules/auth.js'
import account from '@/store/modules/account.js'
import projects from '@/store/modules/projects.js'
import antiforgery from '@/store/modules/antiforgery.js'
import { userSessionPlugin } from '@/store/plugins/userSession.js'

const store = createStore({
  modules: {
    auth,
    account,
    projects,
    antiforgery,
  },
  plugins: [userSessionPlugin],
})

export default store