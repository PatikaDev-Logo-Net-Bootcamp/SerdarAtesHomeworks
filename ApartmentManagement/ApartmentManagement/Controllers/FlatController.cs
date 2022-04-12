using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Business.DTOs;
using ApartmentManagement.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApartmentManagement.Controllers
{
    public class FlatController : Controller
    {
        private readonly IFlatService flatService;
        private readonly IBlockService blockService;
        private readonly UserManager<ApplicationUser> userManager;


        public FlatController(IFlatService flatService,IBlockService blockService,UserManager<ApplicationUser> userManager)
        {
            this.flatService = flatService;
            this.blockService = blockService;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var flats = flatService.GetFlatsWithUsersAndBlocks();
            return View(flats);
        }
        [HttpGet]
        public async Task<IActionResult> AddFlatAsync()
        {
            var blocks = blockService.GetAllBlock();
            var users = await userManager.Users.ToListAsync();
                var elemets = new FlatAddDto
                {
                    Blocks = blocks,
                    Owner = users,
                };
                return View(elemets);
          }
        [HttpPost]
        public IActionResult AddFlat([FromForm] FlatAddDto flat)
        {
            var flats = new Flats
            {
               Type = flat.Type,
               IsEmpty=flat.IsEmpty,
               OwnerId=flat.OwnerId,
               BlockId=flat.BlockId,
               FlatNo=flat.FlatNo,

               
            };
            flatService.AddFlats(flats);
            return RedirectToAction("Index","Flat");
        }
    }
}
