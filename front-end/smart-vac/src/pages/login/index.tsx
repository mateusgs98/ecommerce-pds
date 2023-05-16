
import ExternalPageLayout from '@/components/ExternalPageLayout';
import FormLogin from '@/components/Forms/FormLogin';
import { signIn } from 'next-auth/react';

export default function Login() {
  const handleLogin = (data:object) => {
    //   const result = await signIn('credentials', {
    //     redirect: false,
    //     data['username'],
    //     data['password']
    //   });
  
    //   if (result.error) {
    //     setError(result.error);
    //   }
    // };
    // signIn();
  };

  return (
    <>
      <ExternalPageLayout>
        <h2>Login</h2>
        <FormLogin onSubmit={handleLogin} />
      </ExternalPageLayout>
    </>
  );
}
