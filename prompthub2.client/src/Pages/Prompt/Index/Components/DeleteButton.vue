<template>
  <button 
    class="btn-primary" 
    @click="DeletePrompt"
  >
    Delete
  </button>
</template>
  
<script setup>
import { useStore } from 'vuex'
  
const store = useStore()
  
const props = defineProps({
  prompt: {
    type: Object,
    required: true,
  },
})
  
const DeletePrompt = async () => await store.dispatch('DeletePrompt', props.prompt.id)
</script>