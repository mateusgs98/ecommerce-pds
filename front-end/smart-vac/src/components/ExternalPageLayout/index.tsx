import React from 'react';
import Header from '../Header';
import { Container, HeaderLogin } from './styles';
import { Footer } from '../Footer/style';

interface ExternalPageProps {
    children: React.ReactNode;
    width?: string;
}

export default function ExternalPageLayout({ children, width }: ExternalPageProps) {

    return (
        <>
            <HeaderLogin />
            <Container width={width}>
                {children}
            </Container>
            <Footer />
        </>
    );
}