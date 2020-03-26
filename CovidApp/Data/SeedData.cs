using CovidApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApp.Data
{
    public static class SeedData
    {
        public static void SeedAccessionStrainRecords(this ModelBuilder builder)
        {
            builder.Entity<AccessionRecord>().HasData
            (
                 new AccessionRecord()
                 {
                     Id = 0,
                     AccessionNumber = "MN908947",
                     AccessionVersion = 3,
                     Country = "CN",
                     Region = "Wuhan",
                     CollectionDate = "DEC-2019",
                     //BaseLength = 29903
                     Orf1abSequence = "AAAAAA",
                     SurfaceGlycoproteinSequence = "AAAAAA",
                     Orf3aSequence = "AAAAAA"
                 },

                new AccessionRecord()
                {
                    Id = -1,
                    AccessionNumber = "MN988668",
                    AccessionVersion = 1,
                    Country = "CN",

                    CollectionDate = "02-Jan-2020",
                    //BaseLength = 29881
                    Orf1abSequence = "AAAAAW",
                    SurfaceGlycoproteinSequence = "AAAAWA",
                    Orf3aSequence = "AAAWWW"
                },

                new AccessionRecord()
                {
                    Id = -2,
                    AccessionNumber = "LC528232",
                    AccessionVersion = 1,
                    Country = "JP",

                    CollectionDate = "2020-02-10",
                    //BaseLength = 29902
                    Orf1abSequence = "AAAAAA",
                    SurfaceGlycoproteinSequence = "AAAWAA",
                    Orf3aSequence = "WAAWWA"
                },

                new AccessionRecord()
                {
                    Id = -3,
                    AccessionNumber = "MN988713",
                    AccessionVersion = 1,
                    Country = "US",
                    Region = "IL",
                    CollectionDate = "21-Jan-2020",
                    //BaseLength = 29882
                    Orf1abSequence = "AWAWAW",
                    SurfaceGlycoproteinSequence = "AAAWWW",
                    Orf3aSequence = "WWWAAA"
                }
            );
        }

    }
}
