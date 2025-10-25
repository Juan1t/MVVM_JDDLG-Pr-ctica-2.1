using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_JDDLG.MVVM.ViewsModels
{
    internal class GenteViewsModel
    {
        public List<string> Gente { get; set; }
        public GenteViewsModel()
        {
            Gente = new List<string>()
            {
                "Juan", 
                "María",
                "Pedro",
                "Ana",
                "Luis"
            };
        }
    }
}
