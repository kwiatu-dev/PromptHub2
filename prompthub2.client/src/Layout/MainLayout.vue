<template>
  <div>
    Time on page: {{ time }}
    <HeaderSection />
    <main class="max-w-screen-xl mx-auto p-4">
      <slot />
    </main>
  </div>
</template>

<script setup>
import HeaderSection from '@/components/HeaderSection.vue'
import { ref } from 'vue'
let time = ref(0)

setInterval(() => time.value++, 1000)
</script>