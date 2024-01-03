<template>
  <Suspense>
    <MainLayout>
      <RouterView />
    </MainLayout>
  </Suspense>
</template>

<script setup>
import MainLayout from '@/Layout/MainLayout.vue'
</script>