# KRB-tec-jr

Ferramentas Utilizadas
Microsoft Visual Studio Community 2022
  Package utilizados
  Microsoft.EntityFrameworkCore
  Microsoft.EntityFrameworkCore.Design
  Microsoft.EntityFrameworkCore.SqlServer
  Microsoft.EntityFrameworkCore.Tools
SQL Server 2022
SQL Server Management Studio 


Para alterar conexão arquivo appsettings.json Server, Id e Password
"ConnectionStrings": {
  "DataBase": "Server=./;Database=DB_SistemaCampeonatos;User Id=;Password=;TrustServerCertificate=True"
},

Comandos para Criação do DB utilizando EntityFramework via console
Add-Migration CriandoTabelaCampeonatos -Context BancoContext
Update-DataBase -Context BancoContext

Tarefas Realizadas
8	CRUD Campeonatos
8.1	   Cadastro, alteração, listagem e exclusão de campeonatos

Tarefas Parcialmente Realizadas

Tarefas Pedentes
8	CRUD Campeonatos
8.3	   Recurso de seleção dos Destaques de Campeonatos
9	Fase dos Campeonatos
9.1	   Seleção da fase atual de cada campeonato


ÁREA PÚBLICA: SITE
1	Exibição dos Campeonatos
1.1	   Home: Listagem dos campeonatos em destaque
1.2	   Home: Listagem das 8 demais competições na home
1.3	   Listagem interna dos campeonatos
1.4	   Filtros de busca na página de listagem
1.5	   Paginação de registros
2	Íntegra dos Campeonatos
2.1	   Exibição dinâmica dos dados
2.2	   URL amigável da página de íntegra do campeonato
2.3	   Exibição do botão correto correspondente à atual fase do campeonato
3	Fase: Inscrições Abertas
3.1	   Programação do formulário de inscrição do atleta
3.2	   Validação e consistência dos campos
3.3	   Inserção de Captcha no formulário
3.4	   Envio de e-mail com os dados preenchidos no formulário de inscrição
3.5	   Bloqueios e validações necessárias para que só apareçam informações desta fase quando estiver ativa
4	Fase: Chave de Lutas
4.1	   Montagem dinâmica das chaves de lutas conforme as regras solicitadas
4.2	   Bloqueios e validações necessárias para que só apareçam informações desta fase quando estiver ativa
5	Fase: Resultados
5.1	   Exibição dinâmica dos resultados de cada campeonato
5.2	   Bloqueios e validações necessárias para que só apareçam informações desta fase quando estiver ativa
6	Área do Atleta:
6.1	   Autenticação completa da área restrita
6.2	   Recuperação de Senha
6.3	   Listagem de todos os certificados do próprio atleta
6.4	   Exibição do Certificado de participação ou de vitória
6.5	   Exportação em PDF do certificado
PAINEL ADMINISTRATIVO
7	Módulo de Autenticação
7.1	   Autenticação completa do painel administrativo
7.2	   Recuperação de senha
7.3	   CRUD Usuários
7.4	   Módulo de usuários com 2 diferentes níveis de acesso (ADMIN e User)
8	CRUD Campeonatos
8.2	   Imagem do Campeonato: Inserir recurso de cortar imagem
8.3	   Recurso de seleção dos Destaques de Campeonatos
9	Fase dos Campeonatos
9.1	   Seleção da fase atual de cada campeonato
9.2	   Programação da fase de Inscrições Abertas
9.3	   Programação da fase de Chaves de Lutas
9.4	   Programação da fase de Resultados
10	Atletas
10.1	   Inscrições: Listagem das inscrições dos atletas com os filtros solicitados e paginação
10.2	   Extração dos dados em CSV e PDF
10.3	   Opção para visualizar os certificados de cada atleta de acordo com os seu resultados nos diferentes campeonatos em que o atleta se inscreveu.
