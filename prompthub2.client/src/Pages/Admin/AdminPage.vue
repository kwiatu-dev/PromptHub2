<template>
  AdminPage
</template>

<script setup>
import axios from 'axios'
const response = await axios.post('/echo', { message: 'Hello world!' })
console.log(response.data.message)
</script>