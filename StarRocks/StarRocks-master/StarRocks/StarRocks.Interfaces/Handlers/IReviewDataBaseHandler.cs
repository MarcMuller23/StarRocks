using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface IReviewDataBaseHandler
    {
        List<IReview> GetAllReviews();

        void CreateReview(IReview R1);

        void UpdateReview(IReview R1);

        void DeleteReview(int ID);
    }
}
