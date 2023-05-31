import { api } from "@/Lib/api";
import { CheckboxContainer, DashboardContainer } from "@/helpers/pages/dashboard/style";
import { useSession } from "next-auth/react";
import { useEffect, useState } from "react";
import BootstrapTable from 'react-bootstrap-table-next';

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

export default function Home() {
  const { data: session } = useSession();
  const [data, setData] = useState<TabelaVacinas[]>([]);

  useEffect(() => {
    fetchData();
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
    setData(data.map((register: Vacina) => ({
      ...register,
      doencasEvitadas: (<div dangerouslySetInnerHTML={{ __html: register.doencasEvitadas.join('<br />') }} />),
      actions: (
        <CheckboxContainer>
          {register.doses.map((dose: Dose) => (
            <div className='custom-checkbox'>
              <label htmlFor={dose.numeroDose.toString()}>{dose.numeroDose}ª</label>
              <input type="checkbox" id={dose.numeroDose.toString()} checked={dose.tomou} />
            </div>))}
        </CheckboxContainer>
      )
    })));
  }

  return (
    <DashboardContainer>
      <div>
        <h1>Olá, {session?.user?.name}</h1>
        <p>
          Aqui você pode monitorar as vacinas recomendadas para você e marcar as doses já tomadas.
        </p>
      </div>
      <div>
        <BootstrapTable keyField='vacina' data={data} columns={columnsTable} striped />
      </div>

    </DashboardContainer>
  )
}
