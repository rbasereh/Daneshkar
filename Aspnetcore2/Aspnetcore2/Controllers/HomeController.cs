using Aspnetcore2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aspnetcore2.Controllers
{
    public class Model { }
    public class HomeServiceA
    {
        public int CalcValue { get; set; } 
        public void Calc(int val)
        {
            CalcValue += val;
        }
    }
    public class HomeServiceB
    {
        public int CalcValue { get; set; }
        public void Calc(int val)
        {
            CalcValue += val;
        }
        public bool IsValid(Model model)
        {
            return true;
        }
        //public static HomeServiceB Instance { get; set; }
        //public static HomeServiceB GetInstance()
        //{
        //    if(Instance == null)
        //        Instance = new HomeServiceB();
        //    return Instance;
        //}
    }
    public class HomeServiceC
    {
        public int CalcValue { get; set; }
        public void Calc(int val)
        {
            CalcValue += val;
        }
        public bool IsValid(Model model)
        {
            return true;
        }
        //public static HomeServiceB Instance { get; set; }
        //public static HomeServiceB GetInstance()
        //{
        //    if(Instance == null)
        //        Instance = new HomeServiceB();
        //    return Instance;
        //}
    }
    public class HomeController : Controller
    {
        public HomeServiceA ServiceA { get; set; }
        public HomeServiceB ServiceB { get; set; }
        public HomeServiceC ServiceC { get; set; }
        public ValidationService ValidationService { get; }

        public HomeController(HomeServiceA serviceA
            , HomeServiceB serviceB
            , HomeServiceC serviceC
            ,ValidationService validationService
            )//(HomeService service)
        {
            ServiceA = serviceA;
            ServiceB = serviceB;
            ServiceC = serviceC;
            ValidationService = validationService;
            //ValidationService = new ValidationService(serviceA, serviceB , serviceC);
            //ServiceA = new();
            //ServiceB = HomeServiceB.GetInstance();
        }

        public IActionResult Index()
        {
            ServiceA.Calc(10);
            ServiceB.Calc(10);
            ServiceC.Calc(10);
            int x = ServiceA.CalcValue;
            int x2 = ServiceB.CalcValue; 
            int x3 = ServiceC.CalcValue;
            
            ValidationService.IsValid();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}