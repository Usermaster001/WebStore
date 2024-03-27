﻿using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers;

public class HomeController : Controller
{
    private static readonly List<Employee> __Empoyees = new()
    {
        new Employee { Id = 1, LastName = "Иванов", Name = "Иван", Patronymic = "Иванович", Age = 23},
        new Employee { Id = 2, LastName = "Петров", Name = "Петр", Patronymic = "Петрович", Age = 27},
        new Employee { Id = 3, LastName = "Сидоров", Name = "Сидр", Patronymic = "Сидрович", Age = 33}
    };
    public IActionResult Index()
    {
        //return Content("Данные из первого контроллера");
        return View();
    }

    public string ConfiguredAction(string value)
    {
        return $"Hello {value}";
    }

    public IActionResult Employees()
    {
        return View(__Empoyees);
    }

    public IActionResult Employee(string[] employee)
    {
        return View(employee);
    }
}

