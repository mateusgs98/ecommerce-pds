import styled from "styled-components";

export const DashboardContainer = styled.div`
    display: flex;
    flex-direction: column;
    gap: 80px;

    .align-right {
        display: flex;
        justify-content: flex-end;
        margin: 0 !important;
    }
`

export const CheckboxContainer = styled.div`
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    gap: 20px;
    align-items: center;

    .custom-checkbox {
        display: flex;
        flex-direction: column;
        gap: 20px;
        align-items: center;
        input {
            width: 20px;
            height: 20px;
        }
    }
`