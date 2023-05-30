
import ExternalPageLayout from '@/components/ExternalPageLayout';
import FormRegister from '@/components/Forms/FormRegister';
import { useSession } from 'next-auth/react';
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

  const handleRegister = (data:object) => {
    
  };

  return (
    <>
      <ExternalPageLayout width="1200px">
        <FormRegister onSubmit={handleRegister} />
      </ExternalPageLayout>
    </>
  );
}
