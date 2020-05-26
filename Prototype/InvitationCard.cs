using System;

namespace Prototype
{
    public class InvitationCard
    {
        public string To { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Sender { get; set; }
        public DateTime Date { get; set; }
        
        public InvitationCard Clone(InvitationCard invitationCard){
            return (InvitationCard)this.MemberwiseClone();
        }
    }
}