<template>
  <div class="flex flex-col justify-between gap-4 w-full h-full">
    <div class="mb-2">
      <div 
        class="text-lg font-medium !mb-0" 
        :class="{'title': view === 'single'}"
      >
        {{ project.name }}
      </div>
      <p 
        class="text-sm text-gray-400" 
        :class="{'!text-base': view === 'single'}"
      >
        {{ project.description }}
      </p>
    </div>
    <div>
      <div class="flex flex-col">
        <div class="w-full">
          <span class="text-sm font-bold">
            Prompts: 
          </span> 
          {{ project.promptsCount }}
        </div>
        <div class="w-full">
          <span class="text-sm font-bold">
            Created at: 
          </span> 
          {{ project.createdAt }}          
        </div>
        <div class="w-full">
          <span class="text-sm font-bold">
            Updated at: 
          </span> 
          {{ project.updatedAt }}          
        </div>
      </div>
      <div class="mt-4 flex flex-col sm:flex-row flex-wrap gap-2">
        <RouterLink 
          v-if="view !== 'single'" 
          class="btn-primary flex-grow" 
          :to="{ name: 'project', params: { guid: project.id } }"
        >
          Show
        </RouterLink>
        <DefaultPopup 
          :form="EditForm" 
          caption="Edit" 
          title="Edit project"
          :object="project"
        />
        <DeleteButton :project="project" @deleted="emit('deleted')" />
      </div>
    </div>
  </div>
</template>

<script setup>
import DefaultPopup from '@/components/DefaultPopup.vue'
import EditForm from '@/Pages/Project/Index/Components/EditForm.vue'
import DeleteButton from '@/Pages/Project/Index/Components/DeleteButton.vue'

defineProps({
  project: {
    type: Object,
    required: true,
  },
  view: String,
})

const emit = defineEmits(['deleted'])
</script>