<template>
  <button class="btn-primary" @click="DeleteProject">Delete</button>
</template>

<script setup>
import { useStore } from 'vuex'

const props = defineProps({
  project: Object,
})

const store = useStore()
const DeleteProject = async () => await store.dispatch('DeleteProject', props.project.id)
</script>