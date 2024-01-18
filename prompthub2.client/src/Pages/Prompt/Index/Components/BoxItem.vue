<template>
  <div class="flex flex-col">
    <div class="text-black text-md leading-tight font-medium">
      {{ prompt.name }}
    </div>
    <div class="text-sm text-gray-500">
      {{ prompt.description }}
    </div>
  </div>
  <div class="flex flex-col gap-2">
    <div class="text-sm">
      <span class="font-medium">
        Model: 
      </span> 
      {{ prompt.model }}
    </div>
    <div class="text-sm">
      <span class="font-medium">
        Tokens: 
      </span> 
      {{ prompt.tokens }}
    </div>
    <div class="text-sm">
      <span class="font-medium">
        Messages: 
      </span> 
      {{ prompt.messagesCount }}
    </div>
    <div class="text-sm">
      <span class="font-medium">
        Created At: 
      </span> 
      {{ prompt.createdAt }}
    </div>
    <div class="text-sm">
      <span class="font-medium">
        Updated At: 
      </span> 
      {{ prompt.updatedAt }}
    </div>
    <div class="flex flex-row gap-2 mt-2">
      <button class="btn-primary flex-grow">
        Show
      </button>
      <button 
        class="btn-primary" 
        @click="copy"
      >
        Copy
      </button>
      <DeleteButton :prompt="prompt" />
    </div>
  </div>
</template>

<script setup>
import DeleteButton from '@/Pages/Prompt/Index/Components/DeleteButton.vue'

const props = defineProps({
  prompt: {
    type: Object,
    required: true,
  },
})

const copy = () => {
  const clipboard = navigator.clipboard
  const text = import.meta.env.VITE_ENDPOINT_URL + '/prompts/' + props.prompt.projectId
  clipboard.writeText(text).then(() => { alert('tekst został skopiowany!') })
}
</script>