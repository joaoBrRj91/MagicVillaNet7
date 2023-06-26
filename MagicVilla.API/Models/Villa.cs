using System;
namespace MagicVilla.API.Models
{
    public class Villa
    {
        public Villa(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CodVilla = GeneratedCodVilla();
            CreatedDate = DateTime.Now;
        }

        protected Villa()
        {

        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? CodVilla { get; set; }
        public DateTime CreatedDate { get; set; }

        private string GeneratedCodVilla()
        {
            var randomCodVilla = $"{Name!.ToUpper()}-{new Random().NextInt64()}";
            return randomCodVilla!;
        }
    }
}

