using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

public class ModelRepository : EfRepositoryBase<Model, Guid, BaseDbContext>, IModelRepository
{
    public ModelRepository(BaseDbContext context) : base(context)
    {
    }
}


