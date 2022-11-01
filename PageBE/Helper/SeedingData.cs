using Microsoft.EntityFrameworkCore;
using PageBE.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.Helper
{
    public static class SeedingData
    {
        public static void SeedStatusa(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusStudenta>().HasData(
               new StatusStudenta { statusId = 1, NazivStatusa = "Redovan" },
               new StatusStudenta { statusId = 2, NazivStatusa = "Vanredan" }
           );
        }

        public static void SeedStudenta(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studenti>().HasData(
               new Studenti { studentId = 1, brojIndexa = 8180, Ime = "Ivan", Prezime = "Krakan", Godina = 2, statusId = 1 },
               new Studenti { studentId = 2, brojIndexa = 4144, Ime = "Mujo", Prezime = "Mujic", Godina = 3, statusId = 1 },
               new Studenti { studentId = 3, brojIndexa = 5432, Ime = "Marija", Prezime = "Stanojevic", Godina = 1, statusId = 2 },
               new Studenti { studentId = 4, brojIndexa = 7564, Ime = "Kenan", Prezime = "Huremovic", Godina = 3, statusId = 1 },
               new Studenti { studentId = 5, brojIndexa = 3245, Ime = "Lamija", Prezime = "Krso", Godina = 3, statusId = 2 }
           );
        }

        public static void SeedKurs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kurs>().HasData(
               new Kurs { kursId = 1, NazivKursa = "Spanski jezik" },
               new Kurs { kursId = 2, NazivKursa = "JWT Kurs" },
               new Kurs { kursId = 3, NazivKursa = "Udemy C#" },
               new Kurs { kursId = 4, NazivKursa = "Engleski jezik" },
               new Kurs { kursId = 5, NazivKursa = "Njemacki jezik" }
           );
        }

        public static void SeedKursStudenta(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KursStudenta>().HasData(
               new KursStudenta { kursStudentaId = 1, studentId = 1, kursId = 1},
               new KursStudenta { kursStudentaId = 2, studentId = 1, kursId = 4 },
               new KursStudenta { kursStudentaId = 3, studentId = 2, kursId = 2 },
               new KursStudenta { kursStudentaId = 4, studentId = 2, kursId = 3 },
               new KursStudenta { kursStudentaId = 5, studentId = 2, kursId = 5 },
               new KursStudenta { kursStudentaId = 6, studentId = 3, kursId = 3 },
               new KursStudenta { kursStudentaId = 7, studentId = 4, kursId = 5 },
               new KursStudenta { kursStudentaId = 8, studentId = 4, kursId = 3 },
               new KursStudenta { kursStudentaId = 9, studentId = 5, kursId = 5 },
               new KursStudenta { kursStudentaId = 10, studentId = 5, kursId = 3 },
               new KursStudenta { kursStudentaId = 11, studentId = 4, kursId = 2 }
           );
        }
    }
}
