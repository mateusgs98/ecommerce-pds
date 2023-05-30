import styled from "styled-components";

export const InputContainer = styled.div`
    color: #3D405B;

    input {
        padding: 0 5px;
        width: 100%;
        height: 60px;
        background: #FDFDFD;
        border: 3px solid #E6E5EA;
        border-radius: 20px;
        font-size: 16px;
    }

    input[type="checkbox"] {
        width: 30px;
        height: 30px;
        background: #FDFDFD;
        border: 3px solid #E6E5EA;
    }

    label {
        font-size: 16px;
        width: 100%;
        margin-bottom: 20px;
    }

    .error {
        color: #FF0000;
        font-size: 14px;
    }
`