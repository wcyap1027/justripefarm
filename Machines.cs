using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Form_and_Panel
{
    public class Machines
    {
        private string type;
        private int machinesId;
        private string machinesName;
        private DateTime factoryDate;

        public string Type { get => type; set => type = value; }
        public int MachinesId { get => machinesId; set => machinesId = value; }
        public string MachinesName { get => machinesName; set => machinesName = value; }
        public DateTime FactoryDate { get => factoryDate; set => factoryDate = value; }
    }
}
