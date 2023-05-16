
import ExternalPageLayout from '@/components/ExternalPageLayout';
import FormRegister from '@/components/Forms/FormRegister';

export default function Login() {
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
