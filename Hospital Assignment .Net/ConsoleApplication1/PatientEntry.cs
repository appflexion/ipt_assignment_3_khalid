using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ConsoleApplication1
{
    public class PatientEntry
    {
        public void Insert(string fname, string lname, string patient_type, int age, string addrs)
        {
            patient pt = new patient();
            pt.fname = fname;
            pt.lname = lname;
            pt.patient_type = patient_type;
            pt.age = age;
            pt.addrs = addrs;

            using (var Data = new HospitalEntities1())
            {
                Data.patients.AddObject(pt);
                Data.SaveChanges();
                
            }
        }
        
    }
}
