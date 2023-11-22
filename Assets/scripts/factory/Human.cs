using System;
using UnityEngine;

namespace factory
{
    public class Human
    {
        public GameObject model;
        public Passport passport;
    }



    [Serializable]
    public class HumanModel
    {
        public GameObject model;
        public Sex sex;
    }

    [Serializable]
    public class Name
    {
        public string name;
        public Sex sex;
    }

    [Serializable]
    public class Surname
    {
        public string surname;
        public Sex sex;
    }

    public enum Sex
    {
        Male,
        Female
    }
}