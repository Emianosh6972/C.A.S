namespace CAS.ViewModels
{
    using Models;
    using Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;
    using System.Runtime;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

    public class DashboardViewModel : BaseViewModel
    {
        #region Servicios
        private ApiService apiService;
        #endregion

        #region Atributos 
        private ObservableCollection<clients> clientes;

        private bool isRefreshing;
        #endregion

        #region Propiedades
        public ObservableCollection<clients> Clientes
        {
            get { return this.clientes; }
            set { this.SetValue(ref this.clientes, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }
        #endregion
        
        #region Contructores
        public DashboardViewModel()
        {
            this.apiService = new ApiService();
            this.LoadCRM();
        }
        #endregion

        #region Metodos
        private async void LoadCRM()
        {

            //var connection = await this.apiService.CheckConnection();

            //if (!connection.IsSuccess)
            //{
            //    this.IsRefreshing = false;

            //    await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "Aceptar");

            //    await Application.Current.MainPage.Navigation.PopAsync();

            //    return;
            //}

            var response = await this.apiService.Post<OtClients>("https://control.airam.com.mx/api/");

            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                return;
            }

            //this.IsRefreshing = true;

            var api_list = (List<clients>)response.Result;

            this.Clientes = new ObservableCollection<clients>(api_list);

        }
        #endregion

        #region Comandos

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadCRM);
            }
        }

        #endregion
    }
}