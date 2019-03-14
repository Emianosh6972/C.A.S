namespace CAS.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Services;
    using Models;
    using Xamarin.Forms;

    public class DashboardViewModel : BaseViewModel
    {
        #region Servicios
        private ApiService apiService;
        #endregion

        #region Atributos 
        private ObservableCollection<API_Resources> dash;
        #endregion

        #region Propiedades
        public ObservableCollection<API_Resources> Dash
        {
            get { return this.dash; }
            set { this.SetValue(ref this.dash, value); }
        }
        #endregion
        
        #region Contructores
        public DashboardViewModel()
        {
            this.apiService = new ApiService();
            this.LoadMenu();
        }
        #endregion

        #region Metodos
        private async void LoadMenu()
        {
            var response = await this.apiService.Post<Dash>("https://control.airam.com.mx/api/");

            if (response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                return;
            }

            var list = (List<API_Resources>)response.Result;
            this.Dash = new ObservableCollection<API_Resources>(list);

        }
        #endregion
    }
}