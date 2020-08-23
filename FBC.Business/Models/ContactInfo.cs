using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBC.Business.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
         
        /// <summary>
        /// this should be a family member name
        /// </summary>
        [MaxLength(100)]
        public string Owner { get; set;}

        private Type Type { get; set; }

        [MaxLength(1000)]
        public string Value { get; set; }

        // foreign keys
        public int FamilyId { get; set; }
        [ForeignKey("FamilyId")] public Family Family { get; set; }

        public void SetType(string type)
        {
            var isValidType = Enum.TryParse(type, out Type result);
            if (isValidType)
                Type = result;
            else
            {
                throw new InvalidOperationException();
            }
        }

        public new string GetType()
        {
            return Type.ToString();
        }
    }

    public enum Type
    {
        Address = 1,
        Email = 2,
        Phone = 3
    }
}


