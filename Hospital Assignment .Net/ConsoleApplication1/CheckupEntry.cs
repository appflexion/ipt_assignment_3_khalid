using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.EntityModel;

namespace ConsoleApplication1
{
    public class CheckupEntry
    {
        public void Insert(int patient_id, string complains, string findings, int treat_id, int med_id, int quantity, string check_date)
        {
            check_up ch = new check_up();
            ch.patient_id = patient_id;
            ch.complains = complains;
            ch.findings = findings;
            ch.treat_id = treat_id;
            ch.med_id = med_id;
            ch.quantity = quantity;
            ch.check_date = Convert.ToDateTime(check_date);


            using (var Data = new HospitalEntities1())
            {
                Data.check_up.AddObject(ch);
                Data.SaveChanges();

            }
        }
    }
}
