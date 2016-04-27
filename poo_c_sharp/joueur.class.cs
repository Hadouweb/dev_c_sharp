
public class Joueur
{
	public int Vie { get; private set; }
	public bool EstVivant
	{
		get 
		{ 
			return this.Vie > 0; 
		}
	}

	public Joueur(int vie)
	{
		this.Vie = vie;
	}

	public void Attaque(MonstreFacile monstre)
	{
		int lanceJoueur = LanceLeDe();
		int lanceMonstre = monstre.LanceLeDe();
		if (lanceJoueur >= lanceMonstre)
			monstre.SubitDegats();
	}

	public void Attaque(Boss boss)
	{
		int nb = LanceLeDe(26);
		boss.SubitDegats(nb);
	}

	public int LanceLeDe()
	{
		return De.LanceLeDe();
	}

	public int LanceLeDe(int valeur)
	{
		return De.LanceLeDe(valeur);
	}

	public void SubitDegats(int degat)
	{
		if (!bouclierFonctionne())
			this.Vie -= degat;
	}

	private bool bouclierFonctionne()
	{
		return De.LanceLeDe() <= 2;
	}

}