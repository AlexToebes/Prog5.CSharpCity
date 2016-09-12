using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCity.Models
{
    public class Thief
    {
        public Bank bank { get; set; }

        //1. We moeten door de poort met tralies
        public void OpenGate()
        {
            bank.Gate.Sleutelgat = bank.Guard.key;
            
            //bank.Guard;
            //bank.Gate.Sleutelgat
        }

        //2. Verzin een manier om de Kluis open te maken
        public void OpenVault()
        {
            //bank.Vault

            bank.Vault.IsOpen = true;
        }

        //3. Verzin een manier om de lazors uit te schakelen
        public void DodgeLazors()
        {
            //bank.Lazors

            foreach (Lazor lazor in bank.Lazors.Where(lazor => lazor.Active)) {
                lazor.Active = false;
            };
        }

        //4. Er is 1 kluisje met daarin juwel die ultra veel waard zijn. Hoe kom je er achter welke?
        public void FindAndOpenSafe()
        {
            //bank.SafeList

            bank.SafeList.OrderBy(safe => safe.Money).First().OpenSafe();
        }

    }
}
