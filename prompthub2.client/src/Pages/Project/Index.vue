<template>
  <div 
    class="overflow-y-auto" 
    style="height: calc(100vh - 64px - 2rem);"
  >
    <DefaultPopup 
      :form="CreateForm" 
      caption="Create project" 
      title="Create project"
      class="mb-4"
    />
    <GridTemplate :projects="projects" />
  </div>
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