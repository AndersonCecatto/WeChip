using CrediOferta.Domain;
using CrediOferta.Service.Negocios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiCrediOfertas.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoServico _produtoServico;
        private readonly VendaServico _vendaServico;
        public ProdutoController()
        { 
            _produtoServico = new ProdutoServico();
            _vendaServico = new VendaServico();
        }

        [HttpGet]
        public string BuscarProdutos()
        {
            try
            {
                return JsonConvert.SerializeObject(_produtoServico.BuscarProdutos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Venda> BuscarVendas()
        {
            try
            {
                return _vendaServico.BuscarVendas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // GET: Produto
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Produto/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Produto/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Produto/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Produto/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Produto/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Produto/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Produto/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
