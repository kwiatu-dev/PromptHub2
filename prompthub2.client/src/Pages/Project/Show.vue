<template>
  <div class="w-full flex flex-row gap-4">
    <div class="w-1/2 md:w-2/5 bg-gray-200 shadow p-4 flex flex-col justify-between gap-4" style="height: calc(100vh - 64px - 2rem);">
      <BoxItem v-if="project" :project="project" view="single" />
    </div>
    <div class="w-1/2 md:w-3/5 overflow-y-auto" style="height: calc(100vh - 64px - 2rem);">
      <button class="btn-primary mb-4">Create prompt</button>
      <div v-if="project && project.prompts?.length" class="flex flex-col gap-4">
        <div v-for="prompt in project.prompts" :key="prompt.id" class="w-full bg-gray-100 shadow-sm p-4 flex flex-col gap-2">
          <div class="flex flex-col gap-2">
            <div class="text-black text-md leading-tight font-medium">{{ prompt.name }}</div>
            <div class="text-sm text-gray-500">{{ prompt.description }}</div>
          </div>
          <div class="flex flex-col gap-2">
            <div class="text-sm">
              <span class="font-medium">Model: </span> {{ prompt.model }}
            </div>
            <div class="text-sm">
              <span class="font-medium">Tokens: </span> {{ prompt.tokens }}
            </div>
            <div class="text-sm">
              <span class="font-medium">Messages: </span> {{ prompt.messages?.length ?? 0 }}
            </div>
            <div class="text-sm">
              <span class="font-medium">Created At: </span> {{ new Date(prompt.createdAt).toLocaleString() }}
            </div>
            <div class="text-sm">
              <span class="font-medium">Updated At: </span> {{ new Date(prompt.updatedAt).toLocaleString() }}
            </div>
            <div class="flex flex-row gap-2 mt-2">
              <button class="btn-primary flex-grow">Show</button>
              <button class="btn-primary" @click="copy">Copy</button>
              <button class="btn-primary">Delete</button>
            </div>
          </div>
        </div>
      </div>
      <div v-else>
        No element has yet been added to this project.
      </div>
    </div>
  </div>
</template>

<script setup>
import { useRoute, useRouter } from 'vue-router'
import { useStore } from 'vuex'
import { onMounted, computed, watch } from 'vue'
import BoxItem from '@/Pages/Project/Index/Components/BoxItem.vue'

const router = useRouter()
const route = useRoute()
const store = useStore()
const { uuid } = route.params
const project = computed(() => store.getters.StateProject)

onMounted(async () => {
  const result = await store.dispatch('GetProject', uuid)

  if(result === null){
    router.push({ name: 'projects' })
  }
})

watch(project, (project) => {
  if(!project){
    router.push({ name: 'projects' })
  }
})

const copy = () => {
  const clipboard = navigator.clipboard
  const text = import.meta.env.VITE_ENDPOINT_URL + '/' + project.value.id
  
  clipboard.writeText(text).then(() => { alert('tekst został skopiowany!') })
}
</script>