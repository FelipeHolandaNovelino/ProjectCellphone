# Projeto Smartphone

Este projeto implementa uma hierarquia de classes para representar smartphones. A classe abstrata `Smartphone` fornece uma base comum para as classes Nokia e Iphone, definindo os atributos e métodos comuns a todos os smartphones. As classes derivadas Nokia e Iphone estendem a classe Smartphone, elas sobrescrevem o método `InstalarAplicativo` deacordo com sua necessidade.

## Estrutura do Projeto

O projeto é estruturado da seguinte maneira:

- **Smartphone**: A classe abstrata base que contém propriedades comuns a todos os smartphones, como número, modelo, IMEI e memória. Também inclui métodos para ligar o smartphone, receber uma ligação e instalar aplicativos.

- **Nokia**: Uma classe derivada de `Smartphone` que representa smartphones da marca Nokia. Sobrescreve o método `InstalarAplicativo` para fornecer uma implementação específica.

- **Iphone**: Outra classe derivada de `Smartphone` que representa smartphones da marca iPhone. Sobrescreve o método `InstalarAplicativo` para fornecer uma implementação específica.

- **Program**: Um programa simples que cria instâncias de `Nokia` e `Iphone` e testa seus métodos.

## Como Usar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/smartphone-project.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd smartphone-project
   ```

3. Abra o projeto em seu ambiente de desenvolvimento preferido (Visual Studio, Visual Studio Code, etc.).

4. Execute o programa para testar as classes e métodos:

   ```bash
   dotnet run
   ```

Isso deve gerar saídas no console demonstrando a criação de instâncias de `Nokia` e `Iphone` e a chamada de seus métodos.


# Smartphone Project

This project implements a class hierarchy to represent smartphones. The abstract class `Smartphone` provides a common base for the `Nokia` and `Iphone` classes, defining attributes and methods common to all smartphones. The derived classes `Nokia` and `Iphone` extend the `Smartphone` class, overriding the `InstallApplication` method according to their specific needs.

## Project Structure

The project is structured as follows:

- **Smartphone**: The abstract base class that contains properties common to all smartphones, such as number, model, IMEI, and memory. It also includes methods to turn on the smartphone, receive a call, and install applications.

- **Nokia**: A derived class from `Smartphone` representing Nokia brand smartphones. Overrides the `InstallApplication` method to provide a specific implementation.

- **Iphone**: Another derived class from `Smartphone` representing iPhones. Overrides the `InstallApplication` method to provide a specific implementation.

- **Program**: A simple program that creates instances of `Nokia` and `Iphone` and tests their methods.

## How to Use

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/smartphone-project.git
   ```

2. Navigate to the project directory:

   ```bash
   cd smartphone-project
   ```

3. Open the project in your preferred development environment (Visual Studio, Visual Studio Code, etc.).

4. Run the program to test the classes and methods:

   ```bash
   dotnet run
   ```

This should generate console outputs demonstrating the creation of instances of `Nokia` and `Iphone` and the invocation of their methods.
