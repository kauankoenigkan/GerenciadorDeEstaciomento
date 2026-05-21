## Sistema Gerenciador de Estaciomento

![C#](https://img.shields.io/badge/Language-C%23-purple?style=flat-square)
![.NET](https://img.shields.io/badge/Framework-.NET%2010.0-blueviolet?style=flat-square)

## 🚀 Tecnologias e Ferramentas
  - **Linguagem Principal:** `C#`
  - **Persistência/Drivers:** `.NET 10.0`
  - **IDE Recomendada:** `Visual Studio 2026 Community Edition`

## 📌 Funcionalidades
  - **Cadastrar Veículo:** Entrada de novos veículos no sistema com verificação de vaga ocupada para evitar duplicidade de placas.
  - **Listar Veículos:** Exibição em tempo real de todos os automóveis atualmente estacionados no pátio.
  - **Remover Veículo & Faturamento:** Baixa no veículo informando o tempo de permanência, realizando o cálculo automatizado do valor total devido (Preço Inicial + Preço por Hora * hora).

## ⚡ Diferenciais Técnicos (Boas Práticas)
  - **Validação de Redundância:** Implementação de checagem prévia com `Contains()` para impedir o cadastro duplicado da mesma placa no sistema.
  - **Padronização de Dados:** Uso de tratamento de strings com `.ToUpper()` para garantir a integridade das buscas, tornando o sistema imune a erros de digitação entre letras maiúsculas e minúsculas.
  - **Formatação Monetária Dinâmica:** Processamento de regras de negócio para cálculo de permanência tarifada (`Preço Inicial + Preço por Hora`) com renderização padrão de moedas (`decimal`).
  - **Clean Code & UX no Console:** Métodos com responsabilidade única bem definidos e controle de fluxo do menu interativo que evita o fechamento precoce do terminal, melhorando a experiência do usuário.

## ▶️ Como Executar

  ### Pré-requisitos (Visual Studio é opcional)
    - [.NET SDK](https://dotnet.microsoft.com/download) instalado.
    - [Visual Studio](https://visualstudio.microsoft.com) instalado.

  ### Passo a Passo
  ```bash
    # 1. UMA SOLUÇÃO:

    # 1.1. Clone o projeto
    $ git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
  
    # 1.2. Acesse a pasta
    $ cd seu-repositorio
  
    # 1.3. Execute a aplicação
    $ dotnet run

  # 2. OUTRA SOLUÇÃO:

  # 2.1. Baixe o projeto:** Clique no botão verde 'Code' (no topo desta página) e selecione 'Download ZIP' (ou clone o repositório).

  # 2.2. Abra o arquivo do projeto: Extraia os arquivos e dê um duplo clique no arquivo `.sln` ou `.csproj`. Isso abrirá o projeto direto no Visual Studio.

  # 2.3. Execute a aplicação: Com o projeto aberto, basta pressionar a tecla 'F5' (ou clicar no botão verde de "Play/Iniciar" no topo do Visual Studio) para rodar o sistema de estacionamento.
  ```

## 👨‍💻 Autor

Desenvolvido por Kauan Koenigkan.
