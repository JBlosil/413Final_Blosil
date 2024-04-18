using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _413Final_Blosil.Models;
using _413Final_Blosil.Models.ViewModels;

namespace _413Final_Blosil.Controllers;

public class HomeController : Controller
{
    private IEntertainmentAgencyExampleRepository _repo;
    
    public HomeController(IEntertainmentAgencyExampleRepository temp)
    {
        _repo = temp;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Entertainers()
    {

        var entertainers = new EntertainersListViewModel()
        {
            Entertainers = _repo.Entertainers?.OrderBy(e => e.EntStageName) ?? Enumerable.Empty<Entertainer>().AsQueryable()
        };

        return View(entertainers);
    }

    public IActionResult EntertainerDetails(int entertainer_ID)
    {

        var entertainer = _repo.Entertainers.FirstOrDefault(e => e.EntertainerID == entertainer_ID);

        return View(entertainer);
    }

    [HttpGet]
    public IActionResult AddEntertainer()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddEntertainer(Entertainer entertainer)
    {
        if (ModelState.IsValid)
        {
            _repo.AddEntertainer(entertainer);
            _repo.SaveChanges();
            return RedirectToAction("Entertainers");  // Redirect to the index action/view
        }
        return View(entertainer);
    }
    
    public IActionResult Edit(int id)
    {
        var entertainer = _repo.Entertainers.FirstOrDefault(e => e.EntertainerID == id);
        if (entertainer == null)
        {
            return NotFound();
        }
        return View(entertainer);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Entertainer entertainer)
    {
        if (id != entertainer.EntertainerID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _repo.UpdateEntertainer(entertainer);
            _repo.SaveChanges();
            return RedirectToAction(nameof(Index));  // Redirect to the index action/view
        }
        return View(entertainer);
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordDelete = _repo.Entertainers
            .Single(x => x.EntertainerID == id);

        return View(recordDelete);
    }
    
    [HttpPost]
    public IActionResult Delete(Entertainer entertainer)
    {
        _repo.DeleteEntertainer(entertainer.EntertainerID);
        _repo.SaveChanges();

        return RedirectToAction("Entertainers");
    }
}