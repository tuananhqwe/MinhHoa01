﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhHoa01.Models;
namespace MinhHoa01.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Minh hoạ 1: tiếp nhận tham số thông qua Request (truyền thống)
        //public IActionResult XuLy() {

        //    //b1.lấy giá trị các tham số (So1, So2, PhepTinh)
        //    var x = double.Parse(Request.Form["So1"]);
        //    var y = double.Parse(Request.Form["So2"]);
        //    var op = Request.Form["PhepTinh"];
        //    //b2. tinh toan ket qua 
        //    double ketqua=0;
        //    switch (op)
        //    {
        //        case "+": ketqua = x + y; break;
        //        case "-": ketqua = x - y; break;
        //        case "*": ketqua = x * y; break;
        //        case "/": ketqua = x / y; break;
        //    }
        //    //b3.Tra ket qua ve nguoi dung
        //    ViewData["KQ"] = ketqua; //truyền dữ liệu cho view thông qua ViewData
        //    ViewBag.KQ = ketqua; //truyền dữ liệu cho view thông qua ViewBag
        //    return View();
        //}

        //Minh hoạ 2: tiếp nhận tham số thông qua đối số của action
        //public IActionResult xuly(double So1, double So2, string PhepTinh)
        //{
        //    //b1.lấy giá trị các tham số (So1, So2, PhepTinh)
        //    //b2. tinh toan ket qua 
        //    double ketqua = 0;
        //    switch (PhepTinh)
        //    {
        //        case "+": ketqua = So1 + So2; break;
        //        case "-": ketqua = So1 - So2; break;
        //        case "*": ketqua = So1 * So2; break;
        //        case "/": ketqua = So1 / So2; break;
        //    }
        //    //b3.Tra ket qua ve nguoi dung
        //    // ViewData["KQ"] = ketqua; //truyền dữ liệu cho view thông qua ViewData
        //    ViewBag.KQ = ketqua; //truyền dữ liệu cho view thông qua ViewBag
        //    return View();
        //}
        public IActionResult xuly(MayTinh mt)
        {
            //b1.lấy giá trị các tham số (So1, So2, PhepTinh)
            //b2. tinh toan ket qua 
            //double ketqua = 0;
            //switch (mt.PhepTinh)
            //{
            //    case "+": ketqua = mt.So1 + mt.So2; break;
            //    case "-": ketqua = mt.So1 - mt.So2; break;
            //    case "*": ketqua = mt.So1 * mt.So2; break;
            //    case "/": ketqua = mt.So1 / mt.So2; break;
            //}
            //b3.Tra ket qua ve nguoi dung
            // ViewData["KQ"] = ketqua; //truyền dữ liệu cho view thông qua ViewData
            //ViewBag.KQ = ketqua; //truyền dữ liệu cho view thông qua ViewBag
            //return View();
            return View("Index",mt);
        }
    }
}
