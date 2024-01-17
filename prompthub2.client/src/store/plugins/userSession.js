import logoutTabs from '@/helpers/logoutTabs'

export const userSessionPlugin = (store) => {
  store.dispatch('LogInFromCookie')
  logoutTabs.startEventListener()
}