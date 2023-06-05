import { Formik } from "formik";
import { Input } from "@/components/FormElements/Input";
import dayjs from 'dayjs'
import {
  Button,
  Col,
  Container,
  Row,
} from "react-bootstrap";
import { useRouter } from "next/router";
import { Select } from "@/components/FormElements/Select";
import { DatePicker } from "@/components/FormElements/DatePicker";

const immunizationTypes = [
  { value: 1, label: 'Atenuada'},
  { value: 2, label: 'Vírus Inativado'},
  { value: 3, label: 'Inativada'},
]

export default function New() {
  const { back } = useRouter();

  const initialValues = {
    name: '',
    manufacturer: '',
    type: '',
    "avoid-diseases": '',
    "manufacturing-date": dayjs(),
    "approve-date": dayjs(),
    "required-doses": '',
    "time-between-doses": '',
    efficiency: '',
    "age-group": '',
    contraindications: '',
};

  return (
    <>
      <h1>Cadastro de Vacina</h1>
      <Formik
        initialValues={initialValues}
        onSubmit={(values) => {console.log('values', values)}}
      >
        {
          ({handleSubmit}) => (
            <Container fluid>
              <Row>
                <Col>
                  <Input name="name" label="Nome" />
                </Col>
                <Col>
                  <Input name="manufacturer" label="Fabricante" />
                </Col>
                <Col>
                  <Select
                    name="type"
                    label="Tipo de Imunização"
                    options={immunizationTypes}
                  />
                </Col>
              </Row>
              <Row>
                <Col>
                  <Input name="avoid-diseases" label="Doença Evitada" />
                </Col>
                <Col>
                  <DatePicker name="manufacturing-date" label="Data Fabricação" />
                </Col>
                <Col>
                  <DatePicker name="approve-date" label="Data Aprovação de Uso" />
                </Col>
              </Row>
              <Row>
                <Col>
                  <Input name="required-doses" label="Doses Necessárias" />
                </Col>
                <Col>
                  <Input name="time-between-doses" label="Período entre Doses (dias)" />
                </Col>
                <Col>
                  <Input name="efficiency" label="Eficácia Comprovada" />
                </Col>
              </Row>
              <Row>
                <Col xs={4}>
                  <Input name="age-group" label="Faixa(s) Etária(s) Indicadas" />
                </Col>
                <Col xs={4}>
                  <Input name="contraindications" label="Contraindicações" />
                </Col>
              </Row>
              <Row>
                <Col xs={{ offset: 10 }} className="d-flex flex-row row-gap-2">
                  <Button variant="default" size='lg' onClick={() => handleSubmit()}>
                    Cadastrar
                  </Button>
                  <Button variant="secondary" size='lg' onClick={back}>
                    Cancelar
                  </Button>
                </Col>
              </Row>
            </Container>
          )
        }
      </Formik> 
    </>
  )
}
