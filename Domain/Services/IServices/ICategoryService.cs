using System.Collections.Generic;
using System.Threading.Tasks;
using Dws.Note_one.Api.Domain.Models;

namespace Dws.Note_one.Api.Domain.Services.IServices
{
    public interface ICategoryService {
        Task<IEnumerable<Category>> ListAsync();
    }
}