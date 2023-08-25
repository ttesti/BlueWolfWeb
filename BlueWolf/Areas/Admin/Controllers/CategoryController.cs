using BlueWolf.Data;
using BlueWolf.DataAccess.Repository.IRepository;
using BlueWolf.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace BlueWolfApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category Created Successfuly";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryfromdb = _unitOfWork.Category.GetValue(u => u.Id == id);
            //Category categoryfromdb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category categoryfromdb2 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();
            if (categoryfromdb == null)
            {
                return NotFound();
            }
            return View(categoryfromdb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category Editied Successfuly";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryfromdb = _unitOfWork.Category.GetValue(u => u.Id == id);
            if (categoryfromdb == null)
            {
                return NotFound();
            }
            return View(categoryfromdb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _unitOfWork.Category.GetValue(u => u.Id == id);
            if (obj == null)
            {
                return NotFound(obj);
            }
            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category Deleted Successfuly";
            return RedirectToAction("Index");
        }

    }
}
