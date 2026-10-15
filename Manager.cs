using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zianberdin_Chudo_Boots
{
    internal class Manager
    {
        public static Frame MainFrame { get; set; }
        public static Users CurrentUser { get; set; }
        public static List<OrderProducts> Cart = new List<OrderProducts>();
    }
}
