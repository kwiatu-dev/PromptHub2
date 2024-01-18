<template>
  <DefaultPopup 
    :form="CreateForm" 
    caption="Create prompt" 
    title="Create prompt"
    class="mb-4"
    :object="project"
  />
  <FlexTemplate :prompts="prompts" />
</template>

<script setup>
import FlexTemplate from '@/Pages/Prompt/Index/Components/FlexTemplate.vue'
import DefaultPopup from '@/components/DefaultPopup.vue'
import CreateForm from '@/Pages/Prompt/Index/Components/CreateForm.vue'
import { onMounted, computed } from 'vue'
import { useStore } from 'vuex'
import { useRoute } from 'vue-router'

defineProps({
  project: {
    type: Object,
    required: true,
  },
})

const route = useRoute()
const store = useStore()
const prompts = computed(() => store.getters.StatePrompts)

onMounted(async () => {
  const { guid } = route.params
  await GetAllPrompts(guid)
})

const GetAllPrompts = async (guid) => await store.dispatch('GetAllPrompts', guid)
</script>