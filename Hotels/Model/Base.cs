using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Hotels.Model
{
    public class Base
    {
        public virtual /*abstract*/ void Insert() { }
        //public virtual List<> Retrieve() { return null; }
        public virtual void Update() { }
        public virtual void Delete() { }

        
    }
}
