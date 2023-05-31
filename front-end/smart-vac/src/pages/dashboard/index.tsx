import { Input } from "@/components/FormElements/Input";
import { DashboardContainer } from "@/helpers/pages/dashboard/style";
import { useSession } from "next-auth/react";
import { useEffect, useState } from "react";
import BootstrapTable from 'react-bootstrap-table-next';

interface Vacinas {
  id: number;
  Vacina: string;
  DoencasEvitadas: string;
  PeriodoEntreDoses: number;
  Doses: Doses[];
}

interface Doses {
  NumeroDose: number;
  Tomou: boolean;
}

const columnsTable = [
  { dataField: 'id', text: 'ID' },
  { dataField: 'Vacina', text: 'Vacina' },
  { dataField: 'DoencasEvitadas', text: 'Doencas Evitadas' },
  { dataField: '', text: 'Período Entre Doses (Dias)' },
  { dataField: 'actions', text: 'Doses' },
];

export default function Home() {
  const { data: session } = useSession();
  const [data, setData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  async function fetchData() {
    const response = await fetch('http://localhost:3000/api/vacinas');
    const data = await response.json();
    setData(data.map((register: Vacinas) => ({
      ...register,
      actions: register.Doses.map((dose: Doses) => (
        <>
          <Input name={dose.NumeroDose.toString()} label={`${dose.NumeroDose}ª`} type="checkbox" id={dose.NumeroDose} />
        </>
      ))
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
        <BootstrapTable keyField='id' data={data} columns={columnsTable} />
      </div>

    </DashboardContainer>
  )
}
