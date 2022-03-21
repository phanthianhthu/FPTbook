namespace WebBanSach.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienHe")]
    public partial class LienHe
    {
        [Key]
        public int MaLH { get; set; }

        [StringLength(50)]
        [Display(Name ="Last Name")]
        [Required(ErrorMessage = "Can't be left blank")]
        public string Ho { get; set; }

        [StringLength(50)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Can't be left blank")]
        public string Ten { get; set; }

        [StringLength(100)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Can't be left blank")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Can't be left blank")]
        [DataType(DataType.PhoneNumber)]
        public string DienThoai { get; set; }

        [StringLength(500)]
        [Display(Name = "Content")]
        [Required(ErrorMessage = "Nội dung cần nhập của bạn")]
        public string NoiDung { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Date Update")]
        [DataType(DataType.DateTime)]
        public DateTime? NgayCapNhat { get; set; }
    }
}
