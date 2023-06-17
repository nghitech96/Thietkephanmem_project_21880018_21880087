<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_QLNS.DTO
{
    public class TacGia
    {
        [Key]
        public int Id { get; set; }

        [Column("Ten")]
        [StringLength(50)]
        public string Ten { get; set; }
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
=======
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_QLNS.DTO
{
    public class TacGia
    {
        [Key]
        public int Id { get; set; }

        [Column("Ten")]
        [StringLength(50)]
        public string Ten { get; set; }
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
>>>>>>> a23181918e10a5bb2ecb63baf317e851cbf893af
