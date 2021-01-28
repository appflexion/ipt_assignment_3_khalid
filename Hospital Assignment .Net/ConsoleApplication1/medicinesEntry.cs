using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ConsoleApplication1
{
    public class medicinesEntry
    {
        public void Insert(string med_name, int quantity, int available_Qty, string exp_date, string requested_date)
        {
            medicine md = new medicine();
            md.med_name = med_name;
            md.quantity = quantity;
            md.available_Qty = available_Qty;
            md.exp_date = Convert.ToDateTime(exp_date);
            md.requested_date = Convert.ToDateTime(requested_date);


            using (var Data = new HospitalEntities1())
            {
                Data.medicines.AddObject(md);
                Data.SaveChanges();

            }
        }
    }
}
