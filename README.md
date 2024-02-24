<br />
<br />
<div align="center">
    <a href="https://github.com/D3W10/Elemential">
        <img src="https://raw.githubusercontent.com/D3W10/Elemential/master/logo.png" alt="Logo" width="60" height="60">
    </a>
    <br />
    <br />
    <h2 align="center">Elemential</h2>
    <h3 align="center">Torna-te um mestre elementar!</h3>
    <br />
    <p align="center">
        <a href="https://github.com/D3W10/Elemential/releases">Transferir aplicação</a>
        ·
        <a href="https://github.com/D3W10/Elemential/issues">Reportar um Bug</a>
        ·
        <a href="https://github.com/D3W10/Elemential/issues">Sugerir uma Funcionalidade</a>
    </p>
</div>
<br />

### Tabela de Conteúdos
1. [Sobre](#sobre)
    - [Feito Com](#feito-com)
2. [Primeiros passos](#primeiros-passos)
    - [Requisitos de sistema](#requisitos-de-sistema)
    - [Instalação](#instalação)
3. [Descrição do Jogo](#descrição-do-jogo)
    - [Composição do Baralho](#composição-do-baralho)
4. [Desenvolvimento](#desenvolvimento)
    - [Pré-requisitos](#pré-requisitos)
    - [Instalação](#instalação-1)
5. [Licença](#licença)
6. [Créditos](#créditos)

<br />
<br />

## Sobre

Elemential é um jogo *desktop* para 2 jogadores em que o objetivo é ser o primeiro jogador a ficar sem cartas. O jogo consiste em um baralho com cartas de 3 elementos (fogo, água e gelo) em que cada elemento vence outro numa cadeia círcular. Existem também 4 tipos de cartas especiais que alteram os resultados do jogo.

> ℹ️ **Information**: Uma versão melhorada está disponível (em inglês): [CosmoChamp](https://github.com/D3W10/CosmoChamp)

<br />

### Feito Com

- [C#](https://learn.microsoft.com/dotnet/csharp/)
- [.NET Core](https://dotnet.microsoft.com/)

<br />
<br />

## Primeiros passos

Para começar a usar jogar o jogo, dirija-se à [página de download](https://github.com/D3W10/Elemential/releases) e transfira a versão mais recente.

<br />

### Requisitos de sistema

Para executar o jogo é preciso:

- Um computar que executa Windows:
    - Windows 7 or superior;
- Ter o .NET 7 instalado.

<br />

### Instalação

Depois de transferir o jogo da [página de download](https://github.com/D3W10/Elemential/releases), execute-o e pode começar a jogar. Elemential é uma aplicação *portable*, ou seja pode ser guardado numa unidade portátil (como uma pen USB) e ser usado em qualquer máquina windows.

<br />
<br />

## Descrição do Jogo

Este jogo consiste num duelo de cartas elementares. Existem 7 elementos sendo 3 deles os elementos básicos, são eles o Fogo, a Água e Gelo.

No inicio de cada partida é distribuido aleatoriamente para cada jogador 7 cartas. Em cada ronda, ambos os jogadores devem jogar uma das suas cartas sabendo que: uma do elemento Fogo vence uma do elemento Gelo, uma do elemento Gelo vence uma do elemento Água, uma do elemento Gelo vence uma do elemento Água. Se ambas forem do mesmo elemento, ganha a carta com maior valor.

Após terem sido jogadas, o jogo dá a oportunidade de mudar o resultado mostrando o deck de cartas especiais. Existem 4 elementos especiais: Energia que diminui o valor da carta adversária em 2 valores, Vento que inverte o sentido dos elementos básicos, Natureza que adiciona duas novas cartas ao deck oponente e Sparkle que dá a vitória da ronda a quem a jogar.

Depois de jogadas todas as cartas, quem não venceu a ronda recebe mais uma carta, passando assim à próxima ronda, repetindo até que um dos jogadores acabe o seu deck.

<br />

### Composição do Baralho

- 7x2 Cartas de elementos básicos + 1 carta de valor 10
- 3x3 Cartas de elementos especiais
- 2 Cartas Sparkle
- 56 Cartas no Total

<br />
<br />

## Desenvolvimento

Caso queira compilar uma cópia do Elemential no seu dispositivo para desenvolver uma funcionalidade ou corrigir um *bug*, siga os passos abaixo para começar.

<br />

### Pré-requisitos

Para executar o jogo, vai precisar das seguintes ferramentas:
- Visual Studio 2022
- C# 11.0
- .NET Core 7
- git (*opcional*)

<br />

### Instalação

1. *Clone* o repositório
    ```sh
    git clone https://github.com/D3W10/Elemential.git
    ```
2. Abra a solução do projeto (ficheiro `.sln`) usando o Visual Studio
3. Compile e execute pressionando `F5`

<br />
<br />

## Licença

Distribuído sobre a Mozilla Public License 2.0. Veja `LICENSE` para mais detalhes.

<br />
<br />

## Créditos

- Feito por [Daniel Nunes](https://d3w10.netlify.app/)
