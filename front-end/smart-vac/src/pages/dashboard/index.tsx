import { api } from "@/Lib/api";
import Table from "@/components/Table";
import { CheckboxContainer, DashboardContainer } from "@/helpers/pages/dashboard/style";
import { useSession } from "next-auth/react";
import { useEffect, useState } from "react";
import { Button } from "react-bootstrap";
import BootstrapTable from 'react-bootstrap-table-next';
import paginationFactory from 'react-bootstrap-table2-paginator';

interface Vacina {
  vacina: string;
  doencasEvitadas: string[];
  periodoEntreDoses: number;
  doses: Dose[];
}

interface Dose {
  numeroDose: number;
  tomou: boolean;
}

interface TabelaVacinas {
  vacina: string;
  doencasEvitadas: JSX.Element;
  periodoEntreDoses: number;
  actions: JSX.Element;
}

const columnsTable = [
  { dataField: 'vacina', text: 'Vacina' },
  { dataField: 'doencasEvitadas', text: 'Doencas Evitadas' },
  { dataField: 'periodoEntreDoses', text: 'Período Entre Doses (Dias)' },
  { dataField: 'actions', text: 'Doses' },
];

export default function Dashboard() {
  const { data: session } = useSession();
  const [data, setData] = useState<TabelaVacinas[]>([]);
  const [doses, setDoses] = useState<{ vacina: string, doses: Dose[] }[]>([]);

  function onClickCheckbox(event: any, vacina: string, numeroDose: number) {
    setDoses(prevState => [
      ...prevState.filter((dose) => dose.vacina !== vacina),
      {
        vacina,
        doses: prevState.find((dose) => dose.vacina === vacina)?.doses.map((dose) => {
          if (dose.numeroDose === numeroDose) {
            return {
              numeroDose,
              tomou: event.target.checked
            }
          }
          return dose;
        }) || []
      }
    ]);
  }

  function onSubmitFunction() {
    if (doses.length === 0) {
      return;
    }
    const userId = (session?.user as User | null)?.Id || 0;
    api.put('/esquema-vacinal', { ...doses, idUsuario: userId });
  }

  useEffect(() => {
    if ((session?.user as User | null)?.Paciente) {
      fetchData();
    }
  }, []);

  async function fetchData() {
    // const response = await api.get('/esquema-vacinal');
    // const data = response.data as Vacinas[];
    const data = [
      {
        vacina: 'Vacina 1',
        doencasEvitadas: [
          'Doença 1',
          'Doença 2'
        ],
        periodoEntreDoses: 30,
        doses: [
          {
            numeroDose: 1,
            tomou: true
          },
          {
            numeroDose: 2,
            tomou: false
          },
          {
            numeroDose: 3,
            tomou: false
          }
        ]
      },
      {
        vacina: 'Vacina 2',
        doencasEvitadas: [
          'Doença 1',
          'Doença 2',
          'Doença 3'
        ],
        periodoEntreDoses: 10,
        doses: [
          {
            numeroDose: 1,
            tomou: true
          },
          {
            numeroDose: 2,
            tomou: false
          },
          {
            numeroDose: 3,
            tomou: false
          }
        ]
      },
      {
        vacina: 'Vacina 3',
        doencasEvitadas: [
          'Doença 1',
          'Doença 3',
        ],
        periodoEntreDoses: 25,
        doses: [
          {
            numeroDose: 1,
            tomou: true
          },
          {
            numeroDose: 2,
            tomou: false
          },
          {
            numeroDose: 3,
            tomou: true
          }
        ]
      }
    ] as Vacina[];

    setDoses(data.map((register: Vacina) => ({
      vacina: register.vacina,
      doses: register.doses
    })));

    setData(data.map((register: Vacina) => ({
      ...register,
      doencasEvitadas: (<div dangerouslySetInnerHTML={{ __html: register.doencasEvitadas.join('<br />') }} />),
      actions: (
        <CheckboxContainer>
          {register.doses.map((dose: Dose) => (
            <div className='custom-checkbox'>
              <label htmlFor={dose.numeroDose.toString()}>{dose.numeroDose}ª</label>
              <input type="checkbox" id={dose.numeroDose.toString()} defaultChecked={dose.tomou} onClick={(e) => onClickCheckbox(e, register.vacina, dose.numeroDose)} />
            </div>))}
        </CheckboxContainer>
      )
    })));
  }

  return (
    <DashboardContainer>
      <div>
        <h1>Olá, {(session?.user as User | null)?.Nome}</h1>
        {(session?.user as User | null)?.Paciente ? (
          <>
            <p>
              Aqui você pode monitorar as vacinas recomendadas para você e marcar as doses já tomadas.
            </p>
          </>
        ) : (
          <>
            <p>
              Seja bem vindo ao nosso sistema.
              As ações disponíveis para você estão no menu.
            </p>
          </>
        )}
      </div>
      {(session?.user as User | null)?.Paciente && (
        <>
          <div className="table">
            <Table keyField='vacina' data={data} columns={columnsTable} />
            <div className="align-right">
              <Button variant="default" onClick={() => onSubmitFunction()}>Salvar</Button>
            </div>
          </div>
        </>
      )}

    </DashboardContainer>
  )
}
