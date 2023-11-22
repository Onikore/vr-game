using UnityEngine;

namespace factory
{
    public class Passport
    {
        public GameObject model;
        public string name;
        public string surname;
        public string city;
        public string serialNumber;
        public string dateOfBirth;
        public string expiresDate;

        public Passport(string name, string surname, string city, string serialNumber,
            string dateOfBirth, string expiresDate, GameObject model)
        {
            this.name = name;
            this.surname = surname;
            this.city = city;
            this.serialNumber = serialNumber;
            this.dateOfBirth = dateOfBirth;
            this.expiresDate = expiresDate;
            this.model = model;
        }

        public Passport(string name, string surname, string city)
        {
            this.name = name;
            this.surname = surname;
            this.city = city;
        }
    }
}