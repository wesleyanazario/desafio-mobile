using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Vitreo.Model
{
    public class Filtro : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Filtro()
        {

        }

        public Filtro(String _filtro)
        {
            this.IdFiltroPesquisa = 0;
            this.FiltroPesquisa = _filtro;
        }

        private int idFiltroPesquisa;
        [PrimaryKey]
        public int IdFiltroPesquisa
        {
            get { return idFiltroPesquisa; }
            set
            {
                if (idFiltroPesquisa != value)
                {
                    idFiltroPesquisa = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String filtroPesquisa;
        
        public String FiltroPesquisa
        {
            get { return filtroPesquisa; }
            set
            {
                if (filtroPesquisa != value)
                {
                    filtroPesquisa = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
