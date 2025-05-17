using ECommerce.Core.Entities;
using ECommerce.Core.Interfaces;

namespace ECommerce.Infrastrucure.Data;

public class SpacificationEvaludator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
    {
        if (specification.Criteria != null)
        {
            inputQuery = inputQuery.Where(specification.Criteria);
        }
        return inputQuery;
    }
}
