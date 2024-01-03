<template>
  <div>
    <h1 class="title">Log in</h1>
    <form class="grid grid-cols-12 gap-y-4 bg-gray-100 p-4" autocomplete="off" @submit.prevent="auth">
      <div class="col-span-12">
        <label for="email" class="label">Email</label>
        <input id="email" v-model="form.email" type="text" class="input-text" />
        <FormError :errors="['error 1', 'error 2']" />
      </div>
      <div class="col-span-12">
        <label for="email" class="label">Password</label>
        <input id="email" v-model="form.password" type="text" class="input-text" />
        <FormError :errors="['error 1', 'error 2']" />
      </div>
      <div class="col-span-12">
        <button type="submit" class="block bg-gray-300 px-4 py-1">Log in</button>
        <FormError :errors="['error 1', 'error 2']" />
      </div>
    </form>
  </div>
</template>

<script setup>
import { useStore } from 'vuex'
import { useRouter } from 'vue-router'
import { reactive } from 'vue'
import FormError from '@/components/FormError.vue'

const router = useRouter()
const store = useStore()

const LogIn = async (form) => await store.commit('LogIn', form)

const form = reactive({
  email: null,
  password: null,
})

const auth = async () => {
  const response = await LogIn(form)
  console.log(response)
}
</script>