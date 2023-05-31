
import ExternalPageLayout from '@/components/ExternalPageLayout';
import FormLogin from '@/components/Forms/FormLogin';
import { getSession, signIn, useSession } from 'next-auth/react';
import Router from 'next/router';
import { useEffect } from 'react';

export default function Login() {

  const handleLogin = async (values: any) => {
    const res = await signIn("credentials", {
      redirect: false,
      email: values['email'],
      password: values['password']
    });

    if (res?.error) {
      alert("Falha ao realizar login");
      return;
    }

    Router.push('/dashboard');
  };


  return (
    <>
      <ExternalPageLayout>
        <FormLogin onSubmit={handleLogin} />
      </ExternalPageLayout>
    </>
  );
}

export async function getServerSideProps(ctx: any) {
  const session = await getSession(ctx);

  if (session) {
    return {
      redirect: {
        destination: '/dashboard',
        permanent: false,
      },
    };
  }

  return {
    props: { session },
  };
}