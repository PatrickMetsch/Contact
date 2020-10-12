using System;
namespace Contact.Models
{
    public class ContactInfo
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }

        public ContactInfo(string ph, string em, string fb)
        {
            this.Phone = ph;
            this.Email = em;
            this.Facebook = fb;
        }
    }
}
