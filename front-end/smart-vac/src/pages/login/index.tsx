
import ExternalPageLayout from '@/components/ExternalPageLayout';
import FormLogin from '@/components/Forms/FormLogin';
import { signIn, useSession } from 'next-auth/react';
import Router from 'next/router';
import { useEffect } from 'react';

export default function Login() {
  const { data: session, status } = useSession();

  useEffect(() => {
    console.log(status, session);
    if (status === "authenticated") {
      Router.push('/dashboard');
    }
  }, [status]);

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

// export async function getServerSideProps(context: any) {
//   const session = await getSession(context);
//   console.log(session);
//   if (session) {
//     return {
//       redirect: {
//         destination: '/dashboard',
//         permanent: false,
//       },
//     };
//   }

//   return {
//     props: { session },
//   };
// }