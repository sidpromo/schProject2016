using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Common
{
    class SubjectGenerator
    {
        #region TargyakListaja
        string[] TARGYAK_LISTAJA = new string[] {
        "Aramkorok es jelfeldolgozas",
        "Digitalis technika I.",
        "Elektronika II.",
        "Mikroelektronika",
        "Mozgasszabalyozas",
        "Mozgasszabalyozas",
        "Robotiranyitas",
        "Vilagitastechnika",
        "Digitalis technika II.",
        "Elektronika I.",
        "Elektronika-mechatronika",
        "Mozgasszabalyozas",
        "Robotiranyitas",
        "Teljesitmenyelektronika",
        "Villamos berendezesek",
        "Elektrotechnika alapjai",
        "Villamos gepek, meresek",
        "Elektrotechnika I.",
        "Elektrotechnika II.",
        "Elektrotechnika II.",
        "Elektrotechnika",
        "Automatikai alapismeretek",
        "Analog Informatics I (Part 1)",
        "Analog Informatics II (Part 2)",
        "Digital Informatics I.",
        "Digital Informatics II.",
        "Power Electronics & Motion Control I.",
        "Power Electronics & Motion Control II.",
        "Integrating Project I.",
        "Integrating Project II.",
        "Laboratory",
        "Software Informatics",
        "Programozas I.",
        "Programozas II.",
        "Elektronika I.",
        "Elektronika II.",
        "Digitalis technika 1.",
        "Digitalis technika 2.",
        "Programtervezes",
        "Informatika II.",
        "Informatika I.",
        "Informatika II.",
        "Szabalyozastechnika",
        "Elektronika III.",
        "Elektronikus atalakitok",
        "Szoftver-technika",
        "Szabalyozastechnika",
        "Iranyitastechnika",
        "Iranyitastechnika",
        "A robotiranyitas rendszertechnikaja",
        "Interfesztechnika",
        "Szamitastechnikai laboratorium II.",
        "Atalakito kapcsolasok es villamos hajtasok",
        "Teljesitmenyelektronikai berendezesek",
        "Rendszertechnikai laboratorium I.",
        "Onallo laboratorium",
        "Interfesztechnika",
        "Szoftver eszkozok",
        "Automatika",
        "Laboratorium I. (Alkalmazott informatika)",
        "Szamitogepes grafika",
        "Parhuzamos es valosideju rendszerek",
        "Szoftver-technikak",
        "Informacio-megjelenites",
        "Szoftver-technikak es informacio-megjelenites laboratorium",
        "Onallo laboratorium",
        "Elosztott rendszerek",
        "Elosztott rendszerek laboratorium",
        "Multimedia-rendszerek",
        "Rendszertechnikai laboratorium II.",
        "Onallo laboratorium",
        "Mediatechnika",
        "Laboratorium II. (Alkalmazott informatika)",
        "Elettani szabalyozasok",
        "Diplomatervezes",
        "Orvosi kepfeldolgozas",
        "Onallo laboratorium",
        "Hipermedia alkalmazasok",
        "Hipermedia alkalmazasok laboratorium",
        "Diplomatervezes",
        "Integralt informacios rendszerek",
        "Integralt informacios rendszerek laboratorium",
        "Elektromechanika",
        "Programozhato aramkorok",
        "Internet laboratorium",
        "Programozas",
        "A programozas alapjai 2",
        "Informatika 2.",
        "Szoftvertechnikak",
        "Elektronika 2",
        "Szabalyozastechnika",
        "Mikrokontroller alapu rendszerek",
        "Mikrokontroller laboratorium",
        "Onallo labor",
        "Adatvezerelt alkalmazasok fejlesztese",
        "Informatikai technologiak laboratorium 1",
        "Onallo labor",
        "Szakdolgozat",
        "Szakdolgozat",
        "Informatikai technologiak laboratorium 2",
        "Szakmai gyakorlat",
        "Szakmai gyakorlat",
        "Android alapu szoftverfejlesztes",
        "Windows Phone 7 alapu szofterfejlesztes",
        "Szorakoztato elektronikai eszkozok programozasa",
        "Szamitasi felho alapu szoftverfejlesztes",
        "Webfejlesztes tobb platformon – az egyedi fejlesztestol a testreszabasig",
        "Felhasznaloi feluletek ergonomiaja",
        "Windows Store alkalmazasok fejlesztese",
        "Algoritmusok es adatstrukturak tobbmagos kornyezetben",
        "iOS alapu szoftverfejlesztes",
        "Windows Phone alapu szoftverfejlesztes",
        "Agilis szoftverfejlesztes",
        "Alkalmazasfejlesztes vekony kliens technologiakkal",
        "Elektronikus atalakitok",
        "Symbian alapu szoftverfejlesztes",
        "Bevezetes a mobil szoftverfejlesztesbe",
        "Az ujgeneracios .NET platform",
        "Adatbaziskezeles a gyakorlatban",
        "Mobil LINUX alkalmazasok",
        "Teljesitmeny-atalakitok iranyitasa",
        "Uzleti intelligencia alapu rendszerek",
        "Java alapu webes keretrendszerek",
        "Predikcios algoritmusok linearis es nemlinearis szakaszok iranyitasara",
        "Aramkorok es jelfeldolgozasok",
        "Elektronika I.",
        "Mikroszamitogepek",
        "Teljesitmenyelektronika",
        "Elektrotechnika I.",
        "Elektrotechnika II.",
        "Adaptiv rendszerek",
        "Szoftver architekturak",
        "Elektrotechnika I.",
        "Elektrotechnika II.",
        "Elektronika I.",
        "Elektronika II.",
        "Elektronika II.",
        "Informatika I.",
        "Informatika II.",
        "Informatika II.",
        "Napelemes rendszerek",
        "Jatekfejlesztes .NET platformon",
        "Kapcsolouzemu tapegysegek",
        "Elektronikus tapegysegek",
        "A szamitogepes grafika alapjai",
        "Szoftverfejlesztes J2EE platformon",
        "Szoftverfejlesztes .NET platformon",
        "A WEB programozasa",
        "Grafikai es animacios eszkozok",
        "Korszeru operacios rendszerek",
        "Adatbazis-kezelo rendszerek",
        "LINUX programozas",
        "Adatbazisok szerver oldali programozasa",
        "LINUX alapu halozatok",
        "Webportalok fejlesztese",
        "Elektronika",
        "Teljesitmenyelektronika",
        "Motion Control",
        "Analog elektronika",
        "Digitalis elektronika",
        "Programozhato digitalis eszkozok",
        "WEB alapu laboratorium",
        "Ipari beagyazott rendszerek",
        "Valogatott fejezetek az elektrotechnikabol",
        "Elektromagneses terek",
        "Teljesitmenyelektronika II.",
        "Digitalis szervohajtasok",
        "Rendszer es alkalmazastechnika labor mechatronikusoknak",
        "Onallo laboratorium mechatronikusoknak",
        "Diplomatervezes A",
        "Diplomatervezes B",
        "Web technologiak",
        "Penzugyi szoftver technologiak",
        "Szoftverarchitekturak",
        "Elosztott rendszerek",
        "Mobilszoftverek",
        "Modellvezerelt paradigmak",
        "Interfesztechnika",
        "Valosideju rendszerek",
        "Nagyteljesitmenyu mikroprocesszoros rendszerek",
        "Penzugyi szoftver technologiak",
        "Szolgaltatasorientalt rendszerek",
        "Intergralt informacios rendszerek",
        "Eloszott rendszerek es mobilszoftverek laboratorium",
        "Kliensalkalmazasok fejlesztese",
        "Robotiranyitas rendszertechnikaja",
        "Rendszer es alkalmazastechnika labor I.",
        "Folyamatmenedzsment megoldasok SOA kornyezetben",
        "Szolgaltatasorientalt es modellvezerelt paradigmak laboratorium",
        "Rendszer es alkalmazastechnika labor II.",
        "Onallo laboratorium 1",
        "Onallo laboratorium 2",
        "Diplomatervezes 1",
        "Diplomatervezes 2",
        "Onallo laboratorium 1",
        "Onallo laboratorium 2",
        "Diplomatervezes 1",
        "Diplomatervezes 2"
        };
        #endregion

        Random rand = new Random();
        string GenerateSubjName()
        {
            return TARGYAK_LISTAJA[rand.Next() % TARGYAK_LISTAJA.Length];
        }
        string GenerateSubjCode()
        {
            StringBuilder sb = new StringBuilder();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            sb.Append("EDU");
            char ch;
            for (int i = 0; i < 4; i++)
            {
                ch = chars[rand.Next() % chars.Length];
                sb.Append(ch);
            }
            return sb.ToString();
        }

        public Subjects GenerateSubject()
        {
            Subjects subj = new Subjects();
            Teachers teacher = new Teachers();
            ServiceClient client = new ServiceClient();

            subj.SubjectName = GenerateSubjName();
            subj.SubjectCode = GenerateSubjCode();
            subj.Credits = (byte)rand.Next(3, 10);
            //subj.Id = rand.Next(40,50);

            return subj;          
        }
    }
}
