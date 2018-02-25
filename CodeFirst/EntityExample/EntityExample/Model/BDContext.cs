using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EntityExample.Model
{
    class BDContext: DbContext
    {
        public DbSet<PhongBan> PhongBans { set; get; }// Tạo bảng PHONGBAN trong CSDL
        public DbSet<NhanVien> NhanViens { set; get; }// Tạo bảng NHANVIEN trong CSDL
        public BDContext()
            :base("mydata")//Tên của câu lệnh kết nối ConnectionString
        {
            Database.SetInitializer<BDContext>(new CreateDatabase());
        }
    }
    class CreateDatabase : CreateDatabaseIfNotExists<BDContext>
        //Tạo cơ sở dữ liệu nếu nó chưa tồn tại
    {
        protected override void Seed(BDContext context)
            //Viết lại hàm Seed để đưa dữ liệu mẫu vào cơ sở dữ liệu
        {
            context.PhongBans.Add(new PhongBan { TenPB = "Phòng Kế Toán" });
            context.PhongBans.Add(new PhongBan { TenPB = "Phòng Nhân Sự" });
            context.SaveChanges();
            context.NhanViens.Add(new NhanVien { IDPB = 1, HoTen = "Lê Văn Tý", Tuoi = 30 });
            context.NhanViens.Add(new NhanVien { IDPB = 1, HoTen = "Trận Thị Tèo", Tuoi = 30 });
            context.NhanViens.Add(new NhanVien { IDPB = 2, HoTen = "Nguyễn Văn Cu", Tuoi = 30 });
            base.Seed(context);
        }
    }
}
