<template>
  <div v-if="isResponse">
    <div v-if="!errors">
      <p class="mb-2">
        Email verification successful. <br />
        Click the button to go to the login page.
      </p>
      <RouterLink 
        :to="{ name: 'login' }" 
        class="bg-gray-300 px-4 py-1"
      >
        Sign In
      </RouterLink>
    </div>
    <div v-else>
      <p class="mb-2">
        Email verification failed. <br />
        Please contact with support team.
      </p>
      <ul>
        <li v-for="(error, index) in errors" :key="index">
          - {{ error.join(", ") }}
        </li>
      </ul>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { useRoute } from 'vue-router'
import { useStore } from 'vuex'

const route = useRoute()
const store = useStore() 
const errors = ref(null)
const isResponse = ref(false)

const ConfirmEmail = async (payload) => await store.dispatch('ConfirmEmail', payload)

onMounted(() => {
  const token = route.query.token
  const email = route.query.email

  ConfirmEmail({ token, email }).then(response => {
    isResponse.value = true
    errors.value = response.errors ?? null
  })
})
</script>