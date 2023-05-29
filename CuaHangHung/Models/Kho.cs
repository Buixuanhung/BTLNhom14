using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuaHangHung.Models
{
    [Table("Khoss")]
    public class Kho
    {
        [Key]
        public string KhoID {get; set; }
        public string SanPhamName {get; set; }
        public string NumberbKho {get; set; }
        public string KhoStoreExists{get; set; }//so luong tonng
        public string InventoryKho {get; set; }//sp trong kho
        public string ExportKho {get; set; }//hanbg xuat
        
     
    }
}