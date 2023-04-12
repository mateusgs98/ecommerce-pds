# SmartVac

## Membros e papéis:
- Lucas Silva Viana (Front-end)
- Mateus Gomes Silva (Back-end)
- Pedro Lucas Silva (Front-end)
- Wanderson Magela do Nascimento (Back-end) 

## Escopo:
A ideia é construir um sistema que sugira esquemas vacinais de acordo com dados de doenças e do paciente, a partir de fluxos de entrada de dados e atividades para concluir os processos no sistema, com possibilidade de registro de uma vacinação mediante atendimento.

## Tecnologias:
- Back-end: C#
- Front-end: NextJs

## Backlog do Produto:
- Como usuário, eu gostaria de efetuar login no sistema.
- Como usuário, gostaria de efetuar meu cadastro no sistema.
- Como profissional da saúde, eu quero visualizar doenças cadastradas.
- Como profissional da saúde, eu quero fazer o cadastro e  atualização de doenças.
- Como profissional da saúde, eu quero ter visualizar e excluir doenças cadastradas
- Como profissional da saúde, eu quero fazer o cadastro e atualização de vacinas.
- Como profissional da saúde, eu quero visualizar e excluir vacinas.
- Como profissional da saúde, eu quero fazer o cadastro e atualização de pacientes.
- Como profissional da saúde, eu quero poder fazer um atendimento a um paciente, podendo assim indicar novas vacinas que o paciente deve tomar.
- Como paciente, eu quero saber qual o melhor esquema vacinal para mim de acordo com indicações do profissional da saúde e minhas características (faixa etária, doses já recebidas de vacinas).
- Como paciente, eu quero poder marcar as vacinas indicadas a mim que eu já tomei.
- Como paciente, eu quero poder ver as vacinas indicadas para mim que ainda não tomei e estão sendo ofertadas.
- Como profissional da saúde, eu quero fazer o cadastro de datas de vacinação, juntamente com o local que está sendo ofertada.
- Como usuário, gostaria de ter uma página explicativa do sistema.
- Como paciente eu quero ter um calendário de vacina com as vacinas que eu tenho que tomar.
- Como paciente, eu quero poder fazer o download do meu comprovante de vacinação no sistema.
- Como profissional da saúde eu quero poder ter acesso aos comprovantes de vacinação dos pacientes do sistema.

## Backlog do Sprint:
- **História 1:** Como usuário, eu gostaria de efetuar login no sistema.
  - **Descrição:** Para entrar no sistema, é necessário primeiro efetuar o login. Os campos a serem preenchidos são: email e senha. Ao concluir o login, o usuário deve ser redirecionado para a página inicial da aplicação, que será diferente dependendo do tipo do usuário (médico ou paciente).
  - Tarefas e responsáveis:
    - Criar tabelas no banco de dados
    - Configurações básicas do projeto no Nextjs
    - Configurações básicas do projeto no C#
    - Criar componentes básicos da tela
    - Criar a tela de login segundo layout definido e consumindo o endpoint de login
    - Criar o endpoint para realizar o login
    - Configurar a autenticação do usuário após efetuar o login

- **História 2:** Como usuário, gostaria de efetuar meu cadastro no sistema
  - **Descrição:** Para utilizar o sistema, é necessário primeiro efetuar o cadastro do usuário. Os campos a serem preenchidos são: Nome completo, email, data de nascimento, senha, confirmar senha, checkbox para médico ou paciente, aceito os termos de uso. Após concluir o cadastro, o usuário deve ter seu login efetuado automaticamente e deve ser redirecionado para a página inicial da aplicação.
- **História 3:** Como profissional da saúde, eu quero fazer o cadastro e atualização de doenças.
  - **Descrição:** Para utilizar o sistema, é necessário efetuar o cadastro de doenças. Os campos a serem preenchidos são: nome, tipo de patógeno, data de identificação, local de identificação, descrição, sintomas. Após concluir o cadastro, o usuário deve ser redirecionado para a página de listagem de doenças.
- **História 4:** Como profissional da saúde, eu quero visualizar e excluir doenças cadastradas
  - **Descrição:** É necessário ter uma página de visualização de doenças cadastradas para que seja possível gerenciá-las. Os campos a serem exibidos em uma listagem são: nome, tipo de patógeno, data de identificação, local de identificação, descrição, sintomas. Além disso, a página deverá conter um botão que permite realizar a exclusão de doenças de forma individual. Deve haver também uma seção de filtro, contendo os campos Nome e Patógeno.
- **História 5:** Como profissional da saúde, eu quero fazer o cadastro e atualização de vacinas.
  - **Descrição:** É necessário ter uma página para cadastro de doenças cadastradas. Os campos a serem exibidos em uma listagem são: nome, tipo de patógeno, data de identificação, local de identificação, descrição, sintomas. 
- **História 6:** Como profissional da saúde, eu quero visualizar e excluir vacinas.
  - **Descrição:** É necessário ter uma página de visualização de vacinas cadastradas para que seja possível gerenciá-las. Os campos a serem exibidos em uma listagem são: nome, tipo da imunização e doenças evitadas. A página também deverá conter um botão que permite realizar a edição e exclusão de vacinas de forma individual. Além disso, deverá haver uma seção de filtro de vacinas, com os campos Nome e Doenças Evitadas.
- **História 7:** Como paciente, eu quero saber qual o melhor esquema vacinal para mim de acordo com indicações do profissional da saúde e minhas características (faixa etária, doses já recebidas de vacinas).
  - **Descrição:** Após efetuar login no sistema, eu como um paciente, quero ver o esquema vacinal recomendado de acordo com minhas características e com as recomendações feitas no atendimento.
- **História 8:** Como profissional da saúde, eu quero poder fazer um atendimento a um paciente, podendo assim indicar novas vacinas que o paciente deve tomar
  - **Descrição:** Ao entrar na tela de atendimento, quero inserir os dados do paciente e obter as informações já cadastradas a partir de um de seus documentos/dados (RG, CPF, Nome), para depois buscar as vacinas novas e já administradas.
- **História 9:** Como usuário, gostaria de ter uma página explicativa do sistema.
  - **Descrição:** Antes de entrar no sistema, quero ter uma página de boas vindas que me explica sobre o que é o sistema que estou acessando e como funciona
