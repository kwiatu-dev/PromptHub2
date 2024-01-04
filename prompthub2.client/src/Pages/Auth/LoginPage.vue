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
          <button type="submit" class="block bg-gray-300 px-4 py-1">Sign In</button>
          <RouterLink :to="{name: 'forgot_password'}">Forgot password? Click Here!</RouterLink>
        </div>
        <div v-if="showErrorMessage" class="input-error">
          Wystąpił co najmniej jeden błąd podczas przesyłania formularza!
        </div>
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
import { reactive, computed } from 'vue'
import FormError from '@/components/FormError.vue'

const router = useRouter()
const store = useStore()

const LogIn = async (form) => await store.dispatch('LogIn', form)

const form = reactive({
  email: null,
  password: null,
  errors: {},
})

const showErrorMessage = computed(() => form.errors && Object.keys(form.errors).length)

const auth = async () => {
  const response = await LogIn(form)

  if(response.errors){
    form.errors = response.errors
  }
  else{
    form.errors = {}
    router.push({ name: 'home' })
  }
}
</script>