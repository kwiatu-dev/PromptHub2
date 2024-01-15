<template>
  <button class="btn-primary" @click="openEditPopup">Edit</button>
  <div class="fixed -translate-x-1/2 -translate-y-1/2 w-full h-full bg-gray-500 shadow-md top-1/2 left-1/2 opacity-80" :class="[showEditPopup ? 'block' : 'hidden']" />
  <div class="absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 w-4/5 h-4/5 bg-slate-100 p-4 flex flex-col" :class="[showEditPopup ? 'block' : 'hidden']">
    <div class="w-full flex flex-row mb-4">
      <div class="w-1/2 font-medium text-2xl">
        Edit project
      </div>
      <div class="w-1/2 text-right">
        <font-awesome-icon icon="xmark" class="cursor-pointer" size="2x" @click="closeEditPopup" />
      </div>
    </div>
    <EditForm :project="project" @edited="closeEditPopup" />
  </div>
</template>
  
<script setup>
import { ref } from 'vue'
import EditForm from '@/Pages/Project/Index/Components/EditForm.vue'

defineProps({
  project: Object,
})
  
const showEditPopup = ref(false)
  
const closeEditPopup = () => {
  showEditPopup.value = false
}
  
const openEditPopup = () => {
  showEditPopup.value = true
}
</script>