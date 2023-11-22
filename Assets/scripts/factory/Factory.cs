using System;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace factory
{
    public class Factory : MonoBehaviour
    {
        public Name[] names;
        public Surname[] surnames;
        public HumanModel[] models;
        public string[] cities;
        private Random _random;

        private void Start()
        {
            _random = new Random();
            for (var i = 0; i < 10; i++) Generate();
        }

        private void Update()
        {
        }

        private void Generate()
        {
            var human = new Human();
            var sex = GetRandomSex();

            var namesList = names
                .Where(i => i.sex == sex)
                .Select(i => i.name)
                .ToArray();
            var surnamesList = surnames
                .Where(i => i.sex == sex)
                .Select(i => i.surname)
                .ToArray();
            var modelsList = models
                .Where(i => i.sex == sex)
                .Select(i => i.model)
                .ToArray();

            var name = (string)GetRandomValue(namesList);
            var surname = (string)GetRandomValue(surnamesList);
            // var model = (GameObject)GetRandomValue(modelsList);
            var city = (string)GetRandomValue(cities);
            // human.model = model;
            human.passport = new Passport(name, surname, city);
        }

        private Sex GetRandomSex()
        {
            var values = Enum.GetValues(typeof(Sex));
            return (Sex)values.GetValue(_random.Next(values.Length));
        }

        private object GetRandomValue(Array array)
        {
            return array.GetValue(_random.Next(array.Length));
        }
    }
}