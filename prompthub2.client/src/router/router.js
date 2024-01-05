import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '@/Pages/Home/HomePage.vue'
import LoginPage from '@/Pages/Auth/LoginPage.vue'
import UserCreate from '@/Pages/User/UserCreate.vue'
import ProjectPage from '@/Pages/Project/ProjectPage.vue'
import ConfirmEmail from '@/Pages/Auth/ConfirmEmail.vue'
import ForgotPasswordPage from '@/Pages/User/ForgotPasswordPage.vue'
import ResetPasswordPage from '@/Pages/User/ResetPasswordPage.vue'
import store from '@/store'

const routes = [
  {
    path: '/',
    component: HomePage,
    name: 'home',
    alias: ['/home', '/homepage'],
    meta: { guest: true },
  },
  {
    path: '/projects',
    component: ProjectPage,
    name: 'projects',
    meta: { requiresAuth: true },
  },
  {
    path: '/login',
    component: LoginPage,
    name: 'login',
    meta: { auth: true },
  },
  {
    path: '/register',
    component: UserCreate,
    name: 'register',
    meta: { auth: true },
  },
  {
    path: '/Authenticate/ConfirmEmail',
    component: ConfirmEmail,
    name: 'confirm_email',
    meta: { auth: true },
  },
  {
    path: '/Account/ForgotPassword',
    component: ForgotPasswordPage,
    name: 'forgot_password',
    meta: { auth: true },
  },
  {
    path: '/Account/ResetPassword',
    component: ResetPasswordPage,
    name: 'reset_password',
    meta: { auth: true },
  },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

router.beforeEach((to, from, next) => {
  if(to.matched.some(record => record.meta.requiresAuth)){
    if(store.getters.isAuthenticated){
      next()
      return
    }
    next({ name: 'login' })
  }
  else{
    next()
  }
})

router.beforeEach((to, from, next) => {
  if(to.matched.some(record => record.meta.auth)){
    if(store.getters.isAuthenticated){
      next({ name: 'home' })
      return
    }
    next()
  }
  else{
    next()
  }
})

export default router