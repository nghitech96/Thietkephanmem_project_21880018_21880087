<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebAPI_QLNS.DTO
{
    public class PhieuThuTien
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [Column("IdKhachHang", TypeName ="int")]
        public int IdKhachHang { get; set; }

        [Column("Ngay")]
        public DateTime Ngay { get; set; }

        [Column("Tien", TypeName = "long")]
        public long Tien { get; set; }
        [ForeignKey("IdKhachHang")]
       public virtual KhachHang KhachHang { get; set; }
    }
}
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebAPI_QLNS.DTO
{
    public class PhieuThuTien
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [Column("IdKhachHang", TypeName ="int")]
        public int IdKhachHang { get; set; }

        [Column("Ngay")]
        public DateTime Ngay { get; set; }

        [Column("Tien", TypeName = "long")]
        public long Tien { get; set; }
        [ForeignKey("IdKhachHang")]
       public virtual KhachHang KhachHang { get; set; }
    }
}
>>>>>>> a23181918e10a5bb2ecb63baf317e851cbf893af
