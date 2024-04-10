using System;

public class Activity
{
	string long id_count = 0;

	public int id;
	public string name;
	public string type;

	public Activity(string name, string type)
	{
		this.id = id_count;
		this.name = name;
		this.type = type;
		id_count++;
	}
}
