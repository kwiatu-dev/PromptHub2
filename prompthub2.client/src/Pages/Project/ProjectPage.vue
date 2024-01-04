<template>
  ProjectPage
</template>

<script setup>
import axios from 'axios'


axios.post('/echo', {
  message: 'Hello world!',
}).then(response => {
  console.log(response.data)
}).catch(error => {
  console.log(error.response.data)
})



</script>