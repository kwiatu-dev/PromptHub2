<template>
  <DefaultPopup 
    :form="CreateForm" 
    caption="Create project" 
    title="Create project"
    class="mb-4"
  />
  <GridTemplate :projects="projects" />
</template>

<script setup>
import DefaultPopup from '@/components/DefaultPopup.vue'
import CreateForm from '@/Pages/Project/Index/Components/CreateForm.vue'
import GridTemplate from '@/Pages/Project/Index/Components/GridTemplate.vue'
import { useStore } from 'vuex'
import { onMounted, computed } from 'vue'

const store = useStore()
const projects = computed(() => store.getters.StateProjects)

onMounted(async () => {
  await store.dispatch('GetAllProjects')
})
</script>