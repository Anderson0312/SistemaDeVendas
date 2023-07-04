using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.BLLClasses
{
    internal class transictionBLL
    {
        public int id { get; set; }
        public string type { get; set; }
        public int dea_cust_id { get; set; }
        public decimal grandTotal { get; set; }
        public DateTime transaction_date { get; set; }
        public decimal tax { get; set; }
        public decimal discount { get; set; }
        public int acced_by { get; set; }

        public DataTable transacaoDetalhes { get; set; }
    }
}
