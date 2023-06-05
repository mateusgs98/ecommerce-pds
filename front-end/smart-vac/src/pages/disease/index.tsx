import { Formik } from "formik";
import { useRouter } from "next/router";
import { Input } from "@/components/FormElements/Input";
import { FaPlus } from "react-icons/fa";
import {
  Button,
  Card,
  Col,
  Container,
  Row,
  Stack,
  Table
} from "react-bootstrap";
import { ButtonContent } from "./styles";

const vaccines = [
  {id: 1, name: 'Covid', pathogen: 'Coronavírus', vaccine: 'Coronavac, Pfizer, Jansen'},
  {id: 2, name: 'Hepatite A', pathogen: 'Vírus VHA', vaccine: 'Havrix, Vaqta'},
  {id: 3, name: 'Tuberculose', pathogen: 'Inativada', vaccine: 'BCG'},
]

export default function Disease() {
  const { push } = useRouter();

  const initialValues = {
    name: '',
    pathogen: '',
};

  return (
    <>
      <h1>Listagem de Doenças</h1>
      <Card
        border="dark"
        style={{ maxWidth: '1082px' }}
      >
        <Card.Body style={{ paddingInline: '2rem' }}>
          <Formik
            initialValues={initialValues}
            onSubmit={() => {}}
          >
            <Container fluid>
              <Row>
                <Col xs={5}>
                  <Input name="name" label="Nome" />
                </Col>
                <Col xs={5}>
                  <Input name="pathogen" label="Patógeno" />
                </Col>
              </Row>
              <Row>
                <Col xs={{ offset: 11 }}>
                  <Button variant="default" size='lg' type="submit">
                    Buscar
                  </Button>
                </Col>
              </Row>
            </Container>
          </Formik>
        </Card.Body>
      </Card>
      <Button
        className="mt-2"
        variant="default"
        size='lg'
        onClick={() => push('/disease/new')}
      >
        <ButtonContent>
          <FaPlus />
          Nova doença
        </ButtonContent>
      </Button>
      <Table striped className="mt-5">
        <thead>
          <tr>
            <th>#</th>
            <th>Nome</th>
            <th>Patógeno</th>
            <th>Vacinas</th>
            <th> </th>
          </tr>
        </thead>
        <tbody>
          {
            vaccines.map(({id, name, pathogen, vaccine}) => (
                <tr key={id}>
                <td>{id}</td>
                <td>{name}</td>
                <td>{pathogen}</td>
                <td>{vaccine}</td>
                <td>
                  <Stack direction="horizontal" gap={2}>
                    <Button>Editar</Button>
                    <Button variant="danger">Excluir</Button>
                  </Stack>
                </td>
              </tr>
            ))
          }
        </tbody>
      </Table>
    </>
  )
}
