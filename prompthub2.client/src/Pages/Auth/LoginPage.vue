<template>
  <div>
    <h1 class="title">Sign In</h1>
    <form class="grid grid-cols-12 gap-y-4 bg-gray-100 p-4" autocomplete="off" @submit.prevent="auth">
      <div class="col-span-12">
        <label for="email" class="label">Email</label>
        <input id="email" v-model="form.email" type="text" class="input-text" />
        <FormError :errors="form.errors.email" />
      </div>
      <div class="col-span-12">
        <label for="password" class="label">Password</label>
        <input id="password" v-model="form.password" type="password" class="input-text" />
        <FormError :errors="form.errors.password" />
      </div>
      <div class="col-span-12">
        <div class="flex flex-row items-center justify-start gap-4">
          <button type="submit" class="btn-submit">Sign In</button>
          <RouterLink :to="{name: 'forgot_password'}">Forgot password? Click Here!</RouterLink>
        </div>
        <FormMessage :message="message" :status="status" />
      </div>
    </form>
    <div class="bg-gray-300 px-4 py-2">
      <RouterLink :to="{name: 'register'}">Don't have an account? Click here!</RouterLink>
    </div>
  </div>
</template>

<script setup>
import { useStore } from 'vuex'
import { useRouter } from 'vue-router'
import { ref, reactive, computed } from 'vue'
import FormError from '@/components/FormError.vue'
import FormMessage from '@/components/FormMessage.vue'

const router = useRouter()
const store = useStore()

const LogIn = async (form) => await store.dispatch('LogIn', form)
const message = ref(null)
const status = ref(null)

const form = reactive({
  email: null,
  password: null,
  errors: {},
})

const auth = async () => {
  const response = await LogIn(form)
  message.value = response.message
  status.value = response.status
  form.errors = response.errors ?? {}

  if(!response.errors){
    form.errors = {}
    router.push({ name: 'home' })
  }
}
</script>