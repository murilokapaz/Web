﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTeste.Models;
using WebTeste.Models.ViewModels;
using WebTeste.Services;

namespace WebTeste.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            ViewData["NamePage"] = "Sellers";
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel {Departments= departments };
            return View(viewModel);
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();//instancia uma resposta default
            }
            var obj = _sellerService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sellers seller)
        {
            _sellerService.Insert(seller);//executa o insert
            return RedirectToAction(nameof(Index));//após a ação, é redirecionado para o index a página
        }
    }
}