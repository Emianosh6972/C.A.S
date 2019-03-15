namespace CAS.ViewModels
{
    using Models;
    using Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class DashboardViewModel : BaseViewModel
    {
        #region Servicios
        private ApiService apiService;
        #endregion

        #region Atributos 
        private ObservableCollection<onTrack> crm;
        #endregion

        #region Propiedades
        public ObservableCollection<onTrack> CRM
        {
            get { return this.crm; }
            set { this.SetValue(ref this.crm, value); }
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
            var response = await this.apiService.Post<onTrack>("https://control.airam.com.mx/api");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                return;
            }

            var api_list = (List<onTrack>)response.Result;
            this.CRM = new ObservableCollection<onTrack>(api_list);
        }
        #endregion
    }
}