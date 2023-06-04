import { styled } from "@mui/material";
import { DatePicker } from '@mui/x-date-pickers/DatePicker';


export const DatePickerContainer = styled('div')`
  display: flex;
  flex-direction: column;

  label {
    font-size: 16px;
    margin-bottom: 20px;
  }
`;

export const MUIDatePickerStyled = styled(DatePicker)`
  & .MuiOutlinedInput-root {
    height: 60px;
    border-radius: 20px;
  }

  && .MuiOutlinedInput-notchedOutline {
    border-width: 3px;
    border-color: #E6E5EA;
  }
`;