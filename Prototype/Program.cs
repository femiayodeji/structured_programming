using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROTOTYPE DESIGN PATTERN\n");

            InvitationCard invitationCard = new InvitationCard();
            //first object
            invitationCard.Sender = "Femi";
            invitationCard.Title = "Collaboration Invitation";
            invitationCard.Content = "Hi guys! You are welcome to join me in learning software design pattern.";
            invitationCard.To = "Femi";
            invitationCard.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            InvitationCard[] guests = new InvitationCard[3];
            string[] guestsName = {"Dami","Kwaku","Atoke"};
            int i = 0;
            foreach(string name in guestsName){
                guests[i] = invitationCard.Clone(invitationCard);
                guests[i].To = guestsName[i];
                i++;
            }

            // Print all invitation card 
            foreach(InvitationCard guest in guests){
                Console.WriteLine("To: {0}",guest.To);
                Console.WriteLine("Title: {0}",guest.Title);
                Console.WriteLine("Content: {0}",guest.Content);
                Console.WriteLine("Date: {0}",guest.Date);
                Console.WriteLine("--------");               
            }
        }
    }
}
