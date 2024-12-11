using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class User : IdItem
    {
        [DataMember]
        public virtual string Username { get; set; }
        [DataMember]
        public virtual string Password { get; set; }
        [DataMember]
        public virtual string Email { get; set; }
        [DataMember]
        public virtual bool IsAdmin { get; set; }
        [DataMember]
        public virtual bool IsBan { get; set; } = false;

        public User(string username, string password, string email, bool isAdmin) 
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.IsAdmin = isAdmin;
            var now = DateTime.Now;
            this.CreatedAt = now;
            this.UpdatedAt = now;
        }
    }
}
