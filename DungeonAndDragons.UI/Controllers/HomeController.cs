using System.Diagnostics;
using DungeonAndDragons.Core.Entities;
using DungeonAndDragons.Core.Models;
using Microsoft.AspNetCore.Mvc;
using DungeonAndDragons.UI.Models;

namespace DungeonAndDragons.UI.Controllers;

public class HomeController : Controller
{
    private readonly IConfiguration _configuration;
    
    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IActionResult> Index(Player player)
    {
        var client = new HttpClient();
        HttpResponseMessage? result = null;
        if (ModelState.IsValid)
        {
            result = await client.PostAsJsonAsync(_configuration["Urls:Core"], player);
        }

        BattleResultModel? battleResult = null;
        if (result != null)
            battleResult = await result.Content.ReadFromJsonAsync<BattleResultModel>();
        
        return View(battleResult);
    }
}