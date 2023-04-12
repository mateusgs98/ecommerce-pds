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
  - **Tarefas e responsáveis:**
    - Criar tabelas no banco de dados
    - Configurações básicas do projeto no Nextjs
    - Configurações básicas do projeto no C#
    - Criar componentes básicos da tela
    - Criar a tela de login segundo layout definido e consumindo o endpoint de login
    - Criar o endpoint para realizar o login
    - Configurar a autenticação do usuário após efetuar o login
- **História 2:** Como usuário, gostaria de efetuar meu cadastro no sistema
  - **Descrição:** Para utilizar o sistema, é necessário primeiro efetuar o cadastro do usuário. Os campos a serem preenchidos são: Nome completo, email, data de nascimento, senha, confirmar senha, checkbox para médico ou paciente, aceito os termos de uso. Após concluir o cadastro, o usuário deve ter seu login efetuado automaticamente e deve ser redirecionado para a página inicial da aplicação.
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de cadastro de usuário conforme definido no protótipo
    - Adicionar validação nos campos do formulário para que não sejam preenchidos incorretamente
    - Ao submeter o formulário, enviar requisição para o back-end contendo os dados preenchidos
    - No back-end, criar o endpoint responsável por receber os dados do formulário de cadastro e inserir um novo registro na tabela de usuário, além de montar o esquema vacinal de acordo com o perfil preenchido
    - Ao receber uma resposta de sucesso do back-end, efetuar o login do novo usuário e direcioná-lo para a tela inicial da aplicação
    - Ao receber uma resposta de erro do back-end, exibir uma mensagem amigável para o usuário solicitando que submeta seu cadastro novamente
- **História 3:** Como profissional da saúde, eu quero fazer o cadastro e atualização de doenças.
  - **Descrição:** Para utilizar o sistema, é necessário efetuar o cadastro de doenças. Os campos a serem preenchidos são: nome, tipo de patógeno, data de identificação, local de identificação, descrição, sintomas. Após concluir o cadastro, o usuário deve ser redirecionado para a página de listagem de doenças.
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de cadastro de doenças conforme definido no protótipo
    - Adicionar validação nos campos do formulário para que não sejam preenchidos incorretamente
    - Ao submeter o formulário, enviar requisição para o back-end contendo os dados preenchidos
    - Criar o endpoint responsável por receber os dados do formulário de cadastro e inserir um novo registro na tabela de doenças
    - Ao receber uma resposta de erro do back-end, exibir uma mensagem amigável para o usuário solicitando que tente novamente.
    - Popular o banco com os tipos patógenos.
- **História 4:** Como profissional da saúde, eu quero visualizar e excluir doenças cadastradas
  - **Descrição:** É necessário ter uma página de visualização de doenças cadastradas para que seja possível gerenciá-las. Os campos a serem exibidos em uma listagem são: nome, tipo de patógeno, data de identificação, local de identificação, descrição, sintomas. Além disso, a página deverá conter um botão que permite realizar a exclusão de doenças de forma individual. Deve haver também uma seção de filtro, contendo os campos Nome e Patógeno.
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de exibição de doenças conforme definido no protótipo
    - Criar o endpoint responsável por entregar os dados das doenças cadastradas.
    - Criar o endpoint responsável por excluir uma doença por Id.
    - Implementar a lógica responsável pelo filtro das doenças
    - Criar o layout de estado de vazio para quando não houver doenças cadastradas.
    - Ao receber uma resposta de erro do back-end, exibir uma mensagem amigável para o usuário solicitando que tente novamente.
- **História 5:** Como profissional da saúde, eu quero fazer o cadastro e atualização de vacinas.
  - **Descrição:** É necessário ter uma página para cadastro de doenças cadastradas. Os campos a serem exibidos em uma listagem são: nome, tipo de patógeno, data de identificação, local de identificação, descrição, sintomas. 
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de cadastro de vacinas conforme definido no protótipo
    - Adicionar validação nos campos do formulário para que não sejam preenchidos incorretamente
    - Ao submeter o formulário, enviar requisição para o back-end contendo os dados preenchidos
    - Criar o endpoint responsável por receber os dados do formulário de cadastro e inserir um novo registro na tabela de vacinas
    - Ao receber uma resposta de erro do back-end, exibir uma mensagem amigável para o usuário solicitando que tente novamente.
    - Popular o banco com os tipos de imunização e doenças evitadas.
- **História 6:** Como profissional da saúde, eu quero visualizar e excluir vacinas.
  - **Descrição:** É necessário ter uma página de visualização de vacinas cadastradas para que seja possível gerenciá-las. Os campos a serem exibidos em uma listagem são: nome, tipo da imunização e doenças evitadas. A página também deverá conter um botão que permite realizar a edição e exclusão de vacinas de forma individual. Além disso, deverá haver uma seção de filtro de vacinas, com os campos Nome e Doenças Evitadas.
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de exibição de vacinas conforme definido no protótipo
    - Criar o endpoint responsável por entregar os dados das vacinas cadastradas.
    - Criar o endpoint responsável por excluir uma vacina por Id.
    - Implementar a lógica de filtro de vacinas
    - Criar o layout de estado de vazio para quando não houver doenças cadastradas.
    - Ao receber uma resposta de erro do back-end, exibir uma mensagem amigável para o usuário solicitando que tente novamente.
- **História 7:** Como paciente, eu quero saber qual o melhor esquema vacinal para mim de acordo com indicações do profissional da saúde e minhas características (faixa etária, doses já recebidas de vacinas).
  - **Descrição:** Após efetuar login no sistema, eu como um paciente, quero ver o esquema vacinal recomendado de acordo com minhas características e com as recomendações feitas no atendimento.
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de exibição de doenças conforme definido no protótipo
    - Criar endpoint que liste as vacinas recomendadas para o usuário
    - Criar endpoint para marcar as vacinas que eu já tomei
    - Criar tabela com relação a relação de vacina e paciente, para guardar as vacinas já tomadas juntamente com a quantidade de doses tomadas
- **História 8:** Como profissional da saúde, eu quero poder fazer um atendimento a um paciente, podendo assim indicar novas vacinas que o paciente deve tomar
  - **Descrição:** Ao entrar na tela de atendimento, quero inserir os dados do paciente e obter as informações já cadastradas a partir de um de seus documentos/dados (RG, CPF, Nome), para depois buscar as vacinas novas e já administradas.
  - **Tarefas e responsáveis:**
    - Criar o layout da tela de cadastro de atendimento conforme definido no protótipo
- **História 9:** Como usuário, gostaria de ter uma página explicativa do sistema.
  - **Descrição:** Antes de entrar no sistema, quero ter uma página de boas vindas que me explica sobre o que é o sistema que estou acessando e como funciona
  - **Tarefas e responsáveis:**
    - Criar texto estático que aparecerá na tela
    - Criar o layout da tela de exibição de doenças conforme definido no protótipo
