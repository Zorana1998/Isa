using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IsaProject.Models.Entities.Adventure
{
    public class Adventure : Entity
    {
        public string InstructorDescription { get; set; }
        public string FishingEquipment { get; set; }

        /*Instruktor pecanja može da uređuje profil usluge koji sadrži:
● naziv,
● adresu gde se održava(dodatno prikaz lokacije korišćenjem mapa),
● promotivni opis,
● kratku biografiju instruktora,
● slike ambijenta prethodnih druženja,
● maksimalni broj osoba,
//● slobodne termine sa akcijama za brzu rezervaciju,
● pravila ponašanja(šta je dozvoljeno, a šta ne),
● koja pecaroška oprema dolazi uz rezervaciju(ako klijent ne ponese svoju),
//● cenovnik i informacije o dodatnim uslugama,
//● uslovi otkaza rezervacije(besplatno ili instruktor zadržava procenat
uplate).*/
    }
}

