using Core.Persistence.Repositories;
using Domain.Entities;

public interface IModelRepository : IAsyncRepository<Model, Guid>, IRepository<Model, Guid>
{

}
