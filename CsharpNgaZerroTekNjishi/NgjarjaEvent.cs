using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public class NgjarjaEvent
    {
        private int _numri;

        public int getNumri()
        { 
            return _numri;
        }

        public void setNumri(int vlera)
        { 
            _numri = vlera;
            NumriChanged?.Invoke(this, new ArgumentetENgjarjes { vlera = _numri });
            
        }
        
        public event EventHandler<ArgumentetENgjarjes> NumriChanged;
    }

    public class ArgumentetENgjarjes : EventArgs
    {
        public int vlera { get; set; }
    }
}
