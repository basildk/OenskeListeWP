using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ØnskelisteWP.Interfaces
{
    interface IOenskeRepository
    {
        List<ItemViewModel> HentOensker();
    }
}
