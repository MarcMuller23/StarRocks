using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class ReviewLogic : IReviewLogic
    {
        private readonly IReviewDataBaseHandler _reviewDatabaseHandler;

        public ReviewLogic(IReviewDataBaseHandler reviewDataBaseHandler)
        {
            _reviewDatabaseHandler = reviewDataBaseHandler;
        }
        private IReviewDataBaseHandler ReviewDataBaseHandler { get; }
        public void CreateReview(IReview review)
        {
            var _review = new Review()
            {
                ID = review.ID,
                EventID = review.ID,
                AccountID = review.AccountID,
                Rating = review.Rating,
                Message = review.Message
            };
            ReviewDataBaseHandler.CreateReview(_review);
        }

        public void DeleteReview(int reviewId)
        {
            ReviewDataBaseHandler.DeleteReview(reviewId);
        }

        public List<IReview> GetAllReviews()
        {
            return ReviewDataBaseHandler.GetAllReviews();
        }

        public IReview GetById(IReview review)
        {
            throw new NotImplementedException();
            //return ReviewDataBaseHandler.GetById(review);
        }

        public IReview UpdateReview(IReview review)
        {
            ReviewDataBaseHandler.UpdateReview(review);
            return review;
        }
    }
}
