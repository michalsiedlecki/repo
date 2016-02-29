using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4Y
{
    class SQLTrainig
    {

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string TrainingName { get; set; }

        public string Description { get; set; }
    }
}
