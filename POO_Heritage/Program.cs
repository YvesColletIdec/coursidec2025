namespace POO_Heritage.x
{
    internal class Program : Avion
    {
        static void Main(string[] args)
        {
            Moto m = new Moto();
            m.NombreRoues = 2;
            m.Marque = "Ducati";
            m.Couleur = "rouge";
            m.Poids = 230;

            Avion a = new Avion();
            a.Couleur = "blanc";
            //a.Voler();
            Velo v = new Velo(false);
            //liste avec 3 vélos
            List<Vehicule> maListeDeVelo = new List<Vehicule>();
            maListeDeVelo.Add(v);
            if (maListeDeVelo[0] is Velo)
            {
                Console.WriteLine("c'est un vélo");
                Vehicule veh1 = maListeDeVelo[0];
                //1ere solution de transtypage
                Velo vel1 = veh1 as Velo;
                vel1.NbPedale = 3;
                //2eme solution de transtypage
                ((Velo)maListeDeVelo[0]).NbPedale = 3;
                vel1.NbPedale = 2;
                ((Velo)veh1).NbPedale = 2;
                Console.WriteLine((maListeDeVelo[0] as Velo).NbPedale);
            }
            else
            {
                Console.WriteLine("pas vélo");
            }


            //maListeDeVelo.Add(new Avion());
            //maListeDeVelo.Add(new Moto());
        }

        public void MaMethode()
        {
            Program a = new Program();
            a.Couleur = "blanc";
            a.Voler();
        }
    }
}
