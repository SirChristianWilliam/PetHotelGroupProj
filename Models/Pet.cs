using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType {
        Shephard,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }
    public enum PetColorType {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }



    public class Pet {

        public int id {get; set;}

        public string name {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType breed {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType color {get; set;}

        public bool checkedin {get; set;}

        [ForeignKey("ownedby")]
        public int ownedbyId {get; set;}

        public PetOwner ownedby {get; set;}


    }
}
