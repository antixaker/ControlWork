using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControlWork.ViewModel
{
    class CZViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        CrossZero currentSymbol;
        public CrossZero CurrentSymbol
        {
            protected set
            {
                if (currentSymbol != value)
                {
                    currentSymbol = value;
                    //OnPropertyChanged(nameof(currentSymbol));
                }
            }

            get { return currentSymbol; }
        }

        public string SymbolToButton = "";

        public CZViewModel()
        {
            SetCurrentActionToZero = new Command(() =>
            {
                CurrentSymbol = CrossZero.Zero;
            });

            SetCurrentActionToCross = new Command(() =>
            {
                CurrentSymbol = CrossZero.Cross;
            });

        }

        //public Command TapGameButton
        //{
        //    get
        //    {
        //        return _tapGameButton ?? _tapGameButton = new Command(()=> {
        //            SymbolToButton= CurrentSymbol == CrossZero.Cross ? "X" : "O";
        //        });
        //            //
        //    }
        //}

        public Command SetCurrentActionToZero;
        public Command SetCurrentActionToCross;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    enum CrossZero
    {
        Cross,
        Zero
    }
}
