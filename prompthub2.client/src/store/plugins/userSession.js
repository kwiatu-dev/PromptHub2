import parseJwt from '@/helpers/parseJwt.js'
import Cookies from 'universal-cookie'
import { ROLE_SCHEMA, EMAIL_SCHEMA } from '@/data/schemas'
const cookies = new Cookies()

export const userSessionPlugin = (store) => {
  const tokenString = cookies.get('token')

  if(tokenString){
    const token = parseJwt(tokenString)

    store.state.auth.user = {
      email: token[EMAIL_SCHEMA],
      token: tokenString,
      role: token[ROLE_SCHEMA] ?? null,
    }
  }
}