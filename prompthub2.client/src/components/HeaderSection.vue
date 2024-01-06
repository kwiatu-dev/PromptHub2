<template>
  <header class="text-gray-600 body-font border-solid border-b-2 border-gray-200">
    <div class="container mx-auto flex flex-wrap py-5 justify-between flex-col md:flex-row items-center px-4 md:px-0">
      <div class="flex flex-row gap-4 items-center">
        <RouterLink :to="{name: 'home'}" class="title-font font-mediumtext-gray-900 text-2xl">PromptHub</RouterLink>
        <nav class="flex flex-wrap justify-start items-center text-base gap-2">
          <RouterLink :to="{name: 'projects'}">Projects</RouterLink>
        </nav>
      </div>
      <div v-if="!isLoggedIn" class="flex flex-row gap-4">
        <RouterLink :to="{name: 'login'}" class="inline-flex items-center border-solid border-2 border-gray-100 py-1 px-3 rounded text-base">
          Sign in
        </RouterLink>
        <RouterLink :to="{name: 'register'}" class="inline-flex items-center bg-gray-100 border-0 py-1 px-3 rounded text-base">
          Sign up
        </RouterLink>
      </div>
      <div v-else>
        <button @click="logout">Log out</button>
      </div>
    </div>
  </header>
</template>

<script setup>
import { useStore } from 'vuex'
import { useRouter } from 'vue-router'
import { computed } from 'vue'

// import { library } from '@fortawesome/fontawesome-svg-core'
// import { faStar } from '@fortawesome/free-solid-svg-icons'

// library.add(faStar)

const router = useRouter()
const store = useStore()
const isLoggedIn = computed(() => store.getters.isAuthenticated)

const logout = async () => {
  await store.dispatch('LogOut')
  router.push({ name: 'home' })
}
</script>