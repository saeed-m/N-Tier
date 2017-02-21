using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using DomainClasses.Entities;
using Newtonsoft.Json;
using ServiceLayer.EFService;

namespace ApiLayer.Controllers
{
    public class OrganizationController : ApiController
    {
       

        Organization[] organizations =new Organization[]
        {
            new Organization {Id = 1,Name = "Unit number One",Desc = "Unit Number One"},
            new Organization {Id = 2,Name = "Unit Number Two",Desc = "Unit Number Two"},
        };
        [JsonOutput]
        public IEnumerable<Organization> GetAllOrganizations()
        {
            //var org = new OrganizagionService();
            //var  sigleOrg= new Organization();
            //var orgList=new List<Organization>();
            //foreach (var organization in org.GetAll())
            //{
            //    sigleOrg.Id = organization.Id;
            //    sigleOrg.Name = organization.Name;
            //    sigleOrg.Desc = organization.Desc;
            //    orgList.Add(sigleOrg);
            //}
            //For Demo Perpose
            return organizations;
            
        }
        //public Organization GetOrganization(int id)
        //{
        //    //var org = new OrganizagionService();
        //    //Organization item = org.GetOrganization(id);
        //    //var sigleOrg = new Organization();
        //    //sigleOrg.Id = item.Id;
        //    //sigleOrg.Name = item.Name;
        //    //sigleOrg.Desc = item.Desc;
        //    //if (item == null)
        //    //{
        //    //    throw new HttpResponseException(HttpStatusCode.NotFound);
        //    //}
        //    //return organizations.Where(o=>o.Id==id);
        //}
    }
}
