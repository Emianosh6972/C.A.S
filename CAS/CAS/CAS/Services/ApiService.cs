namespace CAS.Services
{
    using Models;
    using Newtonsoft.Json;
    using Plugin.Connectivity;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

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
                /*
                string key = "";
                string resource = "";
                string method = "";
                object data = null;
                */
                var values = new Dictionary<string, string>
                {
                    {"key", "bqEJqQW02MGo0qZg5kVa40Hh6a07WQtiWZR83B5uEqRdjuidTSKe8Mgk47kGAEJU" },
                    {"resource", "clients" },
                    {"method", "get" }
                };

                var content = new FormUrlEncodedContent(values);

                var response = await new HttpClient().PostAsync(urlBase, content);

                var respString = await response.Content.ReadAsStringAsync();

                if(!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = respString,
                    }; 
                }
                var datos = JsonConvert.DeserializeObject<List<T>>(respString);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Ok",
                    Result = respString,
                };
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



    /*
    #region Validación de Token "Login"
    public async Task<TokenResponse> GetToken(string urlBase, string username, string password)
    {
        try
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(urlBase);

            var response = await client.PostAsync
            (
                "Token",
                new StringContent
                (
                    string.Format("grant_type=password&username={0}&password={1}", username, password),
                    Encoding.UTF8, "application/x-www-form-urlencoded"
                )
            );

            var resultJSON = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<TokenResponse>(resultJSON);

            return result;
        }
        catch
        {
            return null;
        }
    }



    #endregion

    #region Obtener un solo objeto
    public async Task<Response> Get<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, int id)
    {
        try
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}/{2}", servicePrefix, controller, id);

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = false,

                    Message = response.StatusCode.ToString(),
                };
            }

            var result = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<T>(result);

            return new Response
            {
                IsSuccess = true,
                Message = "Ok",
                Result = model,
            };
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
    #endregion

    #region Obtener todos los objetos
    public async Task<Response> GetList<T>(string urlBase, string servicePrefix, string controller)
    {
        try
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}", servicePrefix, controller);

            var response = await client.GetAsync(url);

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = result,
                };
            }

            var list = JsonConvert.DeserializeObject<List<T>>(result);

            return new Response
            {
                IsSuccess = true,
                Message = "Ok",
                Result = list,
            };
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

    public async Task<Response> GetList<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken)
    {
        try
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}", servicePrefix, controller);

            var response = await client.GetAsync(url);

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = result,
                };
            }

            var list = JsonConvert.DeserializeObject<List<T>>(result);

            return new Response
            {
                IsSuccess = true,
                Message = "Ok",
                Result = list,
            };
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

    public async Task<Response> GetList<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, int id)
    {
        try
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}/{2}", servicePrefix, controller, id);

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = response.StatusCode.ToString(),
                };
            }

            var result = await response.Content.ReadAsStringAsync();

            var list = JsonConvert.DeserializeObject<List<T>>(result);
            return new Response
            {
                IsSuccess = true,
                Message = "Ok",
                Result = list,
            };
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
    #endregion

    #region Ingresar objetos
    public async Task<Response> Post<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, T model)
    {
        try
        {
            var request = JsonConvert.SerializeObject(model);

            var content = new StringContent(request, Encoding.UTF8, "application/json");

            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}", servicePrefix, controller);

            var response = await client.PostAsync(url, content);

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<Response>(result);

                error.IsSuccess = false;

                return error;
            }

            var newRecord = JsonConvert.DeserializeObject<T>(result);

            return new Response
            {
                IsSuccess = true,
                Message = "Record added OK",
                Result = newRecord,
            };
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

    public async Task<Response> Post<T>(string urlBase, string servicePrefix, string controller, T model)
    {
        try
        {
            var request = JsonConvert.SerializeObject(model);

            var content = new StringContent(request, Encoding.UTF8, "application/json");

            var client = new HttpClient();

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}", servicePrefix, controller);

            var response = await client.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = response.StatusCode.ToString(),
                };
            }

            var result = await response.Content.ReadAsStringAsync();

            var newRecord = JsonConvert.DeserializeObject<T>(result);

            return new Response
            {
                IsSuccess = true,
                Message = "Record added OK",
                Result = newRecord,
            };
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
    #endregion

    #region Modificar objetos
    public async Task<Response> Put<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, T model)
    {
        try
        {
            var request = JsonConvert.SerializeObject(model);

            var content = new StringContent(request, Encoding.UTF8, "application/json");

            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

            client.BaseAddress = new Uri(urlBase);

            var url = string.Format("{0}{1}/{2}", servicePrefix, controller, model.GetHashCode());

            var response = await client.PutAsync(url, content);

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<Response>(result);
                error.IsSuccess = false;
                return error;
            }

            var newRecord = JsonConvert.DeserializeObject<T>(result);

            return new Response
            {
                IsSuccess = true,
                Result = newRecord,
            };
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
    #endregion

    #region Eliminar objetos
    public async Task<Response> Delete<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, T model)
    {
        try
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(urlBase);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

            var url = string.Format("{0}{1}/{2}", servicePrefix, controller, model.GetHashCode());

            var response = await client.DeleteAsync(url);

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<Response>(result);
                error.IsSuccess = false;
                return error;
            }

            return new Response
            {
                IsSuccess = true,
            };
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
    #endregion
    */
    }
}

