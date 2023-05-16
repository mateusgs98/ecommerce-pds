import { Input } from "@/components/FormElements/Input";
import { FormContainer } from "@/components/Forms/FormLogin/styles";
import { Form, Formik } from "formik";
import { Button } from "react-bootstrap";
import * as Yup from 'yup';

interface FormRegisterProps {
    onSubmit: (data: object) => void;
}

export default function FormRegister(props: FormRegisterProps) {
    const initialValues = {
        email: '',
        password: '',
    };

    const validationSchema = Yup.object().shape({
        email: Yup.string().email('Digite um e-mail válido').required('Campo obrigatório'),
        password: Yup.string().required('Campo obrigatório'),
    });

    return (
        <>
            <Formik
                initialValues={initialValues}
                validationSchema={validationSchema}
                onSubmit={props.onSubmit}
            >
                {({ isSubmitting }) => (
                    <Form>
                        <FormContainer>
                            <h2>Criar Conta</h2>
                            <div className="custom-row">
                                <Input name="name" label="Nome Completo" />
                                <Input name="email" label="E-mail" />
                                <Input name="birthdate" type="date" label="Data de Nascimento" />
                            </div>
                            <div className="custom-row">
                                <Input name="password" type="password" label="Senha" />
                                <Input name="confirmPassword" type="password" label="Confirmar Senha" />
                            </div>
                            <div className="custom-row">
                                <Input name="terms" type="checkbox" label="Concordo com os termos" />
                                <Input name="amDoctor" type="checkbox" label="Sou médico" />
                                <div className="align-right">
                                    <Button variant="default" type="submit" disabled={isSubmitting}>
                                        Entrar
                                    </Button>
                                </div>
                            </div>
                        </FormContainer>
                    </Form>
                )}
            </Formik >
        </>
    );

}