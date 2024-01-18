<template>
  <nav class="bg-gray-600">
    <div class="max-w-screen-xl flex flex-wrap items-center justify-between mx-auto p-4">
      <RouterLink 
        class="flex items-center space-x-3" 
        :to="{ name: 'home' }"
      >
        <span class="self-center text-2xl font-semibold whitespace-nowrap text-white">
          PromptHub
        </span>
      </RouterLink>
      <div class="flex items-center md:order-2 space-x-6 md:space-x-0">
        <div v-if="!isLoggedIn">
          <RouterLink 
            :to="{ name: 'login' }" 
            class="bg-gray-900 px-4 py-2 text-white font-medium"
          >
            Sign in
          </RouterLink>
        </div>
        <div v-else class="relative">
          <button 
            class="flex text-sm rounded-full" 
            @click="toggleUserMenu"
          >
            <div class="w-8 h-8 bg-gray-200 rounded-full" />
          </button>
          <div 
            class="z-10 my-4 text-base list-none bg-gray-700 divide-y divide-gray-600 shadow absolute" 
            :class="[showUserMenu ? 'block' : 'hidden']" 
            style="right: calc(100% - 32px)"
          >
            <div class="px-4 py-3">
              <span class="block text-sm text-white">
                User
              </span>
              <span class="block text-sm  text-gray-400 truncate">
                {{ user?.email }}
              </span>
            </div>
            <ul class="py-2">
              <li>
                <button 
                  class="block px-4 py-2 text-sm text-white" 
                  @click="logout"
                >
                  Log out
                </button>
              </li>
            </ul>
          </div>
        </div>
        <button 
          class="inline-flex items-center justify-center text-gray-300 md:hidden" 
          @click="toggleMenu"
        >
          <svg class="w-6 h-6" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 17 14">
            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 1h15M1 7h15M1 13h15" />
          </svg>
        </button>
      </div>
      <div 
        class="mt-4 md:mt-0 items-center justify-between w-full md:flex md:w-auto md:order-1 bg-gray-700 md:bg-transparent" 
        :class="[showMenu ? 'block' : 'hidden']"
      >
        <ul class="flex flex-col font-medium md:p-0 md:space-x-8 md:flex-row md:mt-0 md:border-0">
          <li>
            <RouterLink 
              :to="{ name: 'home' }" 
              class="block py-2 px-3 md:p-0 border-solid border-b md:border-none border-gray-500 text-white"
              :active-class="'!text-gray-400'"
            >
              Home
            </RouterLink>
          </li>
          <li>
            <RouterLink 
              :to="{ name: 'projects' }" 
              class="block py-2 px-3 md:p-0 border-solid border-b md:border-none border-gray-500 text-white"
              :active-class="'!text-gray-400'"
            >
              Projects
            </RouterLink>
          </li>
          <li v-if="isAdmin">
            <RouterLink 
              :to="{ name: 'admin' }" 
              class="block py-2 px-3 md:p-0 text-white"
              :active-class="'!text-gray-400'"
            >
              Admin
            </RouterLink>
          </li>
        </ul>
      </div>
    </div>
  </nav>
</template>

<script setup>
import { useStore } from 'vuex'
import { useRouter } from 'vue-router'
import { ref, computed } from 'vue'

const router = useRouter()
const store = useStore()
const user = computed(() => store.getters.StateUser)
const isLoggedIn = computed(() => store.getters.isAuthenticated)
const isAdmin = computed(() => store.getters.isAdmin)

const showUserMenu = ref(false)
const showMenu = ref(false)

const toggleUserMenu = () => {
  showUserMenu.value = !showUserMenu.value
  
  if(showUserMenu.value && showMenu.value){
    showMenu.value = false
  }
}

const toggleMenu = () => {
  showMenu.value = !showMenu.value

  if(showUserMenu.value && showMenu.value){
    showUserMenu.value = false
  }
}

const logout = async () => {
  await store.dispatch('LogOut')
  router.push({ name: 'home' })
  showUserMenu.value = false
}
</script>