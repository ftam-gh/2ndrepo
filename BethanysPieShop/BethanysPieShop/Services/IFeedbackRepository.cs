using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Services
{
    interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
