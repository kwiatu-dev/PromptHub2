<template>
  <div v-if="projects" class="mt-4">
    <div class="grid grid-cols-1 md:grid-cols-3 gap-4">
      <div v-for="(project) in projects" :key="project.id" class="bg-gray-100 p-4 w-full shadow-sm flex flex-col justify-between">
        <BoxItem :project="project" />
      </div>
    </div>
  </div>
</template>

<script setup>
import BoxItem from '@/Pages/Project/Index/Components/BoxItem.vue'

defineProps({
  projects: Array,
})
</script>