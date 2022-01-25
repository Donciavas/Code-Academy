using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_24_d_pamoka
{
    public class TV_Programme
    {
        public List<TV_Show> TV_Shows { get; set; }

        public TV_Programme(List<TV_Show> tV_Shows)
        {
            TV_Shows = tV_Shows;
        }

        public TV_Programme()
        {
        }
    }
}
