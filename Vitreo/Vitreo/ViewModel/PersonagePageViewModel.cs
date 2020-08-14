using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

//Classe de ViewModel para tratamento dos dados da View PersonagePage
namespace Vitreo.ViewModel
{
    public class PersonagePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public PersonagePageViewModel()
        {
            //Recuparafiltro salvo no bd [SQlite]
            Model.Filtro _filtroPesquisa = new Layers.Business.FiltroBusiness().GetFiltro();

            _filtro = _filtroPesquisa.FiltroPesquisa;
            //Verifica se contem dados
            if (String.IsNullOrEmpty(_filtro))
            {
                //Apenas na promeira execucao, quando nao existir dados no bd [SQlite]
                _results = new Layers.Business.PersonBusiness().GetPersonList("man").data.results;

            }
            else
            {
                //Recupera o ultimo filtro do usuario armazenada no bd [SQlite]
                _results = new Layers.Business.PersonBusiness().GetPersonList(_filtro).data.results;
            }

            SlectResultsCommand = new Command(() =>
            {
                //Envia uma mensagem a view para mudanca da tela
                //Envia um OBJETO Result, com os dados selecionados pelo USUARIO
                MessagingCenter.Send<Model.Result>(_selectResult, "ResultDetail");
            });

        }

        private IList<Model.Result> _results;
        public IList<Model.Result> Results
        {
            get
            {
                return _results;
            }
            set
            {
                _results = value;
                NotifyPropertyChanged();
            }
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

        private String _filtro;
        public String Filtro
        {
            get
            {
                return _filtro;
            }
            set
            {
                _filtro = value;
                _getDados();
                NotifyPropertyChanged();
            }
        }
        

        private void _getDados()
        {
            //Retorna a lista de personagens
            var x = new Layers.Business.PersonBusiness().GetPersonList(_filtro);
            //Verifica se a pesquisa foi bem sucedida 
            if (x.Code != 0)
            {
                //Armazena o filtro no BD atraves da classe Business
                new Layers.Business.FiltroBusiness().Update(new Model.Filtro(_filtro));
                //Armazena a lista na variavel ligada a View
                Results = x.data.results;
            }
        }
        //Trata o select do Usuario
        public ICommand SlectResultsCommand { get; private set; }
    }
}
