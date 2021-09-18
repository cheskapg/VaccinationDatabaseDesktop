using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace PersonsApp.Model
{
    public class Persons
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public string VaccinationStatus { get; set; }

        public static string InsertPerson(string Lastname, string FirstName, int Age, string VaccinationStatus)
        {
            var client = new RestClient("http://localhost/IPT/persons/insertperson.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("LastName",Lastname );
            request.AddParameter("FirstName",FirstName);
            request.AddParameter("Age", Age);
            request.AddParameter("VaccinationStatus", VaccinationStatus);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static List<Persons> GetPersons()
        {
            var client = new RestClient("http://localhost/IPT/persons/getpersons.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var person = JsonConvert.DeserializeObject<List<Persons>>(response.Content);
            return person;
        }

        public static string UpdatePerson(Persons editperson)
        {
            var client = new RestClient("http://localhost/IPT/persons/updateperson.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("id", editperson.Id);
            request.AddParameter("LastName", editperson.LastName);
            request.AddParameter("FirstName", editperson.FirstName);
            request.AddParameter("Age", editperson.Age);
            request.AddParameter("VaccinationStatus", editperson.VaccinationStatus);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }

}
