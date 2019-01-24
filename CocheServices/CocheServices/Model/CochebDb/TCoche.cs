using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocheServices.Model.CochebDb
{
    [Table("tCoche")]
    public partial class TCoche
    {
        [Key]
        [Column("coche_Id")]
        public Guid CocheId { get; set; }
        [Column("coche_color")]
        [StringLength(20)]
        public string CocheColor { get; set; }
        [Column("coche_fabri")]
        public int? CocheFabri { get; set; }
        [Column("coche_placa")]
        [StringLength(10)]
        public string CochePlaca { get; set; }
        [Column("coche_n_asientos")]
        public int? CocheNAsientos { get; set; }
        [Column("coche_mec")]
        [StringLength(2)]
        public string CocheMec { get; set; }
        [Column("coche_full")]
        [StringLength(2)]
        public string CocheFull { get; set; }
        [Column("coche_marca")]
        [StringLength(20)]
        public string CocheMarca { get; set; }
    }
}
