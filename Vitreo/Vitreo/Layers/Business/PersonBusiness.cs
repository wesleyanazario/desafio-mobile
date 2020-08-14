using System;
using System.Collections.Generic;
using System.Text;

//Classe de Business que trata as regras de negocio relacionadas ao personagem
namespace Vitreo.Layers.Business
{
    public class PersonBusiness
    {
        //Metodo para validacao da quantidade de caracteres do filtro
        //E retorna os dados dos personagens relacionados ao filtro
        //Fazendo a conexao entre a ViewModel e a classe de Servico
        public Model.CharacterDataWrapper GetPersonList(String _filter)
        {
            Model.CharacterDataWrapper characterDataWrapper = new Model.CharacterDataWrapper();

            if (_filter.Length >= 3)
            {
                Service.PersonService personService = new Service.PersonService();
                characterDataWrapper = ReorgImageisDescription(personService.GetPersonList(_filter));

            }

            return characterDataWrapper;
        }

        //Metodo para criaçao da lista de imagens retornadas pelo Service [API]
        //E verificacao da descricao dos persogens
        public Model.CharacterDataWrapper ReorgImageisDescription(Model.CharacterDataWrapper characterDataWrapper)
        {
            foreach (Model.Result result in characterDataWrapper.data.results)
            {

                result.Thumbnail.portrait_small = result.Thumbnail.Path + "/" + "portrait_small" + "." + result.Thumbnail.Extension;
                result.Thumbnail.portrait_medium = result.Thumbnail.Path + "/" + "portrait_medium" + "." + result.Thumbnail.Extension;
                result.Thumbnail.portrait_xlarge = result.Thumbnail.Path + "/" + "portrait_xlarge" + "." + result.Thumbnail.Extension;
                result.Thumbnail.portrait_fantastic = result.Thumbnail.Path + "/" + "portrait_fantastic" + "." + result.Thumbnail.Extension;
                result.Thumbnail.portrait_uncanny = result.Thumbnail.Path + "/" + "portrait_uncanny" + "." + result.Thumbnail.Extension;
                result.Thumbnail.portrait_incredible = result.Thumbnail.Path + "/" + "portrait_incredible" + "." + result.Thumbnail.Extension;

                if (String.IsNullOrEmpty(result.Description))
                {
                    result.Description = "Not Description";
                }
            }

            return characterDataWrapper;
        }

    }
}
