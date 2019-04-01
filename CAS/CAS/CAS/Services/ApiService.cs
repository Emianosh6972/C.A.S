namespace CAS.Services
{
    using Models;
    using Newtonsoft.Json;
    using Plugin.Connectivity;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Collections.ObjectModel;
    public class ApiService
    {
        #region Conexión a Internet
        public async Task<Response> CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "No hemos detectado conexión a Internet. \n Por favor, conectate a una red WI-FI o utiiza tus Datos Moviles. " +
                              "Ten en cuenta que utilizar tus Datos Moviles puede tener costos extras por parte de tu operador.",
                };
            }

            var isReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

            if (!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Por favor, revisa tu conexión a Internet.",
                };
            }

            return new Response
            {
                IsSuccess = true,
                Message = "Bienvenido!!",
            };
        }
        #endregion

        public async Task<Response> Post<T>(string urlBase)
        {
            try
            {
                try
                {
                    var values = new Dictionary<string, string>
                    {
                        {"key", "bqEJqQW02MGo0qZg5kVa40Hh6a07WQtiWZR83B5uEqRdjuidTSKe8Mgk47kGAEJU" },
                        {"resource", "clients" },
                        {"method", "get" }
                    };

                    var content = new FormUrlEncodedContent(values);

                    var response = await new HttpClient().PostAsync(urlBase, content);
                    
                    var resultJSON = await response.Content.ReadAsStringAsync();
                    
                    if(!response.IsSuccessStatusCode)
                    {
                        return new Response
                        {
                            Message = resultJSON.ToString(),
                        };
                    }
                    
                    onTrack result = JsonConvert.DeserializeObject<onTrack>(resultJSON);

                    return new Response
                    {
                        Message = resultJSON.ToString(),
                    };

                    /*
                     if(!response.IsSuccessStatusCode || !response.Equals(200))
                    {
                        return new Response
                        {
                            IsSuccess = false,
                            Message = resultJSON,
                        };
                    } 
                     
                    var stringJson = JsonConvert.DeserializeObject<ObservableCollection<onTrack>>(resultJSON);

                    return new Response
                    {
                        IsSuccess = true,
                        Message = "Ok"
                        Result = stringJson,
                    };
                    */

                }
                catch (Exception ex_string)
                {
                    return new Response
                    {
                        Message = ex_string.Message,
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

    }
}
