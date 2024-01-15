<template>
  <button class="btn-primary" @click="open">Create project</button>
  <div class="fixed w-full h-full bg-gray-500 shadow-md top-0 left-0 opacity-80" :class="[show ? 'block' : 'hidden']" />
  <div class="absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 w-4/5 h-4/5 bg-slate-100 p-4 flex flex-col" :class="[show ? 'block' : 'hidden']">
    <div class="w-full flex flex-row mb-4">
      <div class="w-1/2 font-medium text-2xl">
        Create project
      </div>
      <div class="w-1/2 text-right">
        <font-awesome-icon icon="xmark" class="cursor-pointer" size="2x" @click="close" />
      </div>
    </div>
    <CreateForm @created="close" />
  </div>
</template>

<script setup>
import { ref } from 'vue'
import CreateForm from '@/Pages/Project/Index/Components/CreateForm.vue'

const show = ref(false)

const close = () => {
  show.value = false
}

const open = () => {
  show.value = true
}
</script>