<template>
  <div 
    v-if="prompts && prompts?.length" 
    class="flex flex-col gap-4"
  >
    <div 
      v-for="prompt in prompts" 
      :key="prompt.id" 
      class="w-full bg-gray-100 shadow-sm p-4 flex flex-col gap-2"
    >
      <BoxItem :prompt="prompt" />
    </div>
  </div>
  <div v-else>
    {{ ItemsNotAddedTo('project') }}
  </div>
</template>

<script setup>
import { ItemsNotAddedTo } from '@/constants/inlineMessages'
import BoxItem from '@/Pages/Prompt/Index/Components/BoxItem.vue'

defineProps({
  prompts: Array,
})
</script>