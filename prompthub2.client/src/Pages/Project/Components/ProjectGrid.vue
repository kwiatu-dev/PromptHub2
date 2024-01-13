<template>
  <div v-if="projects">
    <div class="grid grid-cols-1 md:grid-cols-3 gap-4">
      <div v-for="(project) in projects" :key="project.id" class="bg-gray-100 p-4 w-full shadow-sm">
        <div class="mb-2">
          <div class="text-lg font-medium">
            {{ project.name }}
          </div>
          <div class="text-sm text-gray-400">
            {{ project.description }}
          </div>
        </div>
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
          <div class="bg-gray-300 p-2 flex-grow shadow-sm">Show</div>
          <div class="bg-gray-300 p-2 shadow-sm">Edit</div>
          <div class="bg-gray-300 p-2 shadow-sm">Delete</div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { useStore } from 'vuex'
import { computed } from 'vue'

const store = useStore()
const GetAllProjects = async () => await store.dispatch('GetAllProjects')
const projects = computed(() => store.getters.StateProjects)

if(!projects.value?.length){
  await GetAllProjects()
}
</script>