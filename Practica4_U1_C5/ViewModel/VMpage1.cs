using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica4_U1_C5.ViewModel
{
    internal class VMpage1 : BaseViewModel
    {
        #region VARIEBLES
        string _texto;
        string _nombre;
        bool _hombre;
        bool _mujer;
        bool _alto;
        bool _listo;
        bool _raro;
        bool _feo;
        bool _extravagante;
        bool _grande;
        #endregion
        #region CONTRUCTOR
        public VMpage1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _texto; }
            set { SetValue(ref _texto, value); }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public bool Hombre
        {
            get { return _hombre; }
            set { SetValue(ref _hombre, value); }
        }
        public bool Mujer
        {
            get { return _mujer; }
            set { SetValue(ref _mujer, value); }
        }
        public bool Alto
        {
            get { return _alto; }
            set { SetValue(ref _alto, value); }
        }
        public bool Listo
        {
            get { return _listo; }
            set { SetValue(ref _listo, value); }
        }

        public bool Raro
        {
            get { return _raro; }
            set { SetValue(ref _raro, value); }
        }
        public bool Feo
        {
            get { return _feo; }
            set { SetValue(ref _feo, value); }
        }
        public bool Extravagante
        {
            get { return _extravagante; }
            set { SetValue(ref _extravagante, value); }
        }
        public bool Grande
        {
            get { return _grande; }
            set { SetValue(ref _grande, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void Criticar()
        {
            string nombre = Nombre;
            string critica = nombre + " es ";

            if (Hombre)
            {
                if (Alto)
                {
                    critica += "alto, ";
                }
                if (Listo)
                {
                    critica += "listo, ";
                }
                if (Raro)
                {
                    critica += "raro, ";
                }
                if (Feo)
                {
                    critica += "feo, ";
                }
                if (Extravagante)
                {
                    critica += "extravagante, ";
                }
                if (Grande)
                {
                    critica += "grande, ";
                }
            }
            if (Mujer)
            {
                if (Alto)
                {
                    critica += "alta, ";
                }
                if (Listo)
                {
                    critica += "lista, ";
                }
                if (Raro)
                {
                    critica += "rara, ";
                }
                if (Feo)
                {
                    critica += "fea, ";
                }
                if (Extravagante)
                {
                    critica += "extravagante, ";
                }
                if (Grande)
                {
                    critica += "grande, ";
                }
            }
            string resultado = critica.TrimEnd(' ', ',');

            if (!string.IsNullOrWhiteSpace(resultado))
            {
                int ucoma = resultado.LastIndexOf(',');
                if (ucoma > 0)
                {
                    resultado = $"{resultado.Substring(0, ucoma)} y {resultado.Substring(ucoma + 1)}";
                }
            }
            Texto = resultado + ".";
        }
        #endregion
        #region COMANDO
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Criticarcommand => new Command(Criticar);
        #endregion
    }
}
