using System;
using System.Threading.Tasks;
using ContactosModel.Model;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;

namespace Camara
{
    public class UploadFile
    {
        string url = "http://apicontactos20160121014558.azurewebsites.net/api/camera";

        public async Task<String> SubirFoto(byte[] file)
        {
            var client=new RestClient(url);

            var request=new RestRequest();
            request.Method=Method.POST;

            var d=new FotosModel() {Data = Convert.ToBase64String(file),id=33};

            request.AddJsonBody(d);

            var r=await client.Execute<string>(request);

            return r.Data;
        }

    }
}