<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_QLNS.DTO
{
    public class VaiTro
    {
        [Key]
        public int Id { get; set; }
        [Column("TenVaiTro")]
        [StringLength(150)]
        public string TenVaiTro { get; set; }
    }
}
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_QLNS.DTO
{
    public class VaiTro
    {
        [Key]
        public int Id { get; set; }
        [Column("TenVaiTro")]
        [StringLength(150)]
        public string TenVaiTro { get; set; }
    }
}
>>>>>>> a23181918e10a5bb2ecb63baf317e851cbf893af
