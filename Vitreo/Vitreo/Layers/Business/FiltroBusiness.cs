using System;
using System.Collections.Generic;
using System.Text;

//Classe de Business que trata as regras de negocio relacionadas ao Filtro
namespace Vitreo.Layers.Business
{
    public class FiltroBusiness
    {
        //Instancia para acesso ao BD [SQlite]
        private Data.FiltroData _filtroData;

        public FiltroBusiness()
        {
            _filtroData = new Data.FiltroData();
        }

        //Metodo que trata o retorno dos dados gravados no bd [SQlite]
        //Trata a conexão entre ViewModel e [Sqlite]
        public Model.Filtro GetFiltro()
        {
            Model.Filtro _filtroPesquisa = new Model.Filtro();

            if (_filtroData.GetFiltro() != null)
            {
                return _filtroData.GetFiltro();
            }

            return _filtroPesquisa;
        }
        //Metodo que trata o insert ou o update no bd [SQlite]
        //Trata a conexão entre ViewModel e [Sqlite]
        public void Update(Model.Filtro _filtroPesquisa)
        {
            Model.Filtro _filtro = _filtroData.GetFiltro(_filtroPesquisa.IdFiltroPesquisa);
            if(_filtro == null)
            {
                _filtroData.Insert(_filtroPesquisa);
            }
            else
            {
                _filtroData.Update(_filtroPesquisa);
            }
           
        }

    }
}
