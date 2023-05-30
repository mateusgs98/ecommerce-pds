import NextAuth from 'next-auth';
import CredentialsProvider from "next-auth/providers/credentials";
import { api } from '../../../Lib/api';

export default NextAuth({
  // Configure one or more authentication providers
  providers: [
    CredentialsProvider({
      name: 'Credentials',
      credentials: {
        username: { label: 'Username', type: 'text', placeholder: 'jsmith' },
        password: { label: 'Password', type: 'password' },
      },
      async authorize(credentials) {
        try {
          // const user = await api.post('/usuario/login', credentials)
          const user = { id: "1", name: "J Smith", email: "jsmith@example.com" }
          if (user) {
            return user;
          }
          return null;
        } catch (error) {
          return null;
        }
      }
    })
  ],
  callbacks: {
    async jwt(token, user, account, profile, isNewUser) {
      return token
    },
    async session(session, token) {
      return session
    }
  },
  pages: {
    signIn: '/login',
    signOut: '/logout',
    error: '/login',  
    verifyRequest: '/login',
    newUser: '/register'
  },
  jwt: {
    secret: 'SEU_SECRET',
    verificationOptions: {
      algorithms: ['HS256']
    },
  },
  session: {
    jwt: true,
    maxAge: 24 * 60 * 60,
    updateAge: 24 * 60 * 60,
  },
})