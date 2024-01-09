<template>
  <div>
    <HeaderSection />
    <main class="max-w-screen-xl mx-auto p-4">
      <slot />
    </main>
  </div>
</template>

<script setup>
import HeaderSection from '@/components/HeaderSection.vue'
</script>