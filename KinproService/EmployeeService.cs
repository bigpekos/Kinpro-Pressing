using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KinproService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        KinproPressingEntities _KinproPressingEntitie;
        public EmployeeService()
        {
            _KinproPressingEntitie = new KinproPressingEntities();
        }

        public List<GetAllEmployeesSetting_Result> GetAllEmployeesSetting()
        {
            ObjectResult<GetAllEmployeesSetting_Result> employee = _KinproPressingEntitie.GetAllEmployeesSetting();
            return employee.ToList();
        }


        public void DeleteEmployee(int id)
        {
            _KinproPressingEntitie.DeleteEmployee(id);
        }

        public void updateEmployee(string name, int id, int phone)
        {
            _KinproPressingEntitie.UpdateEmployee(name, id, phone);
        }
    }
}
