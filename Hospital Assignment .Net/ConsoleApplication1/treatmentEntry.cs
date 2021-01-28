using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ConsoleApplication1
{
    public class treatmentEntry
    {
        public void Insert(string treat_type)
        {
            treatment tr = new treatment();
            tr.treat_type = treat_type;

            using (var Data = new HospitalEntities1())
            {
                Data.treatments.AddObject(tr);
                Data.SaveChanges();

            }
        }
    }
}