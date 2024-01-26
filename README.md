
# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:


![diagrama](https://github.com/Tarcilalves/DesafioTrilhaNetPoo/assets/107896645/cd66f542-7b63-4b0f-879c-40ad3e45cf29)




## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.


# Implementação do Desafio Trilha .NET

Este é um exemplo simples de uma solução em C# que demonstra conceitos de orientação a objetos para modelar diferentes smartphones. A solução inclui classes abstratas, herança e polimorfismo para representar smartphones de diferentes marcas.

## Estrutura do Projeto

O projeto está organizado da seguinte maneira:

- **DesafioTrilhaNetPoo:** O projeto principal que contém a lógica do programa.
  - **Models:**
    - `Smartphone.cs`: A classe abstrata base que define propriedades e métodos comuns a todos os smartphones.
    - `Nokia.cs`: Uma classe que herda de `Smartphone` e implementa o método `InstalarAplicativo` para a loja da Nokia.
    - `Iphone.cs`: Uma classe que herda de `Smartphone` e implementa o método `InstalarAplicativo` para a App Store do iPhone.
  - **Program.cs:** A classe de entrada (`Main`) que demonstra como usar as classes definidas.

## Como Executar o Programa

Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

1. Abra o terminal e navegue até o diretório do projeto.
2. Execute `dotnet build` para compilar o projeto.
3. Execute `dotnet run` para executar o programa.

## Exemplo de Uso no Programa Principal

```csharp
using System;
using DesafioTrilhaNetPoo.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "IMEI987", memoria: 36);
nokia.Ligar();
nokia.InstalarAplicativo("Nokia");
nokia.ReceberLigacao("Nokia");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "iPhone X", imei: "IMEI123", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("iPhone");
iphone.ReceberLigacao("Iphome");

```
<br><br>
![ProgramDesafioTrilha](https://github.com/Tarcilalves/DesafioTrilhaNetPoo/assets/107896645/1a1b9755-927a-425c-ae41-b0d645b26414)








<br><br>
# Material de Apoio

### ChatGPT

Para obter suporte usando ChatGPT ou discutir ideias, visite o ChatGPT:

[ChatGPT](https://www.chatbot.com/chatgpt)


## Contribuição

Saiba como contribuir para este projeto [LinkedIn](https://www.linkedin.com/in/tarcilacardosoalves/)

