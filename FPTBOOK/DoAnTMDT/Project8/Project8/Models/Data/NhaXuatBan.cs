﻿namespace WebBanSach.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaXuatBan")]
    public partial class NhaXuatBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaXuatBan()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [Display(Name = "Publishing Company ID")]
        public int MaNXB { get; set; }

        [StringLength(50)]
        [Display(Name = "Publishing Company Name")]
        [Required(ErrorMessage = "Can't be left blank")]
        public string TenNXB { get; set; }

        [StringLength(250)]
        [Display(Name = "Address")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone Numer")]
        public string DienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
