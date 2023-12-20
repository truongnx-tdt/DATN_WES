﻿using CsvHelper.Configuration;
using StudySystem.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySystem.Data.EF.Seed_Data.ClassMap
{
    public class ProvinceMap : ClassMap<Province>
    {
        public ProvinceMap()
        {
            Map(x => x.Code).Name("Code");
            Map(x => x.Name).Name("Name");
            Map(x => x.NameEn).Name("NameEn");
            Map(x => x.FullName).Name("FullName");
            Map(x => x.FullNameEn).Name("FullNameEn");
            Map(x => x.CodeName).Name("CodeName");
            Map(x => x.AdministrativeUnitId).Name("AdministrativeUnitId");
            Map(x => x.AdministrativeRegionId).Name("AdministrativeRegionId");
        }
    }
}
