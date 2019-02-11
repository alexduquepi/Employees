using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using RestSharp;
using Newtonsoft.Json;


namespace DataAccessLayer
{
    public class EmployeesDAL
    {       

        public List<Employee> GetEmployees(int id)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                RestClient restClient = new RestClient("http://masglobaltestapi.azurewebsites.net/api/Employees");
                RestRequest restRequest = new RestRequest(Method.POST);
                restRequest = new RestRequest(Method.GET);


                IRestResponse restResponse = restClient.Execute(restRequest);

                employees = JsonConvert.DeserializeObject<List<Employee>>(restResponse.Content);

                if(id != 0)
                {
                    return new List<Employee>() { employees.FirstOrDefault(i => i.id == id) };
                }
            }
            catch (Exception ex)
            {

            }

            return employees;
        }       
    }
}
