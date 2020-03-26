using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CovidApp.Data;

namespace CovidApp.Models
{
    public class AccessionRecord
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AccessionNumber { get; set; }
        public int AccessionVersion { get; set; }
        [Required]
        public string Country { get; set; }
        public string Region { get; set; }
        [NotMapped]
        public Coords Coordinates
        {
            get
            {
                return CountryCoordinates.countries[Country]; // Requires access to a static class, hmmm
            }
        }
        public string CollectionDate { get; set; } // The getter will do a DateTime.TryParse()
        public string Orf1abSequence { get; set; }
        [NotMapped]
        public int Orf1abLength
        {
            get
            {
                return Orf1abSequence.Length;
            }
        }
        public string SurfaceGlycoproteinSequence { get; set; }
        [NotMapped]
        public int SurfaceGlycoproteinLength
        {
            get
            {
                return SurfaceGlycoproteinSequence.Length;
            }
        }

        public string Orf3aSequence { get; set; }
        [NotMapped]
        public int Orf3aLength
        {
            get
            {
                return Orf3aSequence.Length;
            }
        }
    }

    public struct Coords
    {
        public double longitude;
        public double latitude;
        
        public Coords(double longitude, double latitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;           
        }
    }
}
