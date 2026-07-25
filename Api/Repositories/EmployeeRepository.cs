using Dapper;
using EmployeeLeaveManagement.Api.Interfaces;
using EmployeeLeaveManagement.Api.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace EmployeeLeaveManagement.Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _config;
        public EmployeeRepository(IConfiguration config) 
        {
            _config = config;
        }
        
        private IDbConnection Connection()
        {
            return new MySqlConnection(_config.GetConnectionString("DefaultConnection"));
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                using var db = Connection();
                string sql = @"Select * from Employees";
                return await db.QueryAsync<Employee>(sql);
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }
        public async Task<int> AddEmployee(Employee employee) 
        {
            using var db = Connection();
            var sql = @"Insert into Employees(UserName, Email, Department, Designation) values (@UserName, @Email, @Department, @Designation)";
            return await db.ExecuteAsync(sql, employee);
        }
    }
}
