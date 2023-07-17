using Microsoft.AspNet.Identity.EntityFramework;
using Stonks.Model.Entities;
using System;
using System.Collections.Generic;
using System.Web;

namespace Stonks.Model
{
    public class ChatRoom
    {
        Guid ChatRoomId { get; set; }

        public string ChatRoomName { get; set; }
        
        public string ChatRoomDescription { get; set;}

        public List<Message> Messages { get; set;}

        public IdentityUser Owner { get; set; }

        public List<IdentityUser> Members { get; set; }
    
    }
}
