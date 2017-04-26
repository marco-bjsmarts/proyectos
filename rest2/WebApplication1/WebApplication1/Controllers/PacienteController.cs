using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication1.Controllers
{
    public class PacienteController : ApiController
    {
        // GET: Paciente
        public ActionResult Index()
        {
            return null;
        }

        // GET: Paciente/Details/5
        public ActionResult Details(int id)
        {
            return null;
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            return null;
        }

        // POST: Paciente/Create
        [System.Web.Mvc.HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return null;
            }
            catch
            {
                return null;
                // return View();
            }
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            return null;
        }

        // POST: Paciente/Edit/5
        [System.Web.Mvc.HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return null;
            }
            catch
            {
                return null;
            }
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            return null;
        }

        // POST: Paciente/Delete/5
        [System.Web.Mvc.HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
