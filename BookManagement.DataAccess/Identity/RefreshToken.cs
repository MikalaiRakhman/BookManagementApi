﻿using BookManagement.Models.Entities;

namespace BookManagement.DataAccess.Identity
{
    public class RefreshToken
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
