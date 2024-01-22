<template>
  <button 
    class="btn-primary" 
    @click="DeleteProject"
  >
    Delete
  </button>
</template>

<script setup>
import { useStore } from 'vuex'

const store = useStore()
const emit = defineEmits(['deleted'])

const props = defineProps({
  project: {
    type: Object,
    required: true,
  },
})

const DeleteProject = async () => {
  emit('deleted')
  await store.dispatch('DeleteProject', props.project.id)
}
</script>