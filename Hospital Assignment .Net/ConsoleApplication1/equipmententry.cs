using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ConsoleApplication1
{
    public class equipmententry
    {

        public void Insert(string equip_name, string requested_date, string date_defected)
        {
            equipment eq = new equipment();
            eq.equip_name = equip_name;
            eq.requested_date = Convert.ToDateTime(requested_date);
            eq.date_defected = Convert.ToDateTime(date_defected);


            using (var Data = new HospitalEntities1())
            {
                Data.equipments.AddObject(eq);
                Data.SaveChanges();

            }
        }
    }
}
