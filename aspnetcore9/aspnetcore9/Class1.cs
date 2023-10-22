namespace aspnetcore9
{
    public class PersonController2
    {
        public PersonController2()
        {

        }


    }

    public class CalculateSalaryRequest
    {
        public int EmployeeId { get; set; }
    }
    public class CreateProductReqest
    {
        public string Name { get; set; }
        public string Price { get; set; } 
    }

    public class CalculateSalaryRequestHandler
    {
        public void Handle(CalculateSalaryRequest request)
        {
            //......
        }
    }
    public class CreateProductReqestHandler
    {
        public void Handle(CreateProductReqest request)
        {
            //......
        }
    }
}
