<template>
  <div v-if="resultLoaded">
    <div v-if="!errors">
      <p class="mb-2">
        {{ EmailVerifySuccessful }}
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
        {{ EmailVerifyFail }}
      </p>
      <ul>
        <li 
          v-for="(error, index) in errors" 
          :key="index"
        >
          - {{ error.join(", ") }}
        </li>
      </ul>
    </div>
  </div>
</template>

<script setup>
import { EmailVerifySuccessful, EmailVerifyFail } from '@/constants/inlineMessages'
import { ref, onMounted } from 'vue'
import { useRoute } from 'vue-router'
import { useStore } from 'vuex'

const route = useRoute()
const store = useStore() 
const errors = ref(null)
const resultLoaded = ref(false)

const ConfirmEmail = async (payload) => await store.dispatch('ConfirmEmail', payload)

onMounted(async () => {
  const token = route.query.token
  const email = route.query.email
  const result = await ConfirmEmail({ token, email })
  resultLoaded.value = true
  errors.value = result.errors ?? null
})
</script>