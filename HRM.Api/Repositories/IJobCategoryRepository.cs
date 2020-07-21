using System.Collections.Generic;
using HRM.Shared;

namespace HRM.Api.Repositories
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
