# LojaEsportes_WebApp: Um Aplicativo Real (Atualizado para .NET 8.0)

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-8.0-green)

Este repositório contém o projeto **LojaEsportes_WebApp**, um aplicativo de e-commerce, baseado no capítulo 7 do livro *Pro ASP.NET Core 6* de Adam Freeman, desenvolvido com .NET 8.0.

## 🔄 Atualizações do Projeto

**Este projeto foi atualizado para .NET 8.0**, incorporando as últimas melhorias do framework enquanto mantém toda a funcionalidade original descrita no livro.

Principais mudanças:
- Migração completa de .NET 6 para **.NET 8.0**
- Atualização de todos os pacotes NuGet para versões compatíveis
- Aproveitamento das otimizações de desempenho do .NET 8

## 📖 Sobre o Projeto

O **LojaEsportes_WebApp** é um aplicativo web realista que implementa os principais recursos de uma loja online:

- 📋 Catálogo de produtos com navegação por categoria e paginação
- 🛒 Carrinho de compras para adicionar/remover produtos
- 💳 Página de checkout para detalhes de envio
- 🔒 Área administrativa com funcionalidades CRUD
- 🧪 Testes unitários para componentes-chave

## 🛠️ Tecnologias Utilizadas

- **ASP.NET 8+** - Framework web principal
- **Entity Framework Core** - ORM para acesso a dados
- **SQL Server LocalDB** - Banco de dados local
- **Bootstrap** - Estilização da interface

## 🏗️ Estrutura do Projeto

O projeto está organizado seguindo as melhores práticas do ASP.NET Core:

```
SportsStore/
├── Controllers/       # Controladores MVC
├── Models/            # Modelos de domínio e view models
├── Views/             # Views Razor
├── Data/              # Configuração do EF Core e repositórios
├── Migrations/        # Migrações do banco de dados
├── wwwroot/           # Arquivos estáticos
└── Tests/             # Projeto de testes unitários
```

## 🚀 Funcionalidades Implementadas

✔️ Infraestrutura central do aplicativo  
✔️ Modelo de domínio com repositório de produtos  
✔️ Acesso ao SQL Server via Entity Framework Core  
✔️ Controlador Home com listagem paginada de produtos  
✔️ Esquema de URL limpo e amigável  

## 📌 Próximos Passos (Conforme o Livro)

- Adicionar navegação por categoria
- Implementar carrinho de compras
- Desenvolver o processo de checkout
- Criar área administrativa protegida

## 📄 Licença

Este projeto é baseado no material do livro *Pro ASP.NET Core 6* de Adam Freeman, publicado pela APress Media, LLC. O código é destinado para fins educacionais e de demonstração.

© The Author(s), under exclusive license to APress Media, LLC, part of Springer Nature 2022

## 🤝 Como Contribuir

Contribuições não são esperadas, pois este é um projeto de estudo que acompanha o livro mencionado. No entanto, sugestões são sempre bem-vindas!

---

*"Neste capítulo, eu construí a infraestrutura central para o aplicativo SportsStore. [...] Agora que a estrutura fundamental está pronta, podemos seguir em frente e adicionar todos os recursos voltados para o cliente."* - Adam Freeman

---
