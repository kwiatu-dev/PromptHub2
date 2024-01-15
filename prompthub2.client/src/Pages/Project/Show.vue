<template>
  <div class="w-full flex flex-row gap-8">
    <div class="w-1/2 md:w-2/5 bg-gray-200 shadow p-4 flex flex-col justify-between gap-4" style="height: calc(100vh - 64px - 2rem);">
      <BoxItem v-if="project" :project="project" view="single" />
    </div>
    <div class="w-1/2 md:w-3/5">
      Project Show
      {{ route.params }}
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
</script>