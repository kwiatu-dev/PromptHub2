<template>
  ConfirmEmail
  <br />
  {{ token }}
  <br />
  {{ email }}
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { useRoute } from 'vue-router'

const router = useRoute() 
const token = ref('')
const email = ref('')

onMounted(() => {
  token.value = router.query.token
  email.value = router.query.email
})
</script>