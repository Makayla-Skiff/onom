using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavistarWebApp.Data
{
    public class AuditTable
    {
        [Key]
        public int AID { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public int Approved { get; set; }
        public int EmployeeCount { get; set; }
        public int OpenCount { get; set; }
        public int ContractorCount { get; set; }
        public string UpdateorSubmit { get; set; }

    }
}