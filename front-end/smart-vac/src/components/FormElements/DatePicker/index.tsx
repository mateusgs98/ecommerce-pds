import { ErrorMessage, Field, FieldAttributes, FieldProps } from "formik";
import { DatePickerContainer, MUIDatePickerStyled } from "./style";

interface DatePickerProps extends FieldAttributes<any> {
  name: string;
  label: string;
}

export function DatePicker({name, label}: DatePickerProps) {

  return (
    <DatePickerContainer>
      <label htmlFor={name}>{label}:</label>
      <Field name={name}>
        {({ field, form }: FieldProps) => (
          <MUIDatePickerStyled
            {...field}
            onChange={(value) => form.setFieldValue(field.name, value)}
          />
        )}
      </Field>
      <ErrorMessage name={name} component="div" className="error" />
    </DatePickerContainer>
  );

}