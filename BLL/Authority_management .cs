using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Authority_management
    {

        public string Judge_authority(string staff_id)
        {
            BLL.staff staff = new BLL.staff();
            Model.staff staff1 = new Model.staff();
            staff1 = staff.GetModel(staff_id);

            return staff1.staff_sx.Trim();

            
        }
    }
}
