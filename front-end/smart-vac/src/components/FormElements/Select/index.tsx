import { ComponentType } from "react";
import { ErrorMessage, Field, FieldAttributes, FieldProps } from "formik";
import { Form } from "react-bootstrap";
import { SelectContainer } from "./style";

interface SelectProps extends FieldAttributes<any> {
  name: string;
  label: string;
  options: Array<{ value: string | number, label: string; }>
}

const SelectComponent: ComponentType<FieldProps['field'] & SelectProps> = ({options, ...props}) => (
  <Form.Select {...props}>
    {options.map(({ value, label }) => (
      <option key={value} value={value}>{label}</option>
    ))}
  </Form.Select>
)

export function Select(props: SelectProps) {

  return (
    <SelectContainer>
      <label htmlFor={props.name}>{props.label}:</label>
      <Field as={SelectComponent} {...props} />
      <ErrorMessage name={props.name} component="div" className="error" />
    </SelectContainer>
  );

}