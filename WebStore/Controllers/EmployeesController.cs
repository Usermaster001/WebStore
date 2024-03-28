using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> __Empoyees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", Name = "Иван", Patronymic = "Иванович", Age = 23},
            new Employee { Id = 2, LastName = "Петров", Name = "Петр", Patronymic = "Петрович", Age = 27},
            new Employee { Id = 3, LastName = "Сидоров", Name = "Сидр", Patronymic = "Сидрович", Age = 33}
        };

        public IActionResult Index()
        {
            var result = __Empoyees;
            return View(result);
        }

        public IActionResult Details(int Id)
        {
            var employee = __Empoyees.FirstOrDefault(x => x.Id == Id);
            
            if(employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}
