using System;

namespace ClientManaging
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients client = new Clients();
            client.name = "Client0";

            ClientManager clientManager = new ClientManager();
            clientManager.Add(client);
            clientManager.Update(client);
            clientManager.Delete(client);

        }
    }
}
