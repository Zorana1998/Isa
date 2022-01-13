using IsaProject.Models.Entities;
using IsaProject.Models.Entities.Ship;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


    namespace IsaProject.Models
    {
        public class Ship : Entity
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
