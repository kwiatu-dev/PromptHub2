import { EMAIL_CLAIM, ROLE_CLAIM } from '@/constants/claims'
import { JWT_COOKIE } from '@/constants/cookies'
import parseJwt from '@/helpers/parseJwt'
import Cookies from 'universal-cookie'
const cookies = new Cookies()

const getJwt = () => {
  return cookies.get(JWT_COOKIE)
}

const setJwt = (token, options) => {
  cookies.set(JWT_COOKIE, token, options)
}

const getUser = () => {
  const token = getJwt()
  const jwt = token ? parseJwt(token) : null

  return buildUser(jwt)
}

const setUser = (token) => {
  const jwt = parseJwt(token)
  const expires = new Date(jwt.exp * 1000)
  setJwt(token, { expires })

  return buildUser(jwt)
}

const removeJwt = () => {
  cookies.remove(JWT_COOKIE)
}

const removeUser = () => {
  removeJwt()
}

const buildUser = (jwt) => {
  if(jwt){
    return {
      email: jwt[EMAIL_CLAIM],
      token: jwt,
      role: jwt[ROLE_CLAIM] ?? null,
    }
  }

  return null
}

export default {
  getUser,
  setUser,
  removeUser,
  getJwt,
}