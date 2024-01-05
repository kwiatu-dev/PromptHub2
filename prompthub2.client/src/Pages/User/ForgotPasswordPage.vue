<template>
  <div>
    <h1 class="title">Forgot password</h1>
    <form class="grid grid-cols-12 gap-y-4 bg-gray-100 p-4" autocomplete="off" @submit.prevent="auth">
      <div class="col-span-12">
        <label for="email" class="label">Email</label>
        <input id="email" v-model="form.email" type="text" class="input-text" />
        <FormError :errors="form.errors.email" />
      </div>
      <div class="col-span-12">
        <div class="flex flex-row items-center justify-start gap-4">
          <button type="submit" class="btn-submit">Send</button>
        </div>
        <FormMessage :message="message" :status="status" />
      </div>
    </form>
  </div>
</template>
  
<script setup>
import { useStore } from 'vuex'
import { ref, reactive } from 'vue'
import FormError from '@/components/FormError.vue'
import FormMessage from '@/components/FormMessage.vue'
  
const store = useStore()
  
const ForgotPassword = async (form) => await store.dispatch('ForgotPassword', form)
const message = ref(null)
const status = ref(null)

const form = reactive({
  email: null,
  errors: {},
})
  
const auth = async () => {
  const response = await ForgotPassword(form)
  message.value = response.message
  status.value = response.status
  form.errors = response.errors ?? {}
  form.email = null
}
</script>