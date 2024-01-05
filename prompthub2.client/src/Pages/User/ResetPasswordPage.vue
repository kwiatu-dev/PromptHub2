<template>
  <div>
    <h1 class="title">Reset password</h1>
    <form class="grid grid-cols-12 gap-y-4 bg-gray-100 p-4" autocomplete="off" @submit.prevent="reset">
      <div class="col-span-12">
        <label for="password" class="label">Password</label>
        <input id="password" v-model="form.password" type="password" class="input-text" />
        <FormError :errors="form.errors.password" />
      </div>
      <div class="col-span-12">
        <label for="confirmpassword" class="label">Confirm password</label>
        <input id="confirmpassword" v-model="form.confirmpassword" type="password" class="input-text" />
        <FormError :errors="form.errors.confirmpassword" />
      </div>
      <div class="col-span-12">
        <div class="flex flex-row items-center justify-start gap-4">
          <button type="submit" class="btn-submit">Reset password</button>
        </div>
        <FormMessage :message="message" :status="status" />
      </div>
    </form>
  </div>
</template>
  
<script setup>
import { ref, reactive, onMounted } from 'vue'
import { useRoute } from 'vue-router'
import { useStore } from 'vuex'
import FormError from '@/components/FormError.vue'
import FormMessage from '@/components/FormMessage.vue'
  
const route = useRoute()
const store = useStore() 
const message = ref(null)
const status = ref(null)

const form = reactive({
  password: null,
  confirmpassword: null,
  token: null,
  email: null,
  errors: {},
})
  
const ResetPassword = async (payload) => await store.dispatch('ResetPassword', payload)
  
onMounted(() => {
  form.token = route.query.token
  form.email = route.query.email
})

const reset = async () => {
  const response = await ResetPassword(form)
  message.value = response.message
  status.value = response.status
  form.errors = response.errors ?? {}
  form.password = null
  form.confirmpassword = null
}
</script>