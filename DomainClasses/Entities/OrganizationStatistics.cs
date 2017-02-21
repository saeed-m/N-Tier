using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Entities
{
   public class OrganizationStatistics
   {
       
        [Key]
       public int Id { get; set; }

       public int Org_Id { get; set; }
       public DateTime Submitdate { get; set; }
       public string Title { get; set; }
       public int StatNumber { get; set; }
       public virtual Organization Organization { get; set; }








    }
}
