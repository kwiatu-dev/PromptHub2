<template>
  AdminPage
</template>

<script setup>
import axios from 'axios'

const antiforgery = await axios.get('/antiforgery/token')

const payload = { message: 'Hello world!' }

const options = { 
  headers: {
    'X-XSRF-TOKEN': antiforgery.data.token,
  } 
}

const response = await axios.post('/echo', payload, options)
console.log(response.data.message)

</script>