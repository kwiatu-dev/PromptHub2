<template>
  <div v-if="message && message.length">
    <div 
      v-if="success" 
      class="input-success"
    >
      {{ message }}
    </div>
    <div 
      v-else 
      class="input-error"
    >
      {{ message }}
    </div>
  </div>
</template>

<script setup>
import { computed } from 'vue'

const props = defineProps({
  message: String,
  status: String,
})

const success = computed(() => props.status === 'Success')
</script>