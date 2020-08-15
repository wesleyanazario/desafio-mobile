Desafio Vitreo (Marvel)

App para busca de personagens Marvel.
Conta com uma splashscreen feita em XAML, contendo uma imagem de fundo, e o logo da Marvel,
com efeito de animação.
Conta tambem com mais 2 Paginas em XAML
 - A primeira disponibiliza a pagina de Filtro do Personagem, onde o usuario pode visualizar uma lista com
os personagens retornados de uma pesquisa, podendo visualizar suas fotos e seus nbomes, 
alem de poder efetuar uma pesquisa, utilizando 3 ou mais
caracteres do nome dos personagens, com o submit do imput feito automaticamente, quando o filtro obtem mais que
3 caracteres, o parametro de pesquisa do filtro e salvo no BD no aparelho assim que o input for confirmado.
 - A segunda tela e aberta após o usuario clicar em um dos personagens da tela de filtro. Esta tela disponibiliza
algumas informações do personagem pesquisado, Sua foto em escala maior, seu nome, sua historia e uma lista de HQ's
referente ao personagem.


App feito em Xamarin.forms, 
	- Dependencias SQlite 
		- sqlite-net-pcl
		- SQLiteNetExtensions

	- Dependencias JSON
		- Newtonsoft
	
	- API - MARVEL
		- https://developer.marvel.com/docs

Wesley Ferreira Anazario
