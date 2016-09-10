using System;
using System.Linq;
using System.Text;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Common
{
    class UserGenerator
    {
        #region VezeteknevLista
        string[] VEZETEK_NEV_LISTA = new string[]{
        "NAGY",
        "KOVACS",
        "TOTH",
        "SZABO",
        "HORVATH",
        "VARGA",
        "KISS",
        "MOLNAR",
        "NEMETH",
        "FARKAS",
        "BALOGH",
        "PAPP",
        "TAKACS",
        "JUHASZ",
        "LAKATOS",
        "MESZAROS",
        "OLAH",
        "SIMON",
        "RACZ",
        "FEKETE",
        "SZILAGYI",
        "TOROK",
        "FEHER",
        "GAL",
        "BALAZS",
        "KIS",
        "SZUCS",
        "KOCSIS",
        "PINTER",
        "FODOR",
        "ORSOS",
        "SZALAI",
        "MAGYAR",
        "SIPOS",
        "LUKACS",
        "GULYAS",
        "BIRO",
        "KIRALY",
        "KATONA",
        "LASZLO",
        "JAKAB",
        "FAZEKAS",
        "SANDOR",
        "BOROS",
        "BOGDAN",
        "BALOG",
        "KELEMEN",
        "SOMOGYI",
        "ANTAL",
        "OROSZ",
        "VINCZE",
        "FULOP",
        "VERES",
        "VARADI",
        "HEGEDUS",
        "DEAK",
        "PAP",
        "BUDAI",
        "BALINT",
        "ILLES",
        "PAL",
        "VOROS",
        "BOGNAR",
        "VASS",
        "SZOKE",
        "LENGYEL",
        "FABIAN",
        "SZUCS",
        "BODNAR",
        "HALASZ",
        "HAJDU",
        "KOZMA",
        "MATE",
        "PASZTOR",
        "JONAS",
        "GASPAR",
        "SZEKELY",
        "BAKOS",
        "MAJOR",
        "DUDAS",
        "VIRAG",
        "HEGEDUS",
        "ORBAN",
        "NOVAK",
        "SOOS",
        "BARNA",
        "NEMES",
        "TAMAS",
        "PATAKI",
        "FARAGO",
        "BORBELY",
        "KEREKES",
        "SZEKERES",
        "BALLA",
        "BARTA",
        "CSONKA",
        "DOBOS",
        "PETER",
        "VEGH"
};
        #endregion

        #region FFIKeresztnevLista
        string[] FERFI_KERESZTNEV_LISTA = new string[] {
        "BENCE",
        "MATE",
        "LEVENTE",
        "ADAM",
        "DAVID",
        "BALAZS",
        "DOMINIK",
        "PETER",
        "GERGO",
        "MILAN",
        "TAMAS",
        "ZSOMBOR",
        "DANIEL",
        "BALINT",
        "BOTOND",
        "KRISTOF",
        "ZALAN",
        "ARON",
        "LASZLO",
        "MARK",
        "ATTILA",
        "ZOLTAN",
        "NOEL",
        "MARCELL",
        "ANDRAS",
        "BENEDEK",
        "AKOS",
        "BARNABAS",
        "GABOR",
        "ISTVAN",
        "OLIVER",
        "MARTON",
        "KRISZTIAN",
        "PATRIK",
        "ROLAND",
        "ZSOLT",
        "KEVIN",
        "JANOS",
        "SZABOLCS",
        "MARTIN",
        "CSABA",
        "HUNOR",
        "RICHARD",
        "BENETT",
        "GERGELY",
        "JOZSEF",
        "NORBERT",
        "NIMROD",
        "ROBERT",
        "SANDOR",
        "ALEX",
        "BENJAMIN",
        "ZETENY",
        "FERENC",
        "ERIK",
        "VIKTOR",
        "MATYAS",
        "ABEL",
        "BENDEGUZ",
        "KORNEL",
        "VINCE",
        "MIHALY",
        "NANDOR",
        "NIKOLASZ",
        "CSONGOR",
        "TIBOR",
        "RIKARDO",
        "ARMIN",
        "KRISZTOFER",
        "CSANAD",
        "ADRIAN",
        "MIKLOS",
        "BRENDON",
        "IMRE",
        "GYORGY",
        "BOLDIZSAR",
        "GYULA",
        "VILMOS",
        "SOMA",
        "SZEBASZTIAN",
        "KENDE",
        "SZILARD",
        "BERTALAN",
        "KAROLY",
        "DOMONKOS",
        "KOLOS",
        "BARNA",
        "LAJOS",
        "SIMON",
        "FLORIAN",
        "KOPPANY",
        "ZSIGMOND",
        "ALEXANDER",
        "DONAT",
        "GELLERT",
        "LORANT",
        "SEBESTYEN",
        "LORINC",
        "BULCSU",
        "SAMUEL"
};
        #endregion

        #region NoKeresztnevLista
        string[] NOI_KERESZTNEV_LISTA = new string[] {
        "LILI",
        "REKA",
        "DORA",
        "LUCA",
        "VIKTORIA",
        "EMMA",
        "VIVIEN",
        "LAURA",
        "ESZTER",
        "FANNI",
        "PETRA",
        "LILLA",
        "CSENGE",
        "NOEMI",
        "SARA",
        "DORINA",
        "GRETA",
        "ZOE",
        "DORKA",
        "REBEKA",
        "BIANKA",
        "LILIANA",
        "FLORA",
        "LENA",
        "PANNA",
        "ALEXANDRA",
        "REGINA",
        "LARA",
        "MAJA",
        "KAMILLA",
        "SZONJA",
        "FRUZSINA",
        "BARBARA",
        "VIRAG",
        "BLANKA",
        "KINGA",
        "RAMONA",
        "KITTI",
        "TIMEA",
        "JANKA",
        "KATA",
        "JULIA",
        "DOROTTYA",
        "EMESE",
        "VANESSZA",
        "ENIKO",
        "IZABELLA",
        "MIRA",
        "NIKOLETT",
        "LIZA",
        "VERONIKA",
        "TAMARA",
        "VANDA",
        "ALIZ",
        "EMILIA",
        "LILIEN",
        "KIRA",
        "PATRICIA",
        "ADRIENN",
        "AMANDA",
        "KRISZTINA",
        "BORBALA",
        "KIARA",
        "DZSENIFER",
        "LEILA",
        "KINCSO",
        "ZITA",
        "ADEL",
        "ZSELYKE",
        "HANGA",
        "DIANA",
        "NATALIA",
        "MELISSZA",
        "DALMA",
        "ABIGEL",
        "JOHANNA",
        "KATALIN",
        "AMIRA",
        "EVELIN",
        "BERNADETT",
        "VIOLA",
        "ELIZABET",
        "JULIANNA",
        "LIVIA",
        "ZSANETT",
        "LETICIA",
        "MIRA",
        "OLIVIA",
        "DZSESSZIKA",
        "TIFANI",
        "ALEXA",
        "BIBORKA",
        "ORSOLYA",
        "MERCEDESZ"
};
        #endregion

        #region VarosLista
        string[] VAROSOK_LISTAJA = new string[]{
        "Budapest",
        "Debrecen",
        "Szeged",
        "Miskolc",
        "Pecs",
        "Gyor",
        "Nyiregyhaza",
        "Kecskemet",
        "Szekesfehervar",
        "Szombathely",
        "Szolnok",
        "Tatabanya",
        "Kaposvar",
        "Erd",
        "Veszprem",
        "Bekescsaba",
        "Zalaegerszeg",
        "Sopron",
        "Eger",
        "Nagykanizsa",
        "Dunaujvaros",
        "Hodmezovasarhely",
        "Dunakeszi",
        "Cegled",
        "Baja",
        "Salgotarjan",
        "Szigetszentmiklos",
        "Vac",
        "Godollo",
        "Ozd",
        "Szekszard",
        "Mosonmagyarovar",
        "Gyongyos",
        "Papa",
        "Gyula",
        "Hajduboszormeny",
        "Esztergom",
        "Kiskunfelegyhaza",
        "Budaors",
        "Ajka",
        "Oroshaza",
        "Kazincbarcika",
        "Szentes",
        "Kiskunhalas",
        "Jaszbereny",
        "Szentendre",
        "Komlo",
        "Tata",
        "Nagykoros",
        "Siofok",
        "Mako",
        "Gyal",
        "Hajduszoboszlo",
        "Torokszentmiklos",
        "Vecses",
        "Keszthely",
        "Varpalota",
        "Dunaharaszti",
        "Hatvan",
        "Karcag",
        "Bekes",
        "Komarom",
        "Paks",
        "Dombovar",
        "Fot",
        "Szazhalombatta",
        "Oroszlany",
        "Mohacs",
        "God",
        "Monor",
        "Szigethalom",
        "Balmazujvaros",
        "Mezotur",
        "Pomaz",
        "Szarvas",
        "Hajdunanas",
        "Kalocsa",
        "Mateszalka",
        "Veresegyhaz",
        "Csongrad",
        "Dabas",
        "Gyomro",
        "Tiszaujvaros",
        "Mezokovesd",
        "Kisvarda",
        "Balassagyarmat",
        "Tapolca",
        "Pecel",
        "Satoraljaujhely",
        "Berettyoujfalu",
        "Abony",
        "Sarvar",
        "Puspokladany",
        "Budakeszi",
        "Kiskoros",
        "Mor",
        "Pilisvorosvar",
        "Bonyhad",
        "Gyomaendrod",
        "Torokbalint",
        "Balatonfured",
        "Hajdusamson",
        "Ujfeherto",
        "Biatorbagy",
        "Batonyterenye",
        "Sarospatak",
        "Nagykata",
        "Tiszavasvari",
        "Hajduhadhaz",
        "Sarbogard",
        "Albertirsa",
        "Koszeg",
        "Nyirbator",
        "Dorog",
        "Maglod",
        "Kistarcsa",
        "Sajoszentpeter",
        "Kiskunmajsa",
        "Kormend",
        "Bicske",
        "Marcali",
        "Pilis",
        "Ullo",
        "Isaszeg",
        "Barcs",
        "Kisujszallas",
        "Tolna",
        "Tiszakecske",
        "Tiszafoldvar",
        "Lajosmizse",
        "Mezobereny",
        "Celldomolk",
        "Szigetvar",
        "Nagyatad",
        "Tiszafured",
        "Csorna",
        "Budakalasz",
        "Heves",
        "Tokol",
        "Kapuvar",
        "Solymar",
        "Kerepes",
        "Rackeve",
        "Edeleny",
        "Sarkad"
};
        #endregion

        #region UserType,Email

        string[] USER_TYPE = new string[]
        {
            "Administrator","Manager","Student","Teacher"
        };
        string[] EMAIL_LIST = new string[]
        {
            "@gmail.com","@hotmail.com","@t-online.hu","@yahoo.com"
        };
        #endregion

        private Random rand = new Random();
       

       public Users GenerateUser()
        {
            var user = new Users();

            #region NameGenerator
            if (rand.Next() % 2 == 0) //Férfi név
            {
                user.FirstName = FERFI_KERESZTNEV_LISTA[rand.Next() % FERFI_KERESZTNEV_LISTA.Length];
                if (rand.Next() % 4 == 0)
                {
                    user.MiddleName = FERFI_KERESZTNEV_LISTA[rand.Next() % FERFI_KERESZTNEV_LISTA.Length];
                    if (user.FirstName == user.MiddleName)
                    {
                        user.MiddleName = FERFI_KERESZTNEV_LISTA[rand.Next() % FERFI_KERESZTNEV_LISTA.Length];
                    }
                }
            }
            else  //női név
            {
                user.FirstName = NOI_KERESZTNEV_LISTA[rand.Next() % NOI_KERESZTNEV_LISTA.Length];
                if (rand.Next() % 4 == 0)
                {
                    user.MiddleName = NOI_KERESZTNEV_LISTA[rand.Next() % NOI_KERESZTNEV_LISTA.Length];
                    if (user.FirstName == user.MiddleName)
                    {
                        user.MiddleName = NOI_KERESZTNEV_LISTA[rand.Next() % NOI_KERESZTNEV_LISTA.Length];
                    }
                }
            }
            user.LastName = VEZETEK_NEV_LISTA[rand.Next() % VEZETEK_NEV_LISTA.Length];
            #endregion
            user.InsertDate = DateTime.Now;
            user.ModifyDate = DateTime.Now;
            user.ModifiedBy = Singleton.Instance.ID;
            user.EduId = EduIdGenerator();
            user.Password = GeneratePassword(rand.Next(5,9));
            user.Active = true;
            user.UserType = GenerateUserType();
            user.MothersName = MotherNameGenerator();
            user.BirthDate = BirthDateGenerator();
            user.BirthPlace = GenerateBirthPlace();
            user.Nationality = "Hungarian";
            user.PersonalId = PersonlIdCardNoGenerator();
            user.MedicalCardId = MedicalIdGenerator().ToString();
            user.EduCardId = StudentCardNoGenerator().ToString();
            user.Email = GenerateEmail(user.FirstName,user.LastName);
            return user;
        }
         string EduIdGenerator(int length = 6)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }

         string GeneratePassword(int passwordLength = 8)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, passwordLength)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }

         int MedicalIdGenerator()
        {
            return rand.Next(100000000, 999999999);
        }

         string PersonlIdCardNoGenerator()
        {

            StringBuilder builder = new StringBuilder();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char ch;
            builder.Append(rand.Next(100000, 999999));
            for (int i = 0; i < 2; i++)
            {
                ch = chars[rand.Next() % chars.Length];
                builder.Append(ch);
            }
            return builder.ToString();
        }

         string MotherNameGenerator()
        {
            return NOI_KERESZTNEV_LISTA[rand.Next() % NOI_KERESZTNEV_LISTA.Length] + " " + VEZETEK_NEV_LISTA[rand.Next() % NOI_KERESZTNEV_LISTA.Length];
        }

         DateTime BirthDateGenerator()
        {
            DateTime from = new DateTime(1980, 1, 1);
            DateTime to = new DateTime(1996, 1, 1);
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(rand.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }

         string GenerateBirthPlace()
        {
            return VAROSOK_LISTAJA[rand.Next() % VAROSOK_LISTAJA.Length];
        }

         string GenerateEmail(string firstname, string lastname)
        {
            if (rand.Next() % 2 == 0)
            {
                return (firstname + "." + lastname + EMAIL_LIST[rand.Next() % EMAIL_LIST.Length]).ToLower();
            }
            else
            {
                return (firstname + (rand.Next() % 500).ToString() + EMAIL_LIST[rand.Next() % EMAIL_LIST.Length]).ToLower();
            }
        }

         long StudentCardNoGenerator()
        {
            long id = 10000000000;
            while (id < 99999999999)
            {
                id += rand.Next();
            }
            return id;
        }

         string GenerateUserType()
        {
            return USER_TYPE[rand.Next() % USER_TYPE.Length];
        }
    }

}
