using KiemTra_QuachQuangMinh_1911061324.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_QuachQuangMinh_1911061324.Controllers
{
    public class HocPhanController : Controller
    {
        // GET: HocPhan
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var hp = from tt in data.HocPhans select tt;
            return View(hp);
        }    
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var masv = collection["masinhvien"];
            SinhVien sv = data.SinhViens.SingleOrDefault(n => n.MaSV == masv);
            if (sv != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TaiKhoan"] = sv;
            }
            else
            {
                ViewBag.ThongBao = "Mã đăng nhập không đúng";
            }
            return RedirectToAction("Index", "Home");
        }
    }
}