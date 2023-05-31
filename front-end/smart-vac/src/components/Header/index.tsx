import { Button, Dropdown } from "react-bootstrap";
import { HeaderStyle } from "./style";
import { ReactNode } from "react";
import { signOut, useSession } from "next-auth/react";
import { FaHome, FaNotesMedical, FaStethoscope, FaSyringe, FaVirus } from "react-icons/fa";

export default function Header() {
  const { data: session, status } = useSession();

  const handleLogout = async () => {
    await signOut();
  };

  function getButton(): ReactNode {
    if (status !== "authenticated") {
      return (
        <Button variant="default" href="/login">Entrar</Button>
      );
    }
    return (getMenu());
  }

  function getMenu(): ReactNode {
    return (
      <Dropdown>
        <Dropdown.Toggle variant="default">
          Menu
        </Dropdown.Toggle>
        <Dropdown.Menu>
          <Dropdown.Item href="/dashboard"><FaHome /> Dashboard</Dropdown.Item>
          {getItemsByTypeUser()}
          <Dropdown.Item style={{ color: "red" }} onClick={handleLogout}>Sair</Dropdown.Item>
        </Dropdown.Menu>
      </Dropdown>
    );
  }

  function getItemsByTypeUser(): ReactNode {
    if (((session?.user) as User | null)?.amDoctor) {
      return (
        <>
          <Dropdown.Item href="/atendimento"><FaStethoscope /> Atendimento</Dropdown.Item>
          <Dropdown.Item href="/vacinas"><FaSyringe /> Listagem de Vacinas</Dropdown.Item>
          <Dropdown.Item href="/doencas"><FaVirus /> Listagem de Doenças</Dropdown.Item>
        </>
      );
    }
    return (
      <>
        <Dropdown.Item href="/esquema-vacinal"><FaNotesMedical /> Esquema Vacinal</Dropdown.Item>
      </>
    );
  }

  return (
    <HeaderStyle>
      {getButton()}
    </HeaderStyle>
  )
}
