using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityExample.Model
{
    [Table("PHONGBAN")]//Tên của bảng trong cơ sở dữ liệu
    class PhongBan
    {
        [Key]//Khóa chính
        public int IDPB { set; get; }
        public string TenPB { set; get; }
        public virtual ICollection<NhanVien> CacNhanVien { set; get; }
        // Quan hệ 1-n với bảng nhân viên
    }
}
