using ExploreOOP.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP.PersistenceLayer
{
    public class LineOfCreditAccountRepositoryMoked : ILineOfCreditAccountRepository
    {
        static List<LineOfCreditAccount> s_List = new List<LineOfCreditAccount>();

        public LineOfCreditAccountRepositoryMoked()
        {
            s_List.Add(new LineOfCreditAccount("Cuenta 1",10,0));
            s_List.Add(new LineOfCreditAccount("Cuenta 2", 10, 0));
            s_List.Add(new LineOfCreditAccount("Cuenta 3", 10, 0));
        }
        public void Add(LineOfCreditAccount lineOfCreditAccount)
        {
            s_List.Add(lineOfCreditAccount);
        }

        public void Delete(int id)
        {
            string idDelete = id.ToString();

            var account = s_List.FirstOrDefault(account => account.Number == idDelete);

            if (account != null)
            {
                Console.WriteLine($"Cuenta con ID {idDelete} encontrada.");
                s_List.Remove(account);
            }
            else
            {
                throw new ArgumentException($"No se encontró ninguna cuenta con ID {idDelete}.");
            }
        }

        public LineOfCreditAccount Get(int id)
        {
            string idGet = id.ToString();

            var account = s_List.FirstOrDefault(account => account.Number == idGet);

            if (account != null)
            {
                Console.WriteLine($"Cuenta con ID {idGet} encontrada.");
                return account;
            }
            else
            {
                throw new ArgumentException($"No se encontró ninguna cuenta con ID {idGet}.");
            }
        }

        public List<LineOfCreditAccount> GetAll()
        {
            return s_List;
        }
    }
}
