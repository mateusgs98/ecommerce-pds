import { Input } from "@/components/FormElements/Input";
import { FormContainer } from "@/components/Forms/FormLogin/styles";
import { Form, Formik, FormikHelpers } from "formik";
import { Button } from "react-bootstrap";
import * as Yup from 'yup';

interface FormRegisterProps {
    onSubmit: (data: object, formik: FormikHelpers<any>) => void;
}

export default function FormRegister(props: FormRegisterProps) {
    const initialValues = {
        Nome: '',
        Email: '',
        Senha: '',
        ConfirmarSenha: '',
        DataNascimento: '',
        terms: false,
        Paciente: true
    };

    const validationSchema = Yup.object().shape({
        Email: Yup.string().email('Digite um e-mail válido').required('Campo obrigatório'),
        Senha: Yup.string().required('Campo obrigatório'),
        ConfirmarSenha: Yup.string().oneOf([Yup.ref('Senha'), undefined], 'As senhas devem ser iguais').required('Campo obrigatório'),
        Nome: Yup.string().required('Campo obrigatório'),
        DataNascimento: Yup.string().required('Campo obrigatório'),
        terms: Yup.boolean().oneOf([true], 'Você deve aceitar os termos para continuar').required('Campo obrigatório'),
        Paciente: Yup.boolean().required('Campo obrigatório'),
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
                                <Input name="Nome" label="Nome Completo" />
                                <Input name="Email" label="E-mail" />
                                <Input name="DataNascimento" type="date" label="Data de Nascimento" />
                            </div>
                            <div className="custom-row">
                                <Input name="Senha" type="password" label="Senha" />
                                <Input name="ConfirmarSenha" type="password" label="Confirmar Senha" />
                            </div>
                            <div className="custom-row">
                                <Input name="terms" type="checkbox" label="Concordo com os termos" />
                                <Input name="Paciente" type="checkbox" label="Sou paciente" />
                            </div>
                            <div className="align-right">
                                <Button variant="default" type="submit" disabled={isSubmitting}>
                                    Criar Conta
                                </Button>
                            </div>
                        </FormContainer>
                    </Form>
                )}
            </Formik >
        </>
    );

}