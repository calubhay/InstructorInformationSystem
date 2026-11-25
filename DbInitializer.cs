using InstructorSystem.Models;

namespace InstructorSystem;

public static class DbInitializer
{
    public static readonly List<Instructor> StaffList = new()
    {
        // ==========================================
        // Institute of Education (IED) Teaching Staff
        // ==========================================
        new Instructor
        {
            InstructorId = "1",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Ianne Joy Y. Maniquiz",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "142 M.H. Del Pilar St., Malolos, Bulacan",
            EmailAddress = "iannejoy.maniquiz@gmail.com"
        },
        new Instructor
        {
            InstructorId = "2",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Clarisse D. Dragon",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "78 MacArthur Highway, Guiguinto, Bulacan",
            EmailAddress = "clarisse.dragon@gmail.com"
        },
        new Instructor
        {
            InstructorId = "3",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Veronica Rose B. Gutierrez",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "215 San Jose St., Baliuag, Bulacan",
            EmailAddress = "veronicarose.gutierrez@gmail.com"
        },
        new Instructor
        {
            InstructorId = "4",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Aira D. Banal",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "33 Mabini St., Plaridel, Bulacan",
            EmailAddress = "aira.banal@gmail.com"
        },
        new Instructor
        {
            InstructorId = "5",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Angelica M. Velasco",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "89 Burgos St., Calumpit, Bulacan",
            EmailAddress = "angelica.velasco@gmail.com"
        },
        new Instructor
        {
            InstructorId = "6",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Shella D. Romero",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "504 Luna St., Hagonoy, Bulacan",
            EmailAddress = "shella.romero@gmail.com"
        },
        new Instructor
        {
            InstructorId = "7",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Dr. Jenelyn D. Barro",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "12 University Ave., City of Malolos, Bulacan",
            EmailAddress = "jenelyn.barro@gmail.com"
        },
        new Instructor
        {
            InstructorId = "8",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Juliana A. Degollado",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "67 B.S. Aquino Ave., Pulilan, Bulacan",
            EmailAddress = "juliana.degollado@gmail.com"
        },
        new Instructor
        {
            InstructorId = "9",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Andrea A. Villanueva",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "19 Bonifacio St., Bocaue, Bulacan",
            EmailAddress = "andrea.villanueva@gmail.com"
        },
        new Instructor
        {
            InstructorId = "10",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Rodrick S. Ramos",
            Department = "Institute of Education (IED)",
            Gender = "Male",
            Address = "88 Gov. Padilla Rd., Bustos, Bulacan",
            EmailAddress = "rodrick.ramos@gmail.com"
        },
        new Instructor
        {
            InstructorId = "11",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Hope M. Caceres",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "102 Provincial Rd., Santa Maria, Bulacan",
            EmailAddress = "hope.caceres@gmail.com"
        },
        new Instructor
        {
            InstructorId = "12",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Celeste D. Bucat",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "45 Poblacion, Pandi, Bulacan",
            EmailAddress = "celeste.bucat@gmail.com"
        },
        new Instructor
        {
            InstructorId = "13",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Arnold V. Aguilar",
            Department = "Institute of Education (IED)",
            Gender = "Male",
            Address = "312 Cagayan Valley Rd., San Rafael, Bulacan",
            EmailAddress = "arnold.aguilar@gmail.com"
        },
        new Instructor
        {
            InstructorId = "14",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Jester De Leon",
            Department = "Institute of Education (IED)",
            Gender = "Male",
            Address = "56 Rizal Ave., Angat, Bulacan",
            EmailAddress = "jester.deleon@gmail.com"
        },
        new Instructor
        {
            InstructorId = "15",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mary Rose D. Sonajo",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "71 Sto. Rosario St., Paombong, Bulacan",
            EmailAddress = "maryrose.sonajo@gmail.com"
        },
        new Instructor
        {
            InstructorId = "16",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Emily D. Mayor",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "93 San Pedro St., Marilao, Bulacan",
            EmailAddress = "emily.mayor@gmail.com"
        },
        new Instructor
        {
            InstructorId = "17",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Asrielle Grace D. Dalusong",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "240 MacArthur Highway, Meycauayan, Bulacan",
            EmailAddress = "asriellegrace.dalusong@gmail.com"
        },
        new Instructor
        {
            InstructorId = "18",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Melanie B. Merto",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "15 Camachile St., San Jose del Monte, Bulacan",
            EmailAddress = "melanie.merto@gmail.com"
        },
        new Instructor
        {
            InstructorId = "19",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Jeaneth B. Doyog",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "83 Bayan St., Norzagaray, Bulacan",
            EmailAddress = "jeaneth.doyog@gmail.com"
        },
        new Instructor
        {
            InstructorId = "20",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Garry D. Achacoso",
            Department = "Institute of Education (IED)",
            Gender = "Male",
            Address = "119 Poblacion Central, San Ildefonso, Bulacan",
            EmailAddress = "garry.achacoso@gmail.com"
        },
        new Instructor
        {
            InstructorId = "21",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Blesilda D. Fontanilla",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "62 Salcedo St., San Miguel, Bulacan",
            EmailAddress = "blesilda.fontanilla@gmail.com"
        },
        new Instructor
        {
            InstructorId = "22",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Charlie T. Carreon",
            Department = "Institute of Education (IED)",
            Gender = "Male",
            Address = "201 Doña Remedios Trinidad Hwy, Baliuag, Bulacan",
            EmailAddress = "charlie.carreon@gmail.com"
        },
        new Instructor
        {
            InstructorId = "23",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Melinda D. Punzalan",
            Department = "Institute of Education (IED)",
            Gender = "Female",
            Address = "77 Sto. Niño St., Malolos, Bulacan",
            EmailAddress = "melinda.punzalan@gmail.com"
        },

        // ==========================================
        // Institute of Computing Studies (ICS) Teaching Staff
        // ==========================================
        new Instructor
        {
            InstructorId = "24",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "John Raymond D. Pergis",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "12 Technology Ave., IT Park, Manila",
            EmailAddress = "johnraymond.pergis@gmail.com"
        },
        new Instructor
        {
            InstructorId = "25",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Michelle Angela A. Alejandro",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "88 Ayala Ave., Makati City",
            EmailAddress = "michelleangela.alejandro@gmail.com"
        },
        new Instructor
        {
            InstructorId = "26",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Royssan L. Salinas",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "45 Aurora Blvd., Quezon City",
            EmailAddress = "royssan.salinas@gmail.com"
        },
        new Instructor
        {
            InstructorId = "27",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Eddynith R. Dilag",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "102 Ortigas Ave., Pasig City",
            EmailAddress = "eddynith.dilag@gmail.com"
        },
        new Instructor
        {
            InstructorId = "28",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Ms. Kristel Joy L. Salinas",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "21 Commonwealth Ave., Quezon City",
            EmailAddress = "kristeljoy.salinas@gmail.com"
        },
        new Instructor
        {
            InstructorId = "29",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Noli B. Baluyot",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "350 España Blvd., Sampaloc, Manila",
            EmailAddress = "noli.baluyot@gmail.com"
        },
        new Instructor
        {
            InstructorId = "30",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Mar-Ian M. Dagun",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "17 Taft Ave., Malate, Manila",
            EmailAddress = "marian.dagun@gmail.com"
        },
        new Instructor
        {
            InstructorId = "31",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Ms. Claudine E. Isidoro",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "64 Shaw Blvd., Mandaluyong City",
            EmailAddress = "claudine.isidoro@gmail.com"
        },
        new Instructor
        {
            InstructorId = "32",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Vincent C. Acayan",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "509 Boni Ave., Mandaluyong City",
            EmailAddress = "vincent.acayan@gmail.com"
        },
        new Instructor
        {
            InstructorId = "33",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Crisver L. Susa",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "78 Katipunan Ave., Loyola Heights, Quezon City",
            EmailAddress = "crisver.susa@gmail.com"
        },
        new Instructor
        {
            InstructorId = "34",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Ms. Elaine C. Custo",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "29 Pioneer St., Pasig City",
            EmailAddress = "elaine.custo@gmail.com"
        },
        new Instructor
        {
            InstructorId = "35",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Antonio Clovea B. Tolentino",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "114 C5 Road, Taguig City",
            EmailAddress = "antonioclovea.tolentino@gmail.com"
        },
        new Instructor
        {
            InstructorId = "36",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Albert B. Galera",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "83 Alabang-Zapote Rd., Muntinlupa City",
            EmailAddress = "albert.galera@gmail.com"
        },
        new Instructor
        {
            InstructorId = "37",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Antoniycoh Clovea Acinthy B. Tolentino",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "220 Roxas Blvd., Pasay City",
            EmailAddress = "antoniycoh.tolentino@gmail.com"
        },
        new Instructor
        {
            InstructorId = "38",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Ms. Maria Theresa B. Bayani",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "53 Timog Ave., Diliman, Quezon City",
            EmailAddress = "mariatheresa.bayani@gmail.com"
        },
        new Instructor
        {
            InstructorId = "39",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Albert Clent F. Dolojan",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "92 Marcos Highway, Marikina City",
            EmailAddress = "albertclent.dolojan@gmail.com"
        },
        new Instructor
        {
            InstructorId = "40",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Mr. Oscar G. Raguidan Jr.",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Male",
            Address = "310 E. Rodriguez Sr. Ave., Quezon City",
            EmailAddress = "oscar.raguidan@gmail.com"
        },
        new Instructor
        {
            InstructorId = "41",
            Age = "N/A",
            BachelorDegree = "N/A",
            Majorship = "N/A",
            FullName = "Maryjane D. Castro",
            Department = "Institute of Computing Studies (ICS)",
            Gender = "Female",
            Address = "44 Quirino Highway, Novaliches, Quezon City",
            EmailAddress = "maryjane.castro@gmail.com"
        }
    };

    public static void Seed(ApplicationDbContext context)
    {
        // Ensure all existing instructor records have BachelorDegree and Majorship set to 'N/A'
        var existingInstructors = context.Instructors.ToList();
        var modified = false;
        foreach (var inst in existingInstructors)
        {
            if (string.IsNullOrWhiteSpace(inst.Age))
            {
                inst.Age = "N/A";
                modified = true;
            }
            if (string.IsNullOrWhiteSpace(inst.BachelorDegree))
            {
                inst.BachelorDegree = "N/A";
                modified = true;
            }
            if (string.IsNullOrWhiteSpace(inst.Majorship))
            {
                inst.Majorship = "N/A";
                modified = true;
            }
        }
        if (modified)
        {
            context.SaveChanges();
        }

        var existingEmails = context.Instructors
            .Select(i => i.EmailAddress.ToLower())
            .ToHashSet();

        var existingIds = context.Instructors
            .Select(i => i.InstructorId)
            .ToHashSet();

        var toAdd = StaffList
            .Where(s => !existingEmails.Contains(s.EmailAddress.ToLower()) && !existingIds.Contains(s.InstructorId))
            .ToList();

        if (toAdd.Count > 0)
        {
            context.Instructors.AddRange(toAdd);
            context.SaveChanges();
        }
    }
}