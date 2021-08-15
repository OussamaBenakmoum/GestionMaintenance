using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;


namespace GestionMaintenance.Models
{
    public class TypeAppareil
    {
        [PrimaryKey, AutoIncrement]
         
        private int id { get; set; }
        private string nom { get; set; }
        
        public override string ToString()
        {
            return $"{id} - {nom}";
        }
    }
}
