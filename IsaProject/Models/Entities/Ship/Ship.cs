using IsaProject.Models.Entities.Ship;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IsaProject.Models.Entities.Users
{
    public class Ship: Entity
    {
        
        [Required]
        public string Type { get; set; }
        [Required]
        public double Length { get; set; }
        [Required]
        public double EngineNumber { get; set; }
        public double EnginePower { get; set; }
        public double MaxSpeed { get; set; }
        public List<NavigationEquipment> NavigationEquipments { get; set; }

        public int Capacity { get; set; }

        public string FishingEquipment { get; set; }

    }
}

/*Vlasnik broda/čamca može da uređuje profil broda/čamca koji sadrži:
● naziv, tip, dužinu, broj motora, snagu motora, maksimalnu brzinu,
● navigacionu opremu (GPS, radar, VHF radio, fishfinder),
● adresu gde se nalazi (dodatno prikaz lokacije korišćenjem mapa),
● promotivni opis,
● slike eksterijera i enterijera (ako ima kabinu),
● kapacitet,
//● slobodne termine sa akcijama za brzu rezervaciju,
● pravila ponašanja (šta je dozvoljeno, a šta ne),
● koja pecaroška oprema dolazi uz rezervaciju (ako je ima),
//● cenovnik i informacije o dodatnim uslugama,
//● uslovi otkaza rezervacije (besplatno ili vlasnik zadržava procenat uplate).*/