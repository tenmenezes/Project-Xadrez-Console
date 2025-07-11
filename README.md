# ♟️ Projeto Xadrez Console

> ⚠️ Projeto em desenvolvimento — atualizações frequentes.

Este é um projeto em C# que simula um jogo de xadrez no console. O objetivo é praticar lógica de programação orientada a objetos, estruturação de código e boas práticas de C#.

---

## 📌 Funcionalidades

- Representação visual do tabuleiro de xadrez no console
- Classes para todas as peças (Rei, Dama, Torre, Bispo, Cavalo, Peão)
- Movimentação das peças com validação completa das regras oficiais
- Controle de turno, captura de peças e xeque/xeque-mate
- Jogadas especiais: roque, promoção de peão e en passant
- Sistema de entrada e saída de dados pelo terminal
- Tratamento de erros e validação de jogadas inválidas

---

## 🧠 Conceitos aplicados

- Programação Orientada a Objetos (POO)
- Encapsulamento, abstração, herança e polimorfismo
- Manipulação de arrays e coleções (`HashSet`)
- Estruturação modular e separação de responsabilidades
- Tratamento de exceções

---

## 📁 Estrutura do Projeto

```
Project-Xadrez/
├── Program.cs
├── Tela.cs
├── tabuleiro/
|   ├── Cor.cs
|   ├── Peca.cs
|   ├── Posicao.cs
|   ├── Tabuleiro.cs
|   └── TabuleiroException.cs
├── xadrez/
|   ├── PartidaDeXadrez.cs
|   ├── PosicaoXadrez.cs
|   ├── Rei.cs
|   ├── Dama.cs
|   ├── Torre.cs
|   ├── Bispo.cs
|   ├── Cavalo.cs
|   └── Peao.cs
└── README.md
```

---

## 🚀 Como executar

1. Clone o repositório:
```
 git clone https://github.com/tenmenezes/Project-Xadrez-Console.git
```
2. Abra a solução `Project-Xadrez.sln` no Visual Studio (ou o diretório no VS Code com extensão C#)

3. Compile e execute o projeto

---

## ✅ Requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download) instalado
- Visual Studio 2022 ou VS Code com extensão C#
- Terminal/IDE com suporte à execução de projetos C#

---

## 🧑‍💻 Autor

- [@tenmenezes](https://github.com/tenmenezes)

---

## 📄 Licença

Este projeto está sob a Licença MIT. Veja o arquivo [LICENSE.txt](LICENSE.txt) para mais detalhes.
