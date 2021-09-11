﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using work_01.Data;

namespace work_01.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CreateRole(String userrole)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(userrole))
            {
                if (await _roleManager.RoleExistsAsync(userrole))
                {
                    msg = "Role " + userrole + " already exist!!";
                }
                else
                {
                    IdentityRole r = new IdentityRole(userrole);
                    await _roleManager.CreateAsync(r);
                    msg = "Role " + userrole + " created successfully!!";
                }
            }
            else
            {
                msg = "Please enter a valid role name!";
            }
            ViewBag.msg = msg;
            return View("Index");
        }

        public IActionResult AssignRole()
        {
            ViewBag.users = _userManager.Users;
            ViewBag.roles = _roleManager.Roles;
            ViewBag.msg = TempData["msg"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(string userdata, string roledata)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(userdata) && !string.IsNullOrEmpty(roledata))
            {
                ApplicationUser u = await _userManager.FindByEmailAsync(userdata);
                if (u != null)
                {
                    if (await _roleManager.RoleExistsAsync(roledata))
                    {
                        await _userManager.AddToRoleAsync(u, roledata);
                        msg = "Role has been assigned to user";
                    }
                    else
                    {
                        msg = "Role does not exist.";
                    }
                }
                else
                {
                    msg = "User is not found";
                }
            }
            else
            {
                msg = "Please select valid user/role data!!";
            }
            TempData["msg"] = msg;
            return RedirectToAction("AssignRole");
        }
    }

   
}