import styled from "styled-components";

export const HeaderLogin = styled.div`
background-color: #3D405B;
    width: 100%;
    height: 100px;
    position: relative;
    display: flex;
    z-index: -1;
`;

export const Container = styled.div<{width?: string}>`
    width: 90%;
    max-width: ${props => props.width ? props.width : '560px'};
    margin: auto;
    padding: 20px;
    margin-bottom: 20px;
    margin-top: -3rem;
    background: #FFFFFF;
    border: 1px solid #000000;
    box-shadow: 5px 0px 30px rgba(0, 0, 0, 0.4);
    border-radius: 20px;
`;