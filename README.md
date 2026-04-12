# Gerenciador de Gastos Pessoais 

![CI do Gerenciador de Gastos](https://github.com/peagaTheGOat/Gerenciador-Gastos-BootcampII/actions/workflows/main.yml/badge.svg)

## Sobre o Projeto
Este é um sistema simples via Interface de Linha de Comando (CLI) desenvolvido para ajudar pessoas a registrarem e controlarem seus gastos do dia a dia de forma rápida e objetiva.

**Qual problema estou tentando resolver?**
A falta de controle financeiro diário. Muitas pessoas perdem a noção de para onde o dinheiro está indo por causa dos "pequenos gastos" diários.

**Quem é afetado por esse problema?**
Jovens adultos, estudantes universitários e trabalhadores que precisam de uma ferramenta rápida.

**Como a aplicação ajuda?**
Através de um terminal simples, o usuário pode adicionar uma despesa em segundos, listar os gastos já feitos no dia e visualizar o total acumulado.

## Funcionalidades Principais
* **Adicionar Gasto:** Registra a descrição e o valor de uma despesa.
* **Listar Gastos:** Exibe o histórico de gastos com data, descrição e valor formatado.
* **Ver Total:** Calcula e exibe a soma de todas as despesas registradas.

## Tecnologias Utilizadas
* **Linguagem:** C# (.NET 8.0)
* **Testes:** xUnit
* **CI/CD:** GitHub Actions (Build e Testes automatizados (Linting recém adicionado))

## Estrutura do Projeto

```text
Gerenciador-Gastos-BootcampII/        <-- Você está aqui =)
├── .github/
│   └── workflows/
│       └── main.yml                  # Pipeline de CI
├── src/
│   └── GerenciadorGastos.ConsoleApp/
│       ├── GerenciadorGastos.ConsoleApp.csproj  # Manifesto de dependências e versão
│       ├── Program.cs                # Ponto de entrada (CLI)
│       ├── Gerenciador.cs            # Lógica principal e regras
│       └── Gasto.cs                  # Modelo de dados
├── Tests/
│   ├── GerenciadorGastos.Tests.csproj # Configuração do projeto de testes
│   └── GerenciadorTestes.cs          # Testes unitários (xUnit)
└── README.md                         # Documentação principal
```

## Como Instalar e Executar

**Pré-requisitos:** Ter o [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado na máquina.

## Clone este repositório:
   ```bash
   git clone [https://github.com/peagaTheGOat/Gerenciador-Gastos-BootcampII.git](https://github.com/peagaTheGOat/Gerenciador-Gastos-BootcampII.git)
