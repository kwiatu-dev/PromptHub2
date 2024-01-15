<template>
  <div class="mb-2">
    <div class="text-lg font-medium" :class="{'title': view === 'single'}">
      {{ project.name }}
    </div>
    <p class="text-sm text-gray-400" :class="{'!text-base': view === 'single'}">
      {{ project.description }}
    </p>
  </div>
  <div>
    <div class="flex flex-col">
      <div class="w-full">
        <span class="text-sm font-bold">Prompts: </span> {{ project.prompts?.length ?? 0 }}
      </div>
      <div class="w-full">
        <span class="text-sm font-bold">Created at: </span> {{ new Date(project.createdAt).toLocaleString() }}          
      </div>
      <div class="w-full">
        <span class="text-sm font-bold">Updated at: </span> {{ new Date(project.updatedAt).toLocaleString() }}          
      </div>
    </div>
    <div class="mt-4 flex flex-col sm:flex-row flex-wrap gap-2">
      <RouterLink v-if="view !== 'single'" class="btn-primary flex-grow" :to="{ name: 'project', params: { uuid: project.id } }">Show</RouterLink>
      <EditPopup :project="project" />
      <DeleteButton :project="project" />
    </div>
  </div>
</template>

<script setup>
import EditPopup from '@/Pages/Project/Index/Components/EditPopup.vue'
import DeleteButton from '@/Pages/Project/Index/Components/DeleteButton.vue'

defineProps({
  project: Object,
  view: String,
})
</script>