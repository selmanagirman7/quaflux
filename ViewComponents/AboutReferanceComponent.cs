﻿using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class AboutReferanceComponent:ViewComponent
    {
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        public IViewComponentResult Invoke()
        {
            var result = referanceManager.GetAll();
            return View(result);
        }
    }
}
