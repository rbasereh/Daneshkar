namespace Aspnetcore2.Controllers
{
    public class ValidationService
    {
        public HomeServiceA ServiceA { get; set; }
        public HomeServiceB ServiceB { get; set; }
        public HomeServiceC ServiceC { get; set; }

        public ValidationService(HomeServiceA serviceA
            , HomeServiceB serviceB 
            , HomeServiceC serviceC
            )
        {
            ServiceA = serviceA;
            ServiceB = serviceB;
            ServiceC = serviceC;
        }

        public void IsValid()
        {
            ServiceA.Calc(10);
            ServiceB.Calc(10);
            ServiceC.Calc(10);

            int x = ServiceA.CalcValue;
            int x2 = ServiceB.CalcValue;
            int x3 = ServiceC.CalcValue;
        }
    }
}
