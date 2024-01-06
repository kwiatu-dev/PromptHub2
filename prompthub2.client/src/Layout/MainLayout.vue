<template>
  <div>
    <HeaderSection />
    <main class="container mx-auto py-5 px-4 md:px-0">
      <slot />
    </main>
  </div>
</template>

<script setup>
import HeaderSection from '@/components/HeaderSection.vue'
</script>