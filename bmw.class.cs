using System;

public class Bmw : Voiture
{

	public Bmw()
	{
		this.Vitesse = 50;
		Console.WriteLine("Constructeur Bmw");
	}

	public override string ToString()
	{
		return "Je suis une Bmw";
	}

}