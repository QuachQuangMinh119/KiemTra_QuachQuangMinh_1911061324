/*using KiemTra_QuachQuangMinh_1911061324.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Lab4_QuachQuangMinh.Models
{
    public class DangKy
    {
        MyDataDataContext data = new MyDataDataContext();
        [Display(Name = "Mã ")]
        public string maHP
        {
            get; set;
        }
        [Display(Name = "Tên học phần")]
        public string tenHP
        {
            get; set;
        }

        [Display(Name = "Số tín chỉ")]
        public int soTinChi
        {
            get; set;
        }
        public DangKy(int id)
        {
            maHP = id;
            HocPhan hp = data.HocPhans.Single(n => n.MaHP == maHP);
            tenHP = hp.TenHP;
            soTinChi = int.Parse(hp.SoTinChi.ToString());
        }
    }
}
*/