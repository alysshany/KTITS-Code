using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearnSchoolDemoWPF.ADOApp
{
    public partial class Service
    {


        public Visibility Visibility 
        {
            get 
            {
                if (App.isAuth)
                    return Visibility.Visible;
                else 
                    return Visibility.Collapsed;
            }
        }
    }
}
