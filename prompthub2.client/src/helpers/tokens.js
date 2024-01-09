import { JWT_COOKIE_TOKEN } from '@/constants/tokens'
import parseJwt from '@/helpers/parseJwt'
import Cookies from 'universal-cookie'
const cookies = new Cookies()

export const GetJWTFromCookie = () => {
  return cookies.get(JWT_COOKIE_TOKEN)
}

export const GetJWTFromCookieAndParse = () => {
  const token = cookies.get(JWT_COOKIE_TOKEN)
  return token ? parseJwt(token) : null
}

export const SetJWTCookie = (token, options) => {
  cookies.set(JWT_COOKIE_TOKEN, token, { ...options })
}

export const RemoveJWTCookie = () => {
  cookies.remove(JWT_COOKIE_TOKEN)
}