import { ErrorMessage, Field, FieldAttributes, FieldInputProps } from "formik";
import { InputContainer } from "./style";

interface InputProps extends FieldAttributes<any> {
    name: string;
}

export function Input(props: InputProps) {

    return (
        <InputContainer>
        <label htmlFor={props.name}>E-mail:</label>
        <Field {...props} />
        <ErrorMessage name={props.name} component="div" className="error" />
      </InputContainer>
    );

}