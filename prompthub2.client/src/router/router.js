import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '@/Pages/Home/HomePage.vue'
import LoginPage from '@/Pages/Auth/LoginPage.vue'
import UserCreate from '@/Pages/User/UserCreate.vue'

const routes = [
  {
    path: '/',
    component: HomePage,
    name: 'home',
    alias: ['/home', '/homepage'],
  },
  {
    path: '/login',
    component: LoginPage,
    name: 'login',
  },
  {
    path: '/register',
    component: UserCreate,
    name: 'register',
  },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

export default router