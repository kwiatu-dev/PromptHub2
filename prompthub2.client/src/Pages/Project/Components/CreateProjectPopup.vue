<template>
  <button class="px-4 py-2 bg-gray-400 mb-4" @click="openCreatePopup">Create project</button>
  <div class="fixed -translate-x-1/2 -translate-y-1/2 w-full h-full bg-gray-500 shadow-md top-1/2 left-1/2 opacity-80" :class="[showCreatePopup ? 'block' : 'hidden']" />
  <div class="absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 w-4/5 h-4/5 bg-slate-100 p-4 flex flex-col" :class="[showCreatePopup ? 'block' : 'hidden']">
    <div class="w-full flex flex-row mb-4">
      <div class="w-1/2 font-medium text-2xl">
        Create project
      </div>
      <div class="w-1/2 text-right">
        <font-awesome-icon icon="xmark" class="cursor-pointer" size="2x" @click="closeCreatePopup" />
      </div>
    </div>
    <CreateProjectForm @created="closeCreatePopup" />
  </div>
</template>

<script setup>
import { ref } from 'vue'
import CreateProjectForm from '@/Pages/Project/Components/CreateProjectForm.vue'

const showCreatePopup = ref(false)

const closeCreatePopup = () => {
  showCreatePopup.value = false
}

const openCreatePopup = () => {
  showCreatePopup.value = true
}
</script>