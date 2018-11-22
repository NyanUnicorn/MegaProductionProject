using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegaProduction.Model
{
    interface ITab
    {
        String Name { get; set; }
        UserControl TabContent { get; set; }
        TabItem TabElement { get; }



    }
}
