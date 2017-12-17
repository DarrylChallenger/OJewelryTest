using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OJewelryTest.Models
{
    public class NewClientModel 
    {
        [Key] public int Id { get; set; }
        public String ClientName { get; set; }
        public String ClientPhone { get; set; }
        public String ClientEmail { get; set; }
        public String CompanyName { get; set; }

        public NewClientModel()
        {
            ClientName = "";
            ClientPhone = "";
            ClientEmail = "";
            CompanyName = "";
        }
        /*public NewClientModel(String ClientName, String ClientPhone, String ClientEmail, String CompanyName, String CollectionName)
        {
            clientName =  ClientName;
            clientPhone = ClientPhone;
            clientEmail = ClientEmail;
            companyName = CompanyName;
            collectionName = CollectionName;
            companyId = -1;
        }*/
        public NewClientModel(String ClientName, String ClientPhone, String ClientEmail, String CompanyName)
        {
            this.ClientName = ClientName;
            this.ClientPhone = ClientPhone;
            this.ClientEmail = ClientEmail;
            this.CompanyName = CompanyName;
        }
    }
    class NewClientModels : IEnumerable<NewClientModel>
    {
        List<NewClientModel> newClients = null;

        public IEnumerator<NewClientModel> GetEnumerator()
        {
            return newClients.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(String ClientName, String ClientPhone, String ClientEmail, String CompanyName)
        {
            NewClientModel ncm = new NewClientModel(ClientName, ClientPhone, ClientEmail, CompanyName);
            newClients.Add(ncm);
        }
    }

}