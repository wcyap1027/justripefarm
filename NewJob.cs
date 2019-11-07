using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Form_and_Panel
{
    public class NewJob
    {
        private int type;
        private int labourerId;
        private DateTime startWorkDate;
        private DateTime endWorkDate;

        public int Type { get => type; set => type = value; }
        public int LabourerId { get => labourerId; set => labourerId = value; }
        public DateTime StartWorkDate { get => startWorkDate; set => startWorkDate = value; }
        public DateTime EndWorkDate { get => endWorkDate; set => endWorkDate = value; }
    }
}
