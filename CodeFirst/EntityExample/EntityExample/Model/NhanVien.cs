using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityExample.Model
{
    [Table("NHANVIEN")]//Tên bảng trong cơ sở dữ liệu
    class NhanVien
    {
        [Key]//Khóa chính
        public int IDNV { set; get; }
        public int IDPB { set; get; }
        [StringLength(50)]//annotation quy định chiều dài của chuổi
        public string HoTen { set; get; }
        public int Tuoi { set; get; }
        [ForeignKey("IDPB")]// Khóa phụ là IDPB
        public virtual PhongBan PhongBan { set; get; }
        //Quan hệ 1-1 với bảng phòng ban
    }
}
