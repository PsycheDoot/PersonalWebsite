﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CharacterScriptingLibrary()
        {
            return View();
        }

		public ActionResult CanvasScriptingTool() {
			return View();
		}
    }
}