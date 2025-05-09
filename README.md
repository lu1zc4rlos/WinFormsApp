# WinFormsApp

Sistema de Cadastro de Usuários com envio de E-mail — desenvolvido em C# com Windows Forms.

## Objetivo do Projeto

Este projeto tem como objetivo demonstrar a implementação de um sistema simples de cadastro de usuários utilizando a arquitetura em *três camadas: Interface (UI), Lógica de Negócio (BLL) e Acesso a Dados (DAL), com integração ao **banco de dados MySQL* e *envio automático de e-mail* após o cadastro.

## Funcionalidades

- Cadastro de usuários com validações
- Verificação de e-mail já existente
- Envio de e-mail de boas-vindas ao concluir o cadastro
- Login de usuário com autenticação no banco
- Interface intuitiva em Windows Forms
- Integração com banco de dados MySQL

## Tecnologias Utilizadas

- *C#* (Windows Forms)
- *MySQL* (banco de dados)
- *.NET Framework*
- *SmtpClient* (envio de e-mails)
- *GIT* (controle de versão)

## Estrutura do Projeto

- WinFormsApp.UI: Interface com o usuário (formulários e eventos)
- WinFormsApp.BLL: Lógica de negócios e validações
- WinFormsApp.DAL: Conexão com o banco e acesso aos dados
- WinFormsApp.Models: Entidades e objetos de transferência

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/lu1zc4rlos/WinFormsApp
