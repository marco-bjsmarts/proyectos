using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonasController : ApiController
    {
        // GET: Personas
       /* public ActionResult Index()
        {
            return new string[] { "value1", "value2" };
        }*/
        //GET  /api/Personas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // [System.Web.Http.HttpGet]
        // [System.Web.Http.Route("api/getTest")]

        // [WebInvoke(Method="GET",UriTemplate = "/api/getTest", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]

        [System.Web.Http.Route("api/getTest")]
        public List<Personas> GetTest()
        {
            List<Personas> lstPersonas = new List<Personas>();
            /*lstPersonas.Add(new Personas
            {
                nombre = "marco",
                apellido = "chipana",
                edad = 20
            });
            //return lstPersonas;
            //TODO: Acceder a datos en busca del artículo con Id que recibimos por filtro.
            //var serializedObject = JsonConvert.SerializeObject(lstPersonas, Formatting.Indented);
            //return serializedObject;
            */
            string strConnectionString = CParametros.strConnectionString;

            SqlConnection sqlConnection1 = new SqlConnection(strConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "getList";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            while (reader.Read())
            {
                lstPersonas.Add(new Personas
                {
                    Id = Convert.ToInt32(reader["Id"].ToString().Trim()),
                    nombre = reader["nombre"].ToString().Trim(),
                    apellido = reader["apellido"].ToString().Trim(),
                    edad = Convert.ToInt32(reader["edad"].ToString().Trim()),
                });
            }
            reader.Close();
            sqlConnection1.Close();
            
            return lstPersonas;
        }

        // POST api/values
        [System.Web.Http.HttpPost]
        public void Post(Personas value)
        {
        }
    }
}