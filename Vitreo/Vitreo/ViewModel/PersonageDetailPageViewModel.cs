using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

//Classe de ViewModel para tratamento dos dados da View PersonageDetailPage
namespace Vitreo.ViewModel
{
    public class PersonageDetailPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public PersonageDetailPageViewModel()
        {
            //Recuperando dados selecionados pelo usuario
            SlectResult = Model.Global.Result;

        }

        private Model.Result _selectResult;
        public Model.Result SlectResult
        {
            get
            {
                return _selectResult;
            }
            set
            {
                _selectResult = value;
                NotifyPropertyChanged();
            }
        }

    }
}
