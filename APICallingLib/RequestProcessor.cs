using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APICallingLib
{
    public static class RequestProcessor
    {
        public static async Task<ModelType> LoadData<ModelType>(BaseAPICommand command) where ModelType: new()
        {
            var url = command.GetURL();
            
            // TODO: убрать присвоение урл
            
            url = "https://nominatim.openstreetmap.org/search?q=москва ювао&format=json&polygon_geojson=1";

            using (HttpResponseMessage response = await APICaller.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ModelType mdl;

                    try
                    {
                        mdl = await response.Content.ReadAsAsync<ModelType>();
                    }
                    catch (Exception)
                    {
                        mdl = default(ModelType);
                    }

                    return mdl;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
