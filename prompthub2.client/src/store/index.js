import { createStore } from 'vuex'
import auth from '@/store/modules/auth'
import account from '@/store/modules/account'
import projects from '@/store/modules/projects'
import prompts from '@/store/modules/prompts'
import antiforgery from '@/store/modules/antiforgery'
import { userSessionPlugin } from '@/store/plugins/userSession'

const store = createStore({
  modules: {
    auth,
    account,
    projects,
    prompts,
    antiforgery,
  },
  plugins: [userSessionPlugin],
})

export default store