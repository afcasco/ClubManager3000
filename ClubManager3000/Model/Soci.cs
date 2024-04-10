using System;
using System.Collections.Generic;

namespace ClubManager3000
{
    public class Soci
    {

        public string Name { get; set; }
        public string Lastnames { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SignupDate { get; set; }
        public List<string> Activities { get; set; }
        public Soci(string Name, string Lastnames, string Phone, string Email, string SignupDate)
        {
            this.Name = Name;
            this.Lastnames = Lastnames;
            this.Phone = Phone;
            this.Email = Email;
            this.SignupDate = SignupDate;
            Activities = new List<string>();
        }


        public override string ToString()
        {
            return $"{Name} {Lastnames}";
        }

        public static Soci ParseSoci(string s)
        {
            var split = s.Split(':');
            var soci = new Soci(split[0], split[1], split[2], split[3], split[4]);
            var activitats = split[5].Split(',');
            foreach (var item in activitats)
            {
                soci.Activities.Add(item);
            }
            return soci;
        }

        public static Func<Soci, string> convertToText = soci => $"{soci.Name}:{soci.Lastnames}:{soci.Phone}:{soci.Email}:{soci.SignupDate}:{string.Join(",", soci.Activities)}";
    }
}