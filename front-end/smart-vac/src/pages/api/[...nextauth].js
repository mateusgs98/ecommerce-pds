import NextAuth from 'next-auth';
import Providers from 'next-auth/react';

const options = {
  providers: [
    Providers.Credentials({
      credentials: {
        username: { label: 'Username', type: 'text' },
        password: { label: 'Password', type: 'password' }
      },
      authorize: async (credentials) => {
        const res = await axios.post(URL_API + '/login', credentials);
        const data = await res.json();

        if (res.ok && data.success) {
          return { id: data.user.id, name: data.user.name };
        } else {
          throw new Error(data.message);
        }
      }
    })
  ],
  secret: JWT_SECRET,
  session: {
    jwt: true
  }
};

export default (req, res) => NextAuth(req, res, options);