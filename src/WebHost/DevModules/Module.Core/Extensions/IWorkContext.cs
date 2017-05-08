using System.Threading.Tasks;
using Module.Core.Models;

namespace Module.Core.Extensions
{
    public interface IWorkContext
    {
        Task<User> GetCurrentUser();
    }
}
