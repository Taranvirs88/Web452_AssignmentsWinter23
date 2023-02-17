using System;
using System.ComponentModel.DataAnnotations;

namespace Rulers.Models
{
    public class Ruler
    {
        public int Id { get; set; }
        public string RulerTypes { get; set; }

        public string Colour { get; set; }
        public string RulerShape { get; set; }
        public string Material { get; set; }
        public decimal MeasurementSystem { get; set; }

        public decimal Price { get; set; }
        public int Rating  { get; set; }
    }
}