using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductsController:BaseAPiController
    {
        [HttpGet]
        public string GetProducts()
        {
            return "all products";
        }
        [HttpGet]
        [Route("{id}")]
        public string GetProduct(int id)
        {
            return "Product with id";
        }
        
    }
}