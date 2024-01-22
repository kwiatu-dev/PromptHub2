import store from '@/store'

export const resetStore = () => {
  store.commit('RemoveAntiForgeryToken')
  store.commit('ResetProjectState')
  store.commit('ResetProjectsState')
  store.commit('ResetPromptState')
  store.commit('ResetPromptsState')
  store.commit('LogOut')
}