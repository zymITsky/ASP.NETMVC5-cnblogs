﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SlarkInc.Models;

namespace SlarkInc.DAL
{
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseAlways<CompanyContext>  //每次程序运行时都会删除并重新创建数据库
    {
        protected override void Seed(CompanyContext context)
        {
            var students = new List<Worker>
            {
                new Worker{FirstName="Andy",LastName="George",Sex = Sex.Male},
                new Worker{FirstName="Laura",LastName="Smith",Sex = Sex.Female},
                new Worker{FirstName="Jason",LastName="Black",Sex = Sex.Male},
                new Worker{FirstName="Linda",LastName="Queen",Sex = Sex.Female},
                new Worker{FirstName="James",LastName="Brown", Sex = Sex.Male}
            };
            students.ForEach(s=>context.Workers.Add(s));
            context.SaveChanges();

        }
    }
}