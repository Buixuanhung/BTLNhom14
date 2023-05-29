using System.ComponentModel.DataAnnotations;


namespace CuaHangHung.Models
{
    
    public class SanPham
    {
        [Key]
        public string SanPhamCode {get; set; }
        public string SanPhamName {get; set; }
       
        
        
        
        
    }
}