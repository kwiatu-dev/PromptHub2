<template>
  <div v-if="errors.length" class="input-error">
    <ul>
      <li v-for="(error, index) in errors" :key="index">
        {{ error }}
      </li>
    </ul>
  </div>
</template>

<script setup>
defineProps({
  errors: Array,
})
</script>