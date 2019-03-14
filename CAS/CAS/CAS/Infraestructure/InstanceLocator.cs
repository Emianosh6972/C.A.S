namespace CAS.Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewModels;
    class InstanceLocator
    {
        #region Propiedades
        public MainViewModel Main { get; set; }
        #endregion

        #region Contructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
