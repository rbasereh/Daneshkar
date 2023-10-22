namespace aspnetcore9
{
    public class PersonController
    {
        public PersonController(ICalculationService service)
        {

        }
    }

    public interface ICalculationService
    {
        void CalcSalary();
        void CalcSalaryA();
        void CalcSalaryB();
        void CalcSalaryC();
    }
    public class CalculationTypeAService : ICalculationService
    {
        public CalculationTypeAService(PersonRepository repository) { }

        public void CalcSalary()
        {
            throw new NotImplementedException();
        }

        public void CalcSalaryA()
        {
            throw new NotImplementedException();
        }

        public void CalcSalaryB()
        {
            throw new NotImplementedException();
        }

        public void CalcSalaryC()
        {
            throw new NotImplementedException();
        }
    }
    public class CalculationTypeBService : ICalculationService
    {
        public CalculationTypeBService(IDataRepository repository) { }

        public void CalcSalary()
        {
            throw new NotImplementedException();
        }

        public void CalcSalaryA()
        {
            throw new NotImplementedException();
        }

        public void CalcSalaryB()
        {
            throw new NotImplementedException();
        }

        public void CalcSalaryC()
        {
            throw new NotImplementedException();
        }
    }


    public interface IDataRepository
    {

    }
    public class PersonRepository : IDataRepository
    {
        public PersonRepository() { }
    }
}
