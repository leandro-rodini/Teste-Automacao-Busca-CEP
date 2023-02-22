# Automação C#(NUnit e Specflow)
O presente repositório apresenta uma automação de teste desenvolvida em C#(Utilizando nUnit e SpecFlow), sobre os sites dos Correios e Rastreamentocorreios.

## Instalando Pacotes NuGets
Com o terminal aberto, tendo .Net instalado, crie um diretório para o projeto e digite os comandos a seguir:

`$ dotnet new nunit `</br>
`$ dotnet add package "SpecFlow.NUnit"`</br>
`$ dotnet add package "SpecFlow.Plus.LivingDocPlugin"`</br>
`$ dotnet add package "Selenium.WebDriver"`</br>

Feito isso, adicione os diretórios Steps, Pages e Features, contidos neste repositório.

## Executando o Teste

Para executar o teste, em seu terminal digite o comando:

`$ dotnet test`</br>

## Editando o Código

Caso queira editar o código do teste, utilize o editor de código de sua preferência. 
Recomendo utilização do Visual Studio.

# Pasta "Teste teórico e screenshot do resultado"
Este diretorio contem o arquivo "ConhecimentosQualidadeDeSoftware" com as respostas das questoes teoricas e o screenshot da execução do teste no Visual Studio com o nome "result_automation"
