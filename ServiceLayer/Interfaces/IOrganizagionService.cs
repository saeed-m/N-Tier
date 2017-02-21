using System.Collections.Generic;
using DomainClasses.Entities;

namespace ServiceLayer.Interfaces
{
    /// <summary>
    /// Interface to manage Organization Data
    /// </summary>
    interface IOrganizagionService

   {
        /// <summary>
        /// Add an organization 
        /// </summary>
        /// <param name="organization">Organization</param>
       void Add(Organization organization);
        /// <summary>
        /// Remove Organization From the Existings
        /// </summary>
        /// <param name="id">Organization Id</param>
       void Remove(int id);
        /// <summary>
        /// Update Organization Data 
        /// </summary>
        /// <param name="organization">Organization</param>
       void Update(Organization organization);
        /// <summary>
        /// Get Single Organization by Identifier
        /// </summary>
        /// <param name="id">Organization Id</param>
        /// <returns>Single Organization Data</returns>
       Organization GetOrganization(int id);
        /// <summary>
        /// Get All Organization Stored id db 
        /// </summary>
        /// <returns>List Of Organizations</returns>
       IEnumerable<Organization> GetAll();



   }
}
