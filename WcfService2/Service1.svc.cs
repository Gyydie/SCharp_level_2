using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WcfService2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        SqlConnection connection;
        SqlDataAdapter adGeneral;
        SqlDataAdapter adEmpl;
        DataTable dtGeneral;
        DataTable dtEmpl;

        public string GetData(string value)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "lesson7"
            };

            connection = new SqlConnection(connectionStringBuilder.ConnectionString);
            adGeneral = new SqlDataAdapter();

            //select all information
            SqlCommand command =
                new SqlCommand(@"SELECT e.ID, eName as Name, Surname," +
                             " Age, Salary, dName as Department" +
                             " FROM Employees e" +
                             " JOIN Departments d on e.DepartmentID = d.ID",
                connection);
            adGeneral.SelectCommand = command;
            dtGeneral = new DataTable();
            adGeneral.Fill(dtGeneral);
            dtEmpl = new DataTable();


            //select all empolyees
            adEmpl = new SqlDataAdapter();
            command =
                new SqlCommand(@"SELECT ID, eName, Surname," +
                             " Age, Salary, DepartmentID" +
                             " FROM Employees",
                connection);
            adEmpl.SelectCommand = command;
            adEmpl.Fill(dtEmpl);

            string result = String.Empty;

           result += $"{dtEmpl}\n";

            return result;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
