using IsaProject.Models.Entities;
using System;
using System.Collections.Generic;

namespace IsaProject.Models.DTO
{
    public class AppointmentDTO
    {
        public AppointmentDTO(long id, string name, string address, string country, string city, double averageScore, string rules, double price, DateTime startDate, int duration)
        {
            Id = id;
            Name = name;
            Address = address;
            Country = country;
            City = city;
            AverageScore = averageScore;
            Rules = rules;
            Price = price;
            Duration = duration;
            StartDate = startDate;
        }

        public AppointmentDTO()
        {
        }

        public AppointmentDTO(string customerId, DateTime dateTime, int numberOfGuest, int numberOfDays)
        {
            StartDate = dateTime;
            NumberOfGuest = numberOfGuest;
            Duration = numberOfDays;
            CustomerId = customerId;
        }

        public long Id { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double AverageScore { get; set; }
        public string Rules { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int NumberOfGuest { get; set; }
        public List<Tag> Tags { get; set; }
    }
}

