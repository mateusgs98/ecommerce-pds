import styled from "styled-components";

export const FormContainer = styled.div`
    display: flex;
    flex-direction: column;
    gap: 60px;
    margin: 20px 15px;

    h2 {
        margin: 0;
    }

    .extra {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        align-items: center;
        width: 100%;
        margin: 0 auto;
        margin-bottom: 3rem;
    }

    button {
        width: 40%;
        padding: 10px 0rem;
    }
`;