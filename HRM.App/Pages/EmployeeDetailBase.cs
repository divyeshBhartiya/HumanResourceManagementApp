using HRM.App.Services;
using HRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.App.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeDataService employeeDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {

            //InitializeCountries();
            //InitializeJobCategories();
            //InitializeEmployees();
            Employee = await GetEmployeeByID(EmployeeId);
        }

        public IEnumerable<Employee> Employees { get; set; }

        //private IList<Country> Countries { get; set; }

        //private IList<JobCategory> JobCategories { get; set; }

        //private void InitializeJobCategories()
        //{
        //    JobCategories = new List<JobCategory>()
        //    {
        //        new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
        //        new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
        //        new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
        //        new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
        //        new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
        //        new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
        //        new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
        //        new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
        //        new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
        //        new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}
        //    };
        //}

        //private void InitializeCountries()
        //{
        //    Countries = new List<Country>
        //    {
        //        new Country {CountryId = 1, Name = "Belgium"},
        //        new Country {CountryId = 2, Name = "Netherlands"},
        //        new Country {CountryId = 3, Name = "USA"},
        //        new Country {CountryId = 4, Name = "Japan"},
        //        new Country {CountryId = 5, Name = "China"},
        //        new Country {CountryId = 6, Name = "UK"},
        //        new Country {CountryId = 7, Name = "France"},
        //        new Country {CountryId = 8, Name = "Brazil"}
        //    };
        //}

        private async Task<Employee> GetEmployeeByID(string EmployeeId)
        {
            return await (employeeDataService.GetEmployeeDetails(int.Parse(EmployeeId)));
        }
    }
}
