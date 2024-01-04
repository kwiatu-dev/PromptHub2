import parseJwt from '@/helpers/parseJwt.js'
import Cookies from 'universal-cookie'
const cookies = new Cookies()
const EMAIL_SCHEMA = 'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'

export const userSessionPlugin = (store) => {
  const tokenString = cookies.get('token')

  if(tokenString){
    const token = parseJwt(tokenString)

    store.state.auth.user = {
      email: token[EMAIL_SCHEMA],
      token: tokenString,
    }
  }
}