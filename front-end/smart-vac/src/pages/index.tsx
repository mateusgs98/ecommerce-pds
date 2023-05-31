
export default function Home() {
  return (
    <>
      <h1>Nosso Sistema</h1>
      <p>
        O sistema SmartVac é um sistema de gerenciamento de vacinas, que tem como objetivo
        gerenciar o estoque de vacinas de uma unidade de saúde, além de sugerir esquemas
        vacinais de acordo com as doenças e o paciente.
      </p>
      <p>
        O sistema foi desenvolvido para ser utilizado por profissionais de saúde, como
        enfermeiros e médicos, e por pacientes.
      </p>
      <ul>
        <li>
          Os Profissionais de Saúde podem:
          <ul>
            <li>Cadastrar/Visualizar Vacinas</li>
            <li>Cadastrar/Visualizar Pacientes</li>
            <li>Realizar Atendimentos</li>
          </ul>
        </li>
        <li>
          Os Pacientes podem:
          <ul>
            <li>Visualizar seus esquemas vacinais</li>
            <li>Registrar vacinações</li>
          </ul>
        </li>
      </ul>
    </>
  )
}
