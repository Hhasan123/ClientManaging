using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManaging
{
    class ClientManager
    {
        public void Add(Clients client)
        {
            Console.WriteLine("Client Added: " +client.name);
        }
        public void List(Clients[] clients)
        {
            foreach (Clients client in clients)
            {
                Console.WriteLine(client.name);
            }
        }
        public void Update(Clients client)
        {
            Console.WriteLine("Client Updated: "+ client.name);
        }
        public void Delete(Clients clients)
        {
            Console.WriteLine("Client Deleted");
        }
    }
}
