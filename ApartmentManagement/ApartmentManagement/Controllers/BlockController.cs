using ApartmentManagement.Business.Abstracts;
using ApartmentManagement.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApartmentManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BlockController : Controller
    {
        private readonly IBlockService blockService;
        public BlockController(IBlockService blockService)
        {
            this.blockService = blockService;
        }
        public IActionResult Index()
        {
            var blocks = blockService.GetAllBlock();
            return View(blocks);
        }

        [HttpGet]
        public IActionResult AddBlock()
        {
     
            return View();
        }
        [HttpPost]
        public IActionResult AddBlock([FromForm] Block block)
        {
            blockService.AddBlock(block);
            TempData["Alert"] = "Başarıyla Eklendi";
            return RedirectToAction("Index", "block");
        }
        [HttpPost]
        public IActionResult UpdateBlock([FromForm] Block block)
        {
            if (ModelState.IsValid)
            {
                blockService.UpdateBlock(block);
                TempData["Alert"] = "Başarıyla Düzenlendi";
                return RedirectToAction("Index", "block");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult UpdateBlock(int id)
        {

            var model = blockService.GetAllBlock().ToList().Where(x => x.Id == id).FirstOrDefault();
      
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteBlock(int id)
        {

            var block = blockService.GetAllBlock().ToList().Where(x=>x.Id== id).FirstOrDefault();
            blockService.DeleteBlock(block);
            TempData["Alert"] = "Başarıyla Silindi";
            return RedirectToAction("Index", "block");
        }

    }
}
