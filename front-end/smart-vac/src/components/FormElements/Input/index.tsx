import { ErrorMessage, Field, FieldAttributes } from "formik";
import { InputContainer, TextAreaContainer } from "./style";

interface InputProps extends FieldAttributes<any> {
    name: string;
    label: string;
}

export function Input(props: InputProps) {
  return (
    <InputContainer>
      <label htmlFor={props.name}>{props.label}:</label>
      <Field {...props} />
      <ErrorMessage name={props.name} component="div" className="error" />
    </InputContainer>
  );
}

export function TextArea(props: InputProps) {
  return (
    <TextAreaContainer>
      <label htmlFor={props.name}>{props.label}:</label>
      <Field {...props} />
      <ErrorMessage name={props.name} component="div" className="error" />
    </TextAreaContainer>
  );
}