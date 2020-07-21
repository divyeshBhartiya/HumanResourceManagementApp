using HRM.App.Services;
using HRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.App.Pages
{
    public partial class EmployeeEdit : ComponentBase
    {
        [Inject]
        public IEmployeeDataService employeeDataService { get; set; }
        [Inject]
        public ICountryDataService countryDataService { get; set; }
        [Inject]
        public IJobCategoryDataService jobCategoryDataService { get; set; }
        [Parameter]
        public string employeeID { get; set; }
        public Employee employee { get; set; } = new Employee();
        public IList<Country> countries { get; set; } = new List<Country>();
        public IList<JobCategory> jobCategories { get; set; } = new List<JobCategory>();
        protected string countryID = string.Empty;
        protected string jobCategoryId = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            countries = (await countryDataService.GetAllCountries()).ToList();
            jobCategories = (await jobCategoryDataService.GetAllJobCategories()).ToList();
            employee = await employeeDataService.GetEmployeeDetails(int.Parse(employeeID));
            countryID = employee.CountryId.ToString();
            jobCategoryId = employee.JobCategoryId.ToString();
        }
    }
}
