import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '@/Pages/Home/HomePage.vue'
import LoginPage from '@/Pages/Auth/LoginPage.vue'
import UserCreate from '@/Pages/User/UserCreate.vue'
import ProjectIndex from '@/Pages/Project/Index.vue'
import ProjectShow from '@/Pages/Project/Show.vue'
import ConfirmEmail from '@/Pages/Auth/ConfirmEmail.vue'
import ForgotPasswordPage from '@/Pages/User/ForgotPasswordPage.vue'
import ResetPasswordPage from '@/Pages/User/ResetPasswordPage.vue'
import AdminPage from '@/Pages/Admin/AdminPage.vue'
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
    component: ProjectIndex,
    name: 'projects',
    meta: { auth: true },
  },
  {
    path: '/projects/:guid',
    component: ProjectShow,
    name: 'project',
    meta: { auth: true },
  },
  {
    path: '/login',
    component: LoginPage,
    name: 'login',
    meta: { guest: true },
  },
  {
    path: '/register',
    component: UserCreate,
    name: 'register',
    meta: { guest: true },
  },
  {
    path: '/Authenticate/ConfirmEmail',
    component: ConfirmEmail,
    name: 'confirm_email',
    meta: { guest: true },
  },
  {
    path: '/Account/ForgotPassword',
    component: ForgotPasswordPage,
    name: 'forgot_password',
    meta: { guest: true },
  },
  {
    path: '/Account/ResetPassword',
    component: ResetPasswordPage,
    name: 'reset_password',
    meta: { guest: true },
  },
  {
    path: '/AdminPage',
    component: AdminPage,
    name: 'admin',
    meta: { roles: ['admin'] },
  },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

router.beforeEach((to, from, next) => {
  const { auth } = to.meta
  const isAuthenticated = store.getters.isAuthenticated

  if(auth){
    if(isAuthenticated){
      next()
      return
    }
    next({ name: 'login' })
    return
  }
  next()
})

router.beforeEach((to, from, next) => {
  const { roles } = to.meta
  const isAuthenticated = store.getters.isAuthenticated
  const user = store.getters.StateUser

  if(roles){
    if(isAuthenticated){
      if(roles.some(role => 
        user?.roles && user?.roles.includes(role)))
      {
        next()
        return
      }
      next({ name: to.from })
      return
    }
    next({ name: 'login' })
    return
  }
  next()
})

router.beforeEach((to, from, next) => {
  const { guest } = to.meta
  const isAuthenticated = store.getters.isAuthenticated

  if(guest){
    if(isAuthenticated && to.name !== 'home'){
      next({ name: 'home' })
      return
    }
    next()
    return
  }
  next()
})

export default router