# Respostas

**Qual a função da pasta Pages?**

**R:** A função da pasta Pages é armazenar cada página da aplicação. Nesta pasta ficam os arquivos .cshtml responsáveis por montar a estrutura html da página, que podem estar vinculados com um arquivo .cshtml.cs, que contém a lógica da página.

Dentro da pasta Pages também temos a pasta Shared, que contém “componentes” compartilhados entre as páginas, como, por exemplo, o arquivo _Layout.cshtml, onde podemos definir um layout padrão que será seguido por outras páginas.


**O que faz o arquivo Program.cs?**


**R:** O arquivo Program.cs é o ponto de entrada da aplicação, e é nele que é inicializado o servidor web e os serviços necessários para o funcionamento da aplicação.

**Onde são configurados os serviços da aplicação?**

**R:** O arquivo Properties/launchSettings.json contém a configuração da inicialização da aplicação, e do ambiente de desenvolvimento, porém os serviços da aplicação são de fato instanciados e configurados no arquivo Program.cs


**Como é feito o roteamento de URLs?**

**R:** O roteamento é feito de forma automatica e funciona de forma muito semelhante a uma página web estática.

As rotas são criadas a partir do nome do arquivo, e da sua organização em pastas, dessa forma um arquivo /Pages/Products.cshtml vai ser acesado pela url /Products, e um arquivo /Pages/Products/Details.cshtml vai ser acesado pela url /Products/Details


Outro ponto importante, é que quando o arquivo se chama index.cshtml, ele pode ser omitido, logo o arquivo chamado /Pages/Admin/Index.cshtml pode ser acesado pela url /Admin.


Também é possível  personalizar uma rota usando o atributo [Route] ou a diretiva @page.
