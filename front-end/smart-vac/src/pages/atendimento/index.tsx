import { useSession } from "next-auth/react";

export default function Home() {
  const { data: session, status } = useSession();
  console.log(status, session);
    return (
      <>
      <h1>Nosso Sistema</h1>
      <p>
      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla a fermentum nulla. Sed sed eros a mi porttitor hendrerit sed a leo. Suspendisse eleifend purus ac rutrum rhoncus. Integer tincidunt libero vitae aliquet viverra. Morbi et neque nulla. Cras ullamcorper, libero congue iaculis luctus, lectus tortor commodo odio, et eleifend ante magna id mi. Maecenas lacinia fringilla orci vitae finibus. Phasellus tincidunt nec lectus quis volutpat.
      </p>
      </>
    )
  }
  