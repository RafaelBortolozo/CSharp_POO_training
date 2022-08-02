# Curso POO com C# e .NET

## SDK Version
```
.NET Core 3.1.421
```

## Comandos
Cria uma pasta como novo projeto
```
dotnet new console -o <NomeProjeto>
```

Cria uma pasta e especifica qual sdk usar (use "dotnet new console -h" para mais informações, usei o sdk 3.1.421)
```
dotnet new console -o <NomeProjeto> -f netcoreapp3.1
```


Lista e instala todas as dependencias
```
dotnet restore
```


Inicia compilação
```
dotnet build
```


Limpa arquivos de cache
```
dotnet clean
```


Roda aplicação localmente
```
dotnet run   
```


Roda aplicação emum determinado ambiente de execução
```
dotnet run --environment=<Ambiente>
```


Cria arquivo .gitignore para postagem no github
```
dotnet new gitignore
```

Listar sdks instaladas
```
dotnet --list-sdks
```


## Curiosidades do POO com C#
 - Classe é um molde para o objeto. Objeto é um conjunto de dados.
 - Classe é um reference type, ou seja, trabalha-se com endereços de memoria, como acontece em arrays. Struct é a estrutura de um dado, um value type, como um int, float, string...
 - Objeto é composto por propriedades, métodos e eventos.
 - Encapsulamento: Jogar para uma classe o que realmente deve estar lá.
 - Abstração: Esconder o que não precisa ser visualizado, exemplo acionar interruptor. A grande vantagem é a facilidade em refatorar código, quanto mais abstrato, mais facil de arrumar.
 - Herança foca em reaproveitar atributos de uma classe para outra classe. Ex: pagamento, dependendo do pagamento é possível reaproveitar todos os atributos de uma classe e complementar com aquilo que realmente precisa para o correto funcionamento da classe. Em C# é usado o ":". Classe "PagamentoComBoleto" herda(:) as caracteristicas da classe "Pagamento".
 - Instância é o ato de converter a classe para um objeto.
 - O modificador "virtual" permite com que um atributo seja sobrescrito, comando inserido na classe pai.
 - O modificador "override" permite com que um atributo seja sobrescrito, comando inserido na classe filho. Dessa forma é possível substituir um método pra executar uma função diferente usando o mesmo nome do atributo. Ex: Pagar(), pagamento com boleto funciona de uma forma totalmente diferente do cartão.
 - Todas as classes herdam os atributos do System, como o ToString(). Se fizer um override em ToString(), o método system será substituido por aquele que voce definiu na classe.
 - 