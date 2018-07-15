using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplemanCorner.Data.Infrastructure;
using SimplemanCorner.Model.Models;

namespace SimplemanCorner.Data.Repositories
{
    public interface IApplicationUserGroupRepository : IRepository<ApplicationUserGroup>
    {

    }
    public class ApplicationUserGroupRepository : RepositoryBase<ApplicationUserGroup>, IApplicationUserGroupRepository
    {
        public ApplicationUserGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
