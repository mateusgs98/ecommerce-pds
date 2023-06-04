import { Formik } from "formik";
import { Input, TextArea } from "@/components/FormElements/Input";
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

const pathogenArr = [
  { value: 1, label: 'Coronavírus'},
  { value: 2, label: 'Vírus VHA'},
  { value: 3, label: 'Inativada'},
]

export default function New() {
  const { back } = useRouter();

  const initialValues = {
    name: '',
    pathogen: '',
    date: dayjs(),
    description: '',
    symptoms: '',
};

  return (
    <>
      <h1>Cadastro de Doença</h1>
      <Formik
        initialValues={initialValues}
        onSubmit={(values) => {console.log('values', values)}}
      >
        {
          ({handleSubmit}) => (
            <Container fluid className="d-grid gap-2">
              <Row>
                <Col>
                  <Input name="name" label="Nome" />
                </Col>
                <Col>
                  <Select
                    name="pathogen"
                    label="Patógeno"
                    options={pathogenArr}
                  />
                </Col>
                <Col>
                  <DatePicker name="date" label="Data de Identificação" />
                </Col>
              </Row>
              <Row>
                <Col>
                  <TextArea name="description" label="Descrição" />
                </Col>
              </Row>
              <Row>
                <Col>
                  <TextArea name="symptoms" label="Sintomas" />
                </Col>
              </Row>
              <Row>
                <Col className="d-flex flex-row-reverse gap-2">
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
