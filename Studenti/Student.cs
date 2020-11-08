using System;
namespace Studenti
{
    public class Student : Osoba
    {
        public int BrojIndeksa  { get; set; }
	    public double ProsekOcena  { get; set; }
	
	    string PunoIme(){
		return BrojIndeksa + ProsekOcena;	
	    }
    }
}
