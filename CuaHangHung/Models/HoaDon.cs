using System.ComponentModel.DataAnnotations;


namespace CuaHangHung.Models
{
    
    public class HoaDon
    {
        [Key]
        public string HoaDonCode {get; set; }
        public string HoaDonName {get; set; }
        
        public string SanPhamCode {get; set; }
        
        
        public string SoLuong {get; set; }
        
        
        
        
        
    }
}