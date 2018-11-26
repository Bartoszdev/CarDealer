namespace CarDealer.Models
{
    public class OpinionRepository : IOpinionRepository

    {
        private readonly AppDbContext _appDbContext;
        public void AddOpinion(Opinion opinion)
        {
            _appDbContext.Opinions.Add(opinion);
            _appDbContext.SaveChanges();
        }

        public OpinionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
