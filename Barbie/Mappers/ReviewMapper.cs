using Barbie.Dtos;
using Barbie.Models;
namespace Barbie.Mappers;

public class ReviewMapper
{
    public ReviewDto ToReviewDto(Review review)
    {
        return new ReviewDto()
        {
        Text = review.Text,
        Value = review.Value,
        BarberId = review.BarberId,
        ClientId = review.ClientId,
        AdminId = review.AdminId
        };
    }
}