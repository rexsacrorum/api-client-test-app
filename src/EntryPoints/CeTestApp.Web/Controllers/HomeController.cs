using System.Diagnostics;
using CeTestApp.Web.Application.Interfaces;
using CeTestApp.Web.Infrastructure.Workflows;
using Microsoft.AspNetCore.Mvc;
using CeTestApp.Web.Models;

namespace CeTestApp.Web.Controllers;

public class HomeController : Controller
{
    public HomeController(ILogger<HomeController> logger,
        IHomeWorkflow workflow)
    {
        _logger = logger;
        Workflow = workflow;
    }

    public async Task<IActionResult> Index()
    {
        var model = await Workflow.GetResultOfAllOperationsAsync()
            .ConfigureAwait(false);
        
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    private readonly ILogger<HomeController> _logger;
    private IHomeWorkflow Workflow { get; }
}