# Projeto: Princípios SOLID em C#

Este projeto demonstra os 5 princípios SOLID utilizando a linguagem C#. Para cada princípio, há um exemplo de **violação** e um exemplo de **solução** adequada que segue o princípio corretamente.

---

## Estrutura do Projeto


---

## Princípios SOLID

### 1. SRP - Single Responsibility Principle (Princípio da Responsabilidade Única)
- Uma classe deve ter apenas uma razão para mudar.
- **Violação:** Uma classe realiza múltiplas responsabilidades (ex: validação e persistência).
- **Solução:** Separar cada responsabilidade em uma classe específica.

### 2. OCP - Open/Closed Principle (Princípio Aberto/Fechado)
- Classes devem estar abertas para extensão, mas fechadas para modificação.
- **Violação:** Lógica condicional para tratar diferentes casos.
- **Solução:** Utilizar abstrações (interfaces ou herança) para permitir extensão sem alterar código existente.

### 3. LSP - Liskov Substitution Principle
- Subtipos devem ser substituíveis por seus tipos base.
- **Violação:** Subclasse quebra o comportamento esperado da classe base.
- **Solução:** Utilizar hierarquias corretas ou interfaces específicas.

### 4. ISP - Interface Segregation Principle
- Uma classe não deve ser forçada a implementar métodos que não usa.
- **Violação:** Interface com métodos genéricos e desnecessários para algumas implementações.
- **Solução:** Interfaces mais específicas (ex: `IAquecedor`, `IRefrigerador`, etc).

### 5. DIP - Dependency Inversion Principle
- Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.
- **Violação:** Dependência direta em classes concretas.
- **Solução:** Usar interfaces e injeção de dependência.

---

## Como Executar

- Abra o projeto no Visual Studio ou Visual Studio Code.
- Os métodos são ilustrativos (com comentários), focando no entendimento dos princípios SOLID.
- Não é necessário compilar ou rodar o projeto para entender os exemplos.

---

## Autor

Desenvolvido para fins educacionais como desafio de boas práticas de programação com C#.
