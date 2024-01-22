<template>
  <div 
    class="w-full flex flex-row gap-4"
    style="height: calc(100vh - 64px - 2rem);"
  >
    <div class="w-1/2 md:w-2/5 bg-gray-200 shadow p-4">
      <BoxItem 
        v-if="project" 
        :project="project" 
        view="single"
        @deleted="back"
      />
    </div>
    <div class="w-1/2 md:w-3/5 overflow-y-auto">
      <PromptPage 
        v-if="project" 
        :project="project"
        @changed="update"
      />
    </div>
  </div>
</template>

<script setup>
import PromptPage from '@/Pages/Prompt/Index.vue'
import BoxItem from '@/Pages/Project/Index/Components/BoxItem.vue'
import { useRoute, useRouter } from 'vue-router'
import { useStore } from 'vuex'
import { onMounted, computed } from 'vue'

const router = useRouter()
const route = useRoute()
const store = useStore()

store.commit('ResetProjectState')

const { guid } = route.params
const project = computed(() => store.getters.StateProject)

onMounted(async () => {
  const result = await store.dispatch('GetProject', guid)

  if(result?.id === undefined){
    router.push({ name: 'projects' })
  }
})

const back = () => {
  router.push({ name: 'projects' })
}

const update = async () => {
  await store.dispatch('GetProject', guid)
}
</script>