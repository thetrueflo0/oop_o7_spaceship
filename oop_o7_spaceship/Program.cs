namespace oop_o7_spaceship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Land USA = new Land();
            USA.Name = "United States of America";
            USA.Hauptstadt = "Washington DC";
            USA.Einwohner = 332800000;
            USA.ISO3 = "USA";

            Land China = new Land();
            China.Name = "China Volksrepublik";
            China.Hauptstadt = "Peking";
            China.Einwohner = 1436600000;
            China.ISO3 = "CHN";

            Land UdSSR = new Land();
            UdSSR.Name = "Sovjietunion";
            UdSSR.Hauptstadt = "Moskau";
            UdSSR.Einwohner = 290100023;
            UdSSR.ISO3 = "SUN";

            Land Indien =  new Land();
            Indien.Name = "Indien";
            Indien.Hauptstadt = "New-Dehli";
            Indien.Einwohner = 1428627663;
            Indien.ISO3 = "IND";



            Spaceship mercury = new Spaceship();
            mercury.BemanterErstflug = 1961;
            mercury.Treagerrakete = "Redstone" + "Atlas";
            mercury.Programm = "Mercury";
            mercury.BesatzungBis = 1;
            mercury.EinsatzVon = 1959;
            mercury.EinsatzBis = 1963;
            mercury.Einsatzdauer = (mercury.EinsatzBis - mercury.EinsatzVon);
            mercury.Herkunftsland = USA.Name;
            int mercuryEinsatzdauer = mercury.EinsatzBis - mercury.EinsatzVon;
            mercury.Einsatzdauer = mercuryEinsatzdauer;

            Spaceship Sojus = new Spaceship();
            Sojus.BemanterErstflug = 1967;
            Sojus.Treagerrakete = "Sojus";
            Sojus.Programm = "Sojus";
            Sojus.BesatzungBis = 3;
            Sojus.EinsatzVon = 1966;
            Sojus.EinsatzBis = 1967;
            Sojus.Herkunftsland = UdSSR.Name;

            Spaceship shenzhou = new Spaceship();
            shenzhou.BemanterErstflug = 2003;
            shenzhou.Treagerrakete = "CZ-2F";
            shenzhou.Programm = "Shenzhou";
            shenzhou.BesatzungBis = 3;
            shenzhou.EinsatzVon = 1999;
            shenzhou.EinsatzBis = 2023;
            shenzhou.Herkunftsland = China.Name;

            Spaceship gaganyaan = new Spaceship();
            gaganyaan.BemanterErstflug = 2025;
            gaganyaan.Treagerrakete = "LVM3";
            gaganyaan.Programm = "Gaganyaan";
            gaganyaan.BesatzungBis = 3;
            gaganyaan.EinsatzVon = 2024;
            gaganyaan.EinsatzBis = 0;
            gaganyaan.Herkunftsland = Indien.Name;

            Console.WriteLine(mercury.Programm +  mercury.Treagerrakete + mercury.Herkunftsland);
            Console.WriteLine();
            
            Console.WriteLine($"Der Name des Raumfahrtprogramm lautet: {mercury.Einsatzdauer}, die Trägerrakete ist: {Sojus.Treagerrakete}, und das Herkunftsland ist {UdSSR.Name}");
        }
    }
}