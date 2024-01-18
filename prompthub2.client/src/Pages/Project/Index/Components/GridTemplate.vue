<template>
  <div 
    v-if="projects && projects?.length" 
    class="grid grid-cols-1 md:grid-cols-3 gap-4 mt-4"
  >
    <div 
      v-for="(project) in projects" 
      :key="project.id" 
      class="bg-gray-100 p-4 w-full shadow-sm flex flex-col justify-between"
    >
      <BoxItem :project="project" />
    </div>
  </div>
  <div v-else>
    {{ NoItemsFound('projects') }}
  </div>
</template>

<script setup>
import { NoItemsFound } from '@/constants/inlineMessages'
import BoxItem from '@/Pages/Project/Index/Components/BoxItem.vue'

defineProps({
  projects: Array,
})
</script>