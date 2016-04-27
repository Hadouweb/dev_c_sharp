
public class Boss
{
	public int Vie { get; private set; }
	public bool EstVivant
	{
		get { return Vie > 0; }
	}

	public Boss(int vie)
	{
		Vie = vie;
	}

	public void Attaque (Joueur personnage)
	{
		int nb = LanceLeDe(26);
		personnage.SubitDegats(nb);
	}

	public void SubitDegats(int valeur)
	{
		Vie -= valeur;
	}

	private int LanceLeDe(int valeur)
	{
		return De.LanceLeDe(valeur);
	}
}