using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            equipmententry equip = new equipmententry();
            equip.Insert("Wheelchair", "2021-1-1", "2023-1-1");

            medicinesEntry med = new medicinesEntry();
            med.Insert("regix", 50, 30, "2023-1-1", "2020-1-1");

            PatientEntry pt = new PatientEntry();
            pt.Insert("Neha", "Ali", "Skin Allergy", 23, "QWE address");

            treatmentEntry trt = new treatmentEntry();
            trt.Insert("Cardiography");

            CheckupEntry chk = new CheckupEntry();
            chk.Insert(3, "Iching and rednish on skin", "Eczema, Common skin desease", 1, 3, 4, "2021-1-2");


        }
    }
}
