
namespace Rec03_ParejasCartas.Models
{
    public class clsCarta
    {

        //Atributos
        private int _id;
        private string _imgVisible;
        private string _imgAnverso;
        private string _imgReverso;

        //Constructores
        public clsCarta()
        {
            this._id = 0;
            this._imgAnverso = "";
            this._imgReverso = "/Assets/anonimo2.jpg";
            this._imgVisible = _imgAnverso;
        }

        public clsCarta(int id, string imgReverso, string imgAnverso)
        {
            this._id = id;
            this._imgVisible = imgReverso;
            this._imgAnverso = imgAnverso;
            this._imgReverso = imgReverso;
        }

        //Getters & setters
        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }   
        }

        public string imgVisible
        {
            get
            {
                return _imgVisible;
            }

            set
            {
                _imgVisible = value;
            }
        }

        public string imgAnverso
        {
            get
            {
                return _imgAnverso;
            }

            set
            {
                _imgAnverso = value;
            }
        }

        public string imgReverso
        {
            get
            {
                return _imgReverso;
            }

            set
            {
                _imgReverso = value;
            }
        }

    }
}
