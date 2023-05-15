import { Button } from "react-bootstrap";
import { HeaderStyle } from "./style";
import { ReactNode } from "react";

export default function Header() {
  function getButton(): ReactNode {
    if(true) {
      return (
        <Button variant="default" href="/login">Entrar</Button>
      );
    }
    return (
      <></>
    );
  }

  return (
    <HeaderStyle>
      {getButton()}
    </HeaderStyle>
  )
}
