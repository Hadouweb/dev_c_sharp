using System;

public class Voiture 
{

	protected int Vitesse { get; set; }

	public Voiture()
	{
		this.Vitesse = 5;
		Console.WriteLine("Constructeur Voiture");
	}

	public void Rouler()
	{
		Console.WriteLine("Je roule à " + Vitesse + " km/h");
	}

	public void Accelerer(int vitesse)
	{
		this.Vitesse = vitesse;
		this.Rouler();
	}

}