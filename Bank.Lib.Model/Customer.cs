using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank.Lib.Model
{
    public class Customer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public ICollection<Account> Accounts { get; set; }
               
    }

}
