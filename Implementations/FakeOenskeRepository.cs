using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ØnskelisteWP.Interfaces;
using System.Collections.Generic;

namespace ØnskelisteWP.Implementations
{
    public class FakeOenskeRepository : IOenskeRepository
    {
        public List<ItemViewModel> HentOensker()
        {
            var res = new List<ItemViewModel>();
            res.Add(new ItemViewModel(){ LineOne = "Ønske 1", LineTwo = "Beskrivelse af ønske 1"});
            res.Add(new ItemViewModel(){ LineOne = "Ønske 2", LineTwo = "Beskrivelse af ønske 1"});
            res.Add(new ItemViewModel() { LineOne = "Ønske 2", LineTwo = "Beskrivelse af ønske 1" });
            res.Add(new ItemViewModel() { LineOne = "Ønske 2", LineTwo = "Beskrivelse af ønske 1" });

            return res;

        }
    }
}
