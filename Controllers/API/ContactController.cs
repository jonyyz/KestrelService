using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using KestrelService.Models;

namespace KestrelService.Controllers.API
{
    /// <summary>
    /// Contact Controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/contacts")]
    public class ContactController
    {
        /// <summary>
        /// Static contacts data for testing
        /// </summary>
        protected static IEnumerable<Contact> Contacts = new List<Contact>()
        {
            new Contact { Id="1", Name="Chuck Jones" },
            new Contact { Id="2", Name="Daffy Duck" },
            new Contact { Id="3", Name="Bugs Bunny" },
            new Contact { Id="4", Name="Wile E. Coyote" },
        };

        /// <summary>
        /// Gets all the contacts
        /// </summary>
        /// <returns>All contacts</returns>
        [HttpGet]
        public IEnumerable<Contact> GetAllContacts() => ContactController.Contacts;

        /// <summary>
        /// Gets the contact or returns 404 if not found
        /// </summary>
        /// <param name="id">The unique identifier of the contact</param>
        /// <returns>The contact action result</returns>
        [Route("{id?}")]
        [HttpGet]
        public ActionResult<Contact> GetContact(string id)
        {
            var contact = ContactController.Contacts.FirstOrDefault(c => c.Id == id);

            if(contact == null)
            {
                return new NotFoundResult();
            }

            return contact;
        }
    }
}
