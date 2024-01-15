<template>
  Project Show
  {{ route.params }}
</template>

<script setup>
import { useRoute } from 'vue-router'

const route = useRoute()

</script>