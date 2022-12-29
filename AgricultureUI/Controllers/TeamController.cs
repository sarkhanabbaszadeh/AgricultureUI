using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var valus = _teamService.GetListAll();
            return View(valus);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            _teamService.Insert(team);
            return RedirectToAction("Index");
        }
    }
}
