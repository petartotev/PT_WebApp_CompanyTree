using System;

namespace CompanyTree.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsBoardMember { get; set; }
        public int RoleId { get; set; }
        public int TeamId { get; set; }
    }
}
