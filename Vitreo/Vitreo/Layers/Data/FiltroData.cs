using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Classe que trata as requisições ao bd [SQlite]
namespace Vitreo.Layers.Data
{
    public class FiltroData
    {
        //Criação de instancia de conexão ao SQlite
        private Config.DbConnection _dbConnection;

        //Inicia as instancias do [Sqlite]
        public FiltroData()
        {
            _dbConnection = new Config.DbConnection();
            _dbConnection.Connection.CreateTable<Model.Filtro>();
        }

        //Get do filtro [SQlite]
        public Model.Filtro GetFiltro()
        {
            return _dbConnection.Connection.Table<Model.Filtro>().FirstOrDefault();
        }
        //Get do filtro [SQlite]
        public Model.Filtro GetFiltro(int id)
        {
            return _dbConnection.Connection.Table<Model.Filtro>().FirstOrDefault();
        }
        //Atualiza o filtro [SQlite]
        public void Update(Model.Filtro _filtro)
        {
            _dbConnection.Connection.Update(_filtro);
        }

        //Incere o filtro [SQlite]
        public void Insert(Model.Filtro _filtro)
        {
            _dbConnection.Connection.Insert(_filtro);
        }

    }
}
