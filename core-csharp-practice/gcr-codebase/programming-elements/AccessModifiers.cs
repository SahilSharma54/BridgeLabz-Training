using System;

class AccessModifiers{
	
	public string name="Sahil";
		
    private int age=21;
		
	protected string favouriteFruit="Apple";
		
	internal string favouriteColor="Blue";
		
	protected internal string location="Agra";
		
//	private protected int salary=20000;  // error giving "more than one protection modifier " in running code so commented out
	
	    static void Main(String[] args){
		
		AccessModifiers info=new AccessModifiers();
		
		
		Console.WriteLine(info.name);
		Console.WriteLine(info.age);
		Console.WriteLine(info.favouriteFruit);
		Console.WriteLine(info.favouriteColor);
		Console.WriteLine(info.location);
	//	Console.WriteLine(info.salary); // Reason for commenting already mentioned
		
		
	    }
	
}





