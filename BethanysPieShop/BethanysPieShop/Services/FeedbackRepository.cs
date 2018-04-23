using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.Services
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _dbcontext;

        public FeedbackRepository(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddFeedback(Feedback feedback)
        {
            _dbcontext.Feedbacks.Add(feedback);
            _dbcontext.SaveChanges();
        }
    }
}
