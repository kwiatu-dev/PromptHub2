<template>
  <div>
    <HeaderSection />
    <main class="container mx-auto py-5">
      <slot />
    </main>
  </div>
</template>

<script setup>
import HeaderSection from '@/components/HeaderSection.vue'
</script>