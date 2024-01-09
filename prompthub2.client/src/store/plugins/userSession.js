import { ROLE_SCHEMA, EMAIL_SCHEMA } from '@/constants/schemas'
import { GetJWTFromCookie, GetJWTFromCookieAndParse } from '@/helpers/tokens'

export const userSessionPlugin = (store) => {
  const tokenString = GetJWTFromCookie()
  const token = GetJWTFromCookieAndParse()

  if(token){
    store.commit('SetUser', {
      email: token[EMAIL_SCHEMA],
      token: tokenString,
      role: token[ROLE_SCHEMA] ?? null,
    })
  }
}