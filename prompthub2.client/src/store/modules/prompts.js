import axios from 'axios'
import handleRequest from '@/helpers/handleRequest'
import syncTabs from '@/helpers/syncTabs'

const state = () => ({
  prompt: null,
  prompts: null,
})
const getters = {
  StatePrompt: state => state.prompt,
  StatePrompts: state => state.prompts,
}
const actions = {
  async GetAllPrompts({ commit }, guid){
    const { success, result } = await handleRequest(axios.get, `/projects/${guid}/prompts`)

    if(success){
      commit('SetPrompts', result)
    }

    return result
  },
  async CreatePrompt({ commit }, data){
    const { guid, form } = data
    const { success, result } = await handleRequest(axios.post, `/projects/${guid}/prompts`, form)

    if(success){
      commit('AddPrompt', result)
    }
  
    return result
  },
  async DeletePrompt({ commit }, guid){
    const { success, result } = await handleRequest(axios.delete, `/prompts/${guid}`)

    if(success){
      commit('DeletePrompt', guid)
    }

    return result
  },
}
const mutations = {
  SetPrompt(state, prompt){
    state.prompt = prompt
  },
  SetPrompts(state, prompts){
    state.prompts = prompts
  },
  AddPrompt(state, prompt){
    state.prompts.push(prompt)
    syncTabs.emitPageChangedEvent()
  },
  DeletePrompt(state, guid){
    if(state.prompts?.length){
      const index = state.prompts.findIndex(prompt => prompt?.id === guid)

      if(index !== -1){
        state.prompts.splice(index, 1)
      }
    }

    if(state.prompt?.id === guid){
      state.prompt = null
    }
    syncTabs.emitPageChangedEvent()
  },
  ResetPromptState(state){
    state.prompt = null
  },
  ResetPromptsState(state){
    state.prompts = null
  },
}
export default {
  state,
  getters,
  actions,
  mutations,
}
