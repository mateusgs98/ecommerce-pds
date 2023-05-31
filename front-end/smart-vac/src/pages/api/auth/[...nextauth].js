import NextAuth from 'next-auth';
import CredentialsProvider from "next-auth/providers/credentials";
import { api } from '../../../Lib/api';

export default NextAuth({
  // Configure one or more authentication providers
  providers: [
    CredentialsProvider({
      name: 'Credentials',
      async authorize(credentials) {
        try {
          const body = {
            Email: credentials.email,
            Senha: credentials.password
          }
          // const user = await api.post('/usuario/login', body)
          const user = { Id: "1", Nome: "J Smith", Email: "jsmith@example.com", Paciente: false, DataNascimento: '2002-01-01' }
          if (user) {
            return Promise.resolve(user);
          }
          return Promise.resolve(null);
        } catch (error) {
          return Promise.resolve(null);
        }
      }
    })
  ],
  callbacks: {
    async jwt({ token, user }) {
      if (user) {
        token.user = user;
      }
      return token
    },
    async session({ session, token }) {
      session.user = token.user;
      return session
    }

  },
  session: {
    jwt: true,
    maxAge: 60 * 60 // 1 hour
  },
  jwt: {
    secret: 'INp8IvdIyeMcoGAgFGoA61DdBglwwSqnXJZkgz8PSnw',
    encryption: true
  }
})