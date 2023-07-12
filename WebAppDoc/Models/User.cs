using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppDoc.Models
{
    public class Choice
    {
        [Key]
        public int choiceid {  get; set; }
        public DateTime DateTime { get; set; }
        public string jour { get; set; }
        public string Description { get; set; }
   
        public int userid { get; set; }
        public Medoc Medoc { get; set; }


        

        
    }
}
