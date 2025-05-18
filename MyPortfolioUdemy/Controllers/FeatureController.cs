﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult FeatureList()
        {
            var values = context.Features.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            context.Features.Add(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public IActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
