﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Models
{
    public class Message
    {
        public Message() { }
        public Message(string text, User user, Chat chat) 
        {
            Id = Guid.NewGuid();
            Text = text;
            SendDate = DateTime.Now;
            User = user;
            Chat = chat;
            IsDeleted = false;
        }

        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime SendDate { get; set; }

        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public User User { get; set; } = null;
        public Chat Chat { get; set; } = null;
        public bool IsDeleted { get; set; }








    }
}
