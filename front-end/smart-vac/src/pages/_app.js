import Head from "next/head";
import "bootstrap/dist/css/bootstrap.min.css";
import "../../styles/globals.css";
import Header from '../components/Header/index';
import { Footer } from '../components/Footer/style';
import { Content } from '../components/Content/style';

function App({ Component, pageProps }) {
  const extraPages = ['login', 'register'];

  function getPage() {
    if (extraPages.includes(Component.name.toLowerCase())) {
      return (
        <Component {...pageProps} />
      );
    }
    return (
      <>
        <Head>
          <title>SmartVac</title>
          <link rel="icon" href="/favicon.ico" />
        </Head>

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
      {getPage()}
    </>
  );
}

export default App;
