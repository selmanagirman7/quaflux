﻿using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.ViewComponents
{
    public class EnSliderCommponent:ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public IViewComponentResult Invoke()
        {
            var result = sliderManager.GetAll();
            return View(result);
        }
    }
}
