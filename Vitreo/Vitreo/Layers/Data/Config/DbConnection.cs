using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

//Classe para criação do BD [SQlite]
namespace Vitreo.Layers.Data.Config
{
    public class DbConnection : IDisposable
    {
        public SQLite.SQLiteConnection Connection { get; }

        public DbConnection()
        {
            var config = DependencyService.Get<IDBConfig>();
            var caminhoArquivoBanco = Path.Combine(config.Path, "vitreo.db");
            Connection = new SQLite.SQLiteConnection(caminhoArquivoBanco);
        }

        public void Dispose()
        {
            if(Connection != null)
            {
                //Liberar Conexão
                Connection.Dispose();
            }
        } 
    }
}
