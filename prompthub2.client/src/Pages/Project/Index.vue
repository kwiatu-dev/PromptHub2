<template>
  <CreatePopup />
  <GridTemplate :projects="projects" />
</template>

<script setup>
import CreatePopup from '@/Pages/Project/Index/Components/CreatePopup.vue'
import GridTemplate from '@/Pages/Project/Index/Components/GridTemplate.vue'
import { useStore } from 'vuex'
import { onMounted, computed } from 'vue'

const store = useStore()
const projects = computed(() => store.getters.StateProjects)

onMounted(async () => {
  await store.dispatch('GetAllProjects')
})
</script>