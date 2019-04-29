using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livelabel
{

    public class LiveLabelMenuItem
    {
        public LiveLabelMenuItem()
        {
            TargetType = typeof(LiveLabelDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}