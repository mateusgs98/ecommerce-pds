
import { api } from '@/Lib/api';
import ExternalPageLayout from '@/components/ExternalPageLayout';
import FormRegister from '@/components/Forms/FormRegister';
import { FormikHelpers } from 'formik';
import { getSession } from 'next-auth/react';
import Router from 'next/router';
import Swal from 'sweetalert2';

export default function Register() {
  const handleRegister = (data: object, formik: FormikHelpers<any>) => {
    (api.post('/usuario/cadastrar', data)).then((response) => {
      Swal.fire({
        title: 'Sucesso',
        text: 'Usuário cadastrado com sucesso, Faça login para continuar!',
        icon: 'success',
        confirmButtonText: 'Cool'
      }).then(() => {
        Router.push('/login');
      })
    }).catch((error) => {
      Swal.fire({
        title: 'Erro',
        text: 'Erro ao cadastrar usuário',
        icon: 'error',
        confirmButtonText: 'Cool'
      })
      formik.setSubmitting(false);
    });
  };

  return (
    <>
      <ExternalPageLayout width="1200px">
        <FormRegister onSubmit={handleRegister} />
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