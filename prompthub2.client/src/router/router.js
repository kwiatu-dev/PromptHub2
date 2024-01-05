import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '@/Pages/Home/HomePage.vue'
import LoginPage from '@/Pages/Auth/LoginPage.vue'
import UserCreate from '@/Pages/User/UserCreate.vue'
import ProjectPage from '@/Pages/Project/ProjectPage.vue'
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
    component: ProjectPage,
    name: 'projects',
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

// router.beforeEach((to, from, next) => {
//   const { roles } = to.meta
//   const user = store.getters.StateUser

//   if(roles){
//     console.log(store.getters)
//   }

//   next()
// })

router.beforeEach((to, from, next) => {
  const { auth } = to.meta
  const isAuth = store.getters.isAuthenticated

  if(auth === true && isAuth === false){
    next({ name: 'login' })
    return
  }
  next()
})

export default router