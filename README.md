## OmegaTech
OmegaTech é uma aplicação de help desk desenvolvida em C# com interface gráfica (Windows Forms), que permite aos técnicos visualizar, iniciar e finalizar atendimentos de chamados abertos pelos clientes. Ideal para empresas que desejam organizar e agilizar o suporte técnico de forma eficiente.

## 🎯 Objetivo do Projeto
O OmegaTech surgiu como um projeto acadêmico, com o objetivo de solucionar, de forma prática e eficiente, o gerenciamento de chamados técnicos. A aplicação permite que técnicos visualizem os tickets abertos pelos clientes, iniciem e concluam atendimentos — tudo de forma organizada em uma interface gráfica intuitiva.

Como diferencial, o sistema conta com um chatbot integrado à API da OpenAI, além de notificações por e-mail automatizadas. Sua arquitetura em camadas (UI, BLL, DAL e Entidades) favorece a manutenção, reutilização de código e escalabilidade da aplicação.

📦 Instalação
Passos para rodar o projeto localmente:

```bash
git clone https://github.com/lu1zc4rlos/WinFormsApp
cd WinFormsApp
```
Abra o projeto no Visual Studio. Em seguida, configure a string de conexão com o banco de dados no arquivo ConexaoDAL.cs, localizado na camada DAL.
É necessário possuir uma chave da API da OpenAI. Crie uma variável de ambiente chamada OPENAI_API_KEY contendo sua chave válida.
O sistema utiliza um banco de dados PostgreSQL para armazenar dados de usuários e tickets. Certifique-se de ter o PostgreSQL instalado e crie as tabelas necessárias antes de iniciar a aplicação.

## ✅ Funcionalidades
🤖 ChatBot integrado com IA (OpenAI)

📝 Telas de cadastro, login e recuperação de senha (por senha atual ou via e-mail)

🆘 Abertura de chamados pelo usuário final

📋 Exibição de tickets abertos com informações intuitivas: código, nome do chamado, cliente, prioridade, tempo de abertura, status (aberto, em andamento, concluído) e ações disponíveis.

É possível excluir tickets com status "aberto" ou "em andamento".

Tickets "concluídos" permitem visualizar a resposta do técnico.

🔍 Filtragem de chamados por status (abertos, em andamento, concluídos), além de opção para abrir um novo chamado.

🛠️ Tela exclusiva para técnicos, com quatro botões para acessar:

Todos os tickets
Tickets abertos
Tickets em andamento
Tickets fechados

🔄 Ações contextuais nos tickets:

Quando o ticket está "aberto", o técnico pode iniciá-lo.
Quando está "em andamento", o técnico pode responder ao cliente.
Tudo isso feito diretamente no próprio ticket, com botões intuitivos.

💬 Tela para resposta ao cliente, contendo:

Dados do chamado: código, nome do cliente, prioridade, assunto, tempo de abertura, status e e-mail.
Campo para escrever a resposta.
Botão de confirmação do atendimento.

## 🚀 Tecnologias Utilizadas
C# com Windows Forms (interface gráfica)
PostgreSQL (banco de dados relacional)
.NET Framework (plataforma de desenvolvimento)
SmtpClient (envio automático de e-mails)
Git (controle de versão)
API da OpenAI (integração com ChatBot via inteligência artificial)

## 🧱 Estrutura do Projeto
O projeto está organizado seguindo uma arquitetura em 3 camadas, visando melhor separação de responsabilidades, manutenibilidade e escalabilidade.

WinFormsApp.UI
Camada de interface com o usuário, responsável pelos formulários, layout e eventos visuais da aplicação.
WinFormsApp.BLL
Camada de lógica de negócios, onde são feitas as validações, regras de processamento e orquestração entre UI e DAL.
WinFormsApp.DAL
Camada de acesso a dados, responsável pela conexão com o banco de dados e execução de comandos SQL (CRUD).
WinFormsApp.Entidades
Camada de modelos de dados (DTOs), contendo as entidades que representam os objetos do sistema (como Usuario, Ticket, etc.).
Esta camada serve como base para troca de dados entre BLL e DAL.

# 💻 Telas do Sistema

## Tela de Login
<img src="Projeto%20teste/Projeto%20teste/Imagens/Image1.png" alt="Tela de Login" width="800"/>

## Tela de Cadastro
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaDeCadastro.png" alt="Tela de Cadastro" width="800"/>

## Tela de Troca de Senha
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaTrocarDeSenha.png" alt="Tela de Troca de Senha" width="800"/>

## Telas de Troca de Senha por Código 
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaTrocarSenhaCodigo.png" alt="Telas de Troca de Senha por Código" width="800"/>
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaAlterarSenha.png" alt="Telas de Troca de Senha por Código" width="800"/>

## Tela de Home
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaHome.png" alt="Tela de Home" width="800"/>

## Tela de OmegaHelp
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaOmegaHelp.png" alt="Tela de OmegaHelp" width="800"/>

## Tela de Chamados
<img src="Projeto%20teste/Projeto%20teste/Imagens/chamados.png" alt="Tela de Chamados" width="800"/>

## Tela de Abrir Chamados
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaAbrirChamado.png" alt="Tela de Abrir Chamados" width="800"/>

## Tela Dashboard Principal Técnico
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaTecnicoChamados.png" alt="Tela Dashboard Principal Técnico" width="800"/>

## Tela de Responder Cliente
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaResponderCliente.png" alt="Tela de Responder Cliente" width="800"/>

## Tela de Resposta do Técnico
<img src="Projeto%20teste/Projeto%20teste/Imagens/TelaRespostaTecnico.png" alt="Tela de Resposta do Técnico" width="800"/>

## Workshop do Projeto OmegaTech
<img src="Projeto%20teste/Projeto%20teste/Imagens/Workshop1.png" alt="Workshop1" width="600"/>
<img src="Projeto%20teste/Projeto%20teste/Imagens/Workshop2.png" alt="Workshop2" width="600"/>
<img src="Projeto%20teste/Projeto%20teste/Imagens/workshop3.png" alt="Workshop3" width="600"/>
<img src="Projeto%20teste/Projeto%20teste/Imagens/Workshop4.png" alt="Workshop4" width="600"/>





