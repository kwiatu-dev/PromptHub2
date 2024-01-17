import { createStore } from 'vuex'
import auth from '@/store/modules/auth'
import account from '@/store/modules/account'
import projects from '@/store/modules/projects'
import antiforgery from '@/store/modules/antiforgery'
import { userSessionPlugin } from '@/store/plugins/userSession'

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