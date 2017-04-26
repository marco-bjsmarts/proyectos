using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using WClient.classMethod;
using WClient.models;

namespace WClient.Site
{
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get method
            string serviceBaseUrl = "http://localhost:62540";
            string resourceUrl = "/api/getTest";
            string method = "GET";
            string jsonText = null;
            var requestWebApi = new CRequestApi().UseHttpWebApproach(serviceBaseUrl, resourceUrl, method, jsonText);
            //    if (requestWebApi.Contains("Success"))
            //    {
            //        n++;
            //        Console.WriteLine(n);
            //    }
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            List<Persona> model = JsonConvert.DeserializeObject<List<Persona>>(requestWebApi);
            var collection = serializer.Deserialize<List<Persona>>(requestWebApi);
            grdPersonas.DataSource = model;
            grdPersonas.DataBind();
        }
    }
}