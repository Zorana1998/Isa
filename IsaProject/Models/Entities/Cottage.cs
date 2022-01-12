using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IsaProject.Models.Entities
{
    public class Cottage: Entity
    { 
        public List<Room> Rooms { get; set; }
    }

    /*Vlasnik vikendice može da uređuje profil vikendice koji sadrži:
● naziv,
● adresu (dodatno prikaz lokacije korišćenjem mapa),
● promotivni opis,
● slike eksterijera i enterijera,
● broj soba, broj kreveta po sobi,
//● slobodne termine sa akcijama za brzu rezervaciju,
● pravila ponašanja (šta je dozvoljeno, a šta ne),
//● cenovnik i informacije o dodatnim uslugama.
*/
}
