using System.Collections.ObjectModel;

namespace Rec03_ParejasCartas.Models
{
    public class clsListadoCartas
    {
        public ObservableCollection<clsCarta> getListadoCartas()
        {

            ObservableCollection<clsCarta> listado = new ObservableCollection<clsCarta>();

            listado.Add(new clsCarta(1, "../Assets/anonimo2.jpg", "../Assets/AR-15.jpg"));
            listado.Add(new clsCarta(1, "../Assets/anonimo2.jpg", "../Assets/Sasha.jpg"));

            listado.Add(new clsCarta(2, "../Assets/anonimo2.jpg", "../Assets/Ballesta.jpg"));
            listado.Add(new clsCarta(2, "../Assets/anonimo2.jpg", "../Assets/Daryl.jpg"));

            listado.Add(new clsCarta(3, "../Assets/anonimo2.jpg", "../Assets/Colt.jpg"));
            listado.Add(new clsCarta(3, "../Assets/anonimo2.jpg", "../Assets/Rick.jpg"));

            listado.Add(new clsCarta(4, "../Assets/anonimo2.jpg", "../Assets/Katana.jpg"));
            listado.Add(new clsCarta(4, "../Assets/anonimo2.jpg", "../Assets/Michonne.jpg"));

            listado.Add(new clsCarta(5, "../Assets/anonimo2.jpg", "../Assets/Lucille.jpg"));
            listado.Add(new clsCarta(5, "../Assets/anonimo2.jpg", "../Assets/Negan.jpg"));

            listado.Add(new clsCarta(6, "../Assets/anonimo2.jpg", "../Assets/Martillo.jpg"));
            listado.Add(new clsCarta(6, "../Assets/anonimo2.jpg", "../Assets/Tyreese.jpg"));


            return listado;
        }
    }
}
