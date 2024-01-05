import { createStore } from 'vuex'
import auth from '@/store/modules/auth.js'
import account from '@/store/modules/account.js'
import { userSessionPlugin } from '@/store/plugins/userSession.js'

const store = createStore({
  modules: {
    auth,
    account,
  },
  plugins: [userSessionPlugin],
})

export default store