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
  {id: 1, name: 'BCG', type: 'Atenuada', treat: 'Tuberculose'},
  {id: 2, name: 'Coronavac', type: 'Vírus inativado', treat: 'Covid'},
  {id: 3, name: 'Havrix e Vaqta', type: 'Inativada', treat: 'Hepatite A'},
]

export default function Vaccine() {
  const { push } = useRouter();

  const initialValues = {
    name: '',
    diseases: '',
};

  return (
    <>
      <h1>Listagem de Vacinas</h1>
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
                  <Input name="diseases" label="Doenças Evitadas" />
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
        onClick={() => push('/vaccine/new')}
      >
        <ButtonContent>
          <FaPlus />
          Nova vacina
        </ButtonContent>
      </Button>
      <Table striped className="mt-5">
        <thead>
          <tr>
            <th>#</th>
            <th>Nome</th>
            <th>Tipo Imunização</th>
            <th>Doenças Evitadas</th>
            <th> </th>
          </tr>
        </thead>
        <tbody>
          {
            vaccines.map(({id, name, type, treat}) => (
              <tr key={id}>
                <td>{id}</td>
                <td>{name}</td>
                <td>{type}</td>
                <td>{treat}</td>
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
