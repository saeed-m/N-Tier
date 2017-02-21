using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Entities;
using ServiceLayer.Interfaces;
using DataLayer;

namespace ServiceLayer.EFService
{
   public class OrganizagionService : IOrganizagionService
    {
        public void Add(Organization organization)
        {
            using (var db = new dbContext())
            {
                db.Organizations.Add(organization);
                db.SaveChanges();

            }
            
        }



        public IEnumerable<Organization> GetAll()
        {
            using (var db = new dbContext())
            {

               return db.Organizations.ToList();
               

            }
        }

        public Organization GetOrganization(int id)
        {
            using (var db = new dbContext())
            {

                return db.Organizations.First(o => o.Id.Equals(id));
            }

        }

        public void Remove(int id)
        {
            using (var db = new dbContext())
            {

                var ItemToRemove = db.Organizations.First(o => o.Id.Equals(id));
                if (ItemToRemove != null)
                {
                    db.Organizations.Remove(ItemToRemove);
                    db.SaveChanges();
                }
            }
        }

        public void Update(Organization organization)
        {
            using (var db = new dbContext())
            {

                var ItemToUpdate = db.Organizations.First(o => o.Id.Equals(organization.Id));
                if (ItemToUpdate != null)
                {
                    ItemToUpdate.Desc = organization.Desc;
                    ItemToUpdate.Name = organization.Name;
                    db.SaveChanges();
                }
            }
        }
    }
}
