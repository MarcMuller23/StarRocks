using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface IReviewLogic
    {
        void CreateReview(IReview review);
        List<IReview> GetAllReviews();
        IReview UpdateReview(IReview review);
        void DeleteReview(int reviewId);
        IReview GetById(IReview review);
    }
}
