import Head from "next/head";
import "bootstrap/dist/css/bootstrap.min.css";
import "../../styles/globals.css";
import Header from '../components/Header/index';
import { Footer } from '../components/Footer/style';
import { Content } from '../components/Content/style';
import { SessionProvider } from "next-auth/react"
import { getSession } from 'next-auth/react';

const extraPages = ['login', 'register'];

function App({ Component, pageProps }) {

  function getPage() {
    if (extraPages.includes(Component.name.toLowerCase())) {
      return (
        <Component {...pageProps} />
      );
    }
    return (
      <>
        <Header />
        <Content>
          <Component {...pageProps} />
        </Content>
        <Footer />
      </>
    );
  }

  return (
    <>
      <Head>
        <title>SmartVac</title>
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <SessionProvider session={pageProps.session}>
        {getPage()}
      </SessionProvider>
    </>
  );
}

App.getInitialProps = async ({ Component, ctx }) => {
  const session = await getSession(ctx);

  let pageProps = {};

  if (Component.getInitialProps) {
    pageProps = await Component.getInitialProps(ctx);
  }

  if (session) {
    pageProps.session = session;
  }

  if(!session && !extraPages.includes(Component.name.toLowerCase())) {
    ctx.res.writeHead(302, { Location: '/login' });
    ctx.res.end();
  }

  return { pageProps };
};

export default App;
