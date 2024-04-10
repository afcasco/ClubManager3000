using System;

public class Soci
{

	public string name;
	public string lastnames;
	public string phone;
	public string email;
	public string signupDate;
	public List<Activity> activities;
    public Soci(string name, string lastnames, string phone, string email, string signupDate)
	
	{

		this.name = name;
		this.lastnames = lastnames;
		this.phone = phone;
		this.email = email;
		this.signupDate = signupDate;
		this.activities = new List<Activity> ();
	}
}


//Pepita:Garcia Perez:686666111:pepita@gmail.com:23/01/24:activitat1,activitat2,activitat3,activitat4: