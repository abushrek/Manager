﻿using System;
using System.Globalization;
using Manager.Extensions;
using Manager.Model.Enums;
using Manager.Model.Interfaces;

namespace Manager.Model
{
    public class HoursRecord : IHoursRecord
    {
        public DateTime Date { get; set; }
        public double Bonus { get; set; }
        public double Price { get; set; }
        public bool IsOverTime { get; set; }
        public string DateString => Date.GetDateWithoutTime();
        public ERecordType Type { get; set; }
        public string TotalPrice => Math.Round(Time.Hours * Price + Time.Minutes / 60.0 * Price + Bonus,1).ToString(CultureInfo.InvariantCulture);
        public string Description { get; set; }
        public WorkTime Time { get; set; }



        public HoursRecord(DateTime date, uint hours,uint minutes, double price, double bonus, string description,bool isOverTime)
        {
            Date = date;
            Time = new WorkTime(hours, minutes);
            Price = price;
            Bonus = bonus;
            Description = description;
            IsOverTime = isOverTime;
            Type = ERecordType.Hours;
        }
        public HoursRecord(DateTime date, WorkTime time, double price, double bonus, string description, bool isOverTime) :this(date,time.Hours,time.Minutes,price,bonus, description,isOverTime)
        {
        }
    }
}