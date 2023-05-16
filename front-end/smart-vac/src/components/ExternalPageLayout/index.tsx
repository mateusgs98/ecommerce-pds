import React from 'react';
import Header from '../Header';
import { Container, HeaderLogin } from './styles';
import { Footer } from '../Footer/style';

interface ExternalPageProps {
    children: React.ReactNode;
}

export default function ExternalPageLayout({ children }: ExternalPageProps) {

    return (
        <>
            <HeaderLogin />
            <Container>
                {children}
            </Container>
            <Footer />
        </>
    );
}