<template>
  <form 
    class="grid grid-cols-12 gap-4" 
    autocomplete="off" 
    @submit.prevent="create"
  >
    <div class="col-span-12">
      <label 
        for="name" 
        class="label"
      >
        Name
      </label>
      <input 
        id="name" 
        v-model="form.name" 
        type="text" 
        class="input-text"
      />
      <FormError :errors="form.errors.name" />
    </div>
    <div class="col-span-12">
      <label 
        for="description" 
        class="label"
      >
        Description
      </label>
      <textarea 
        id="description" 
        v-model="form.description" 
        class="input-text"
      />
      <FormError :errors="form.errors.description" />
    </div>
    <div class="col-span-12">
      <div class="flex flex-row items-center justify-start gap-4">
        <button 
          type="submit" 
          class="btn-submit"
        >
          Create
        </button>
      </div>
      <FormMessage 
        :message="message" 
        :status="status"
      />
    </div>
  </form>
</template>

<script setup>
import { useStore } from 'vuex'
import { ref, reactive } from 'vue'
import FormError from '@/components/FormError.vue'
import FormMessage from '@/components/FormMessage.vue'

const store = useStore()
const emit = defineEmits(['close'])

const CreateProject = async (form) => await store.dispatch('CreateProject', form)
const message = ref(null)
const status = ref(null)

const form = reactive({
  name: null,
  description: null,
  errors: {},
})

const create = async () => {
  const response = await CreateProject(form)
  message.value = response.message
  status.value = response.status
  form.errors = response.errors ?? {}

  if(!response.errors){
    form.errors = {}
    form.name = null
    form.description = null
    emit('close')
  }
}
</script>