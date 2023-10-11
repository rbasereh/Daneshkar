using aspnetcore9.Data;

namespace aspnetcore9.Services
{
    public class SmartphoneService
    {
        private readonly AppDbContext appDbContext;

        public SmartphoneService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

    }
}
