using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4_Thomas_Morris
{
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;

        public DatingProfile (string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }

        public void WriteBio(string text)
        {
            bio = text;
        }

        public void AddToInbox(Messages message)
        {
            myMessages.Add(message);
        }

        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if(message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile toProfile)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            toProfile.AddToInbox(message);
        }
    }
}
