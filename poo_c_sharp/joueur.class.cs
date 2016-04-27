
public class Joueur
{
	private De de;
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
		de = new De();
	}

	public void Attaque(MonstreFacile monstre)
	{
		int lanceJoueur = LanceLeDe();
		int lanceMonstre = monstre.LanceLeDe();
		if (lanceJoueur >= lanceMonstre)
			monstre.SubitDegats();
	}

	public int LanceLeDe()
	{
		return de.LanceLeDe();
	}

	public void SubitDegats(int degat)
	{
		if (!bouclierFonctionne())
			this.Vie -= degat;
	}

	private bool bouclierFonctionne()
	{
		return de.LanceLeDe() <= 2;
	}

	public override string ToString()
	{
		return "Vie : " + this.Vie + " EstVivant : " + this.EstVivant;
	}

}