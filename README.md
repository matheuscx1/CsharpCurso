# 💻 Introdução ao C#

Este é um guia prático e direto para entender os fundamentos da linguagem **C#**. Aqui você vai encontrar a estrutura básica, sintaxe, tipos de variáveis, estruturas de controle, funções e conceitos de programação orientada a objetos.

Ideal para quem está começando ou quer revisar os conceitos principais de maneira organizada e simples.

---

## 📌 O que é C#?

C# (pronuncia-se "C Sharp") é uma linguagem de programação moderna, orientada a objetos, criada pela Microsoft.  
É usada para desenvolver aplicações de desktop, web, mobile, jogos (com Unity), APIs, automações e muito mais.  
Faz parte do ecossistema .NET.

---

## 📐 Estrutura Básica de um Programa

Todo programa C# precisa ter ao menos uma classe com um método `Main`, que é o ponto de entrada da aplicação.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");
    }
}
