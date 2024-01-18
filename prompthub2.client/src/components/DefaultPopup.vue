<template>
  <div>
    <button 
      class="btn-primary" 
      @click="open"
    >
      {{ caption }}
    </button>
    <div 
      class="fixed w-full h-full bg-gray-500 shadow-md top-0 left-0 opacity-80 z-20" 
      :class="[show ? 'block' : 'hidden']"
    />
    <div 
      class="absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 w-4/5 h-4/5 bg-slate-100 p-4 flex flex-col z-20" 
      :class="[show ? 'block' : 'hidden']"
    >
      <div class="w-full flex flex-row mb-4">
        <div class="w-1/2 font-medium text-2xl">
          {{ title }}
        </div>
        <div class="w-1/2 text-right">
          <font-awesome-icon 
            icon="xmark" 
            class="cursor-pointer" 
            size="2x" 
            @click="close"
          />
        </div>
      </div>
      <component 
        :is="form" 
        :object="object"
        @close="close"
      />
    </div>
  </div>
</template>
  
<script setup>
import { ref } from 'vue'

defineProps({
  form: {
    type: Object,
    required: true,
  },
  title: {
    type: String,
    required: true,
  },
  caption: {
    type: String,
    required: true,
  },
  object: Object,
})
  
const show = ref(false)
  
const close = () => {
  show.value = false
}
  
const open = () => {
  show.value = true
}
</script>