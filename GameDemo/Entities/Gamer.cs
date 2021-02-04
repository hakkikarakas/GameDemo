using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int CreditCardNumber { get; set; }
        public string Username { get; set; }

    }
}
