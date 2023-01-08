using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetMVP.Models;

namespace DotnetMVP.Controllers
{
    public class TugasController : Controller
    {
        private static List<ProdukTokoViewModel> _produkTokoViewModels = new List<ProdukTokoViewModel>()
        {
            new ProdukTokoViewModel(1, "Ryzen 5 ", "AMD", 1, 1500000),
            new ProdukTokoViewModel(2, "Ruzen 3", "AMD", 7, 1300000),
            new ProdukTokoViewModel(3, "Ryzen 7", "AMD", 11, 1700000),
            new ProdukTokoViewModel(4, "Intel Gen11", "Intel", 20, 2000000),
            new ProdukTokoViewModel(5, "RTX 3060 ", "NVDIA", 12, 5600000),
            new ProdukTokoViewModel(6, "GTX 16500Ti", "NVDIA", 3, 3200000),
            new ProdukTokoViewModel(7, "RX 6600 XT", "Radeon", 5, 4200000),
            new ProdukTokoViewModel(8, "RX 6650 XT OC", "Radeon", 3, 5400000),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TambahProduk()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, Name, Category, Value, Price")] ProdukTokoViewModel product)
        {
            _produkTokoViewModels.Add(product);
            return Redirect("TokoKomputer");
        }

        public IActionResult TokoKomputer()
        {
            return View(_produkTokoViewModels);
        }

        public IActionResult EditProduk(int? id)
        {
            // find with lambda
            ProdukTokoViewModel product = _produkTokoViewModels.Find(x => x.Id.Equals(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, Name, Category, Value, Price")] ProdukTokoViewModel product)
        {
            // hapus data lama
            ProdukTokoViewModel productOld = _produkTokoViewModels.Find(x => x.Id.Equals(id));
            _produkTokoViewModels.Remove(productOld);

            // input data baru
            _produkTokoViewModels.Add(product);
            return Redirect("TokoKomputer");
        }

        public IActionResult Details(int id)
        {
            // find with linq
            ProdukTokoViewModel product = (
                    from p in _produkTokoViewModels
                    where p.Id.Equals(id)
                    select p
                ).SingleOrDefault(new ProdukTokoViewModel());
            return View(product);
        }

        public IActionResult Delete(int? id)
        {
            // find data dulu
            ProdukTokoViewModel product = _produkTokoViewModels.Find(x => x.Id.Equals(id));
            // remove from list
            _produkTokoViewModels.Remove(product);

            return RedirectToAction("TokoKomputer"); ;
        }








        private static List<DataTamuViewModel> _dataTamuViewModels = new List<DataTamuViewModel>()
        {
        };

        public IActionResult DataTamuTambah()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveDataTamu([Bind("Id, Nama, Kota, NoWa, NoTlp")] DataTamuViewModel product)
        {
            _dataTamuViewModels.Add(product);
            return Redirect("DataTamu");
        }

        public IActionResult DataTamu()
        {
            return View(_dataTamuViewModels);
        }

        public IActionResult DataTamuEdit(int? id)
        {
            // find with lambda
            DataTamuViewModel product = _dataTamuViewModels.Find(x => x.Id.Equals(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateDataTamu(int id, [Bind("Id, Nama, Kota, NoWa, NoTlp")] DataTamuViewModel product)
        {
            // hapus data lama
            DataTamuViewModel productOld = _dataTamuViewModels.Find(x => x.Id.Equals(id));
            _dataTamuViewModels.Remove(productOld);

            // input data baru
            _dataTamuViewModels.Add(product);
            return Redirect("DataTamu");
        }

        public IActionResult DeleteDataTamu(int? id)
        {
            // find data dulu
            DataTamuViewModel product = _dataTamuViewModels.Find(x => x.Id.Equals(id));
            // remove from list
            _dataTamuViewModels.Remove(product);

            return RedirectToAction("DataTamu"); ;
        }









        private static List<SendEmailViewModel> _sendEmailViewModels = new List<SendEmailViewModel>()
        {
        };

        public IActionResult SendEmailTambah()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveSendEmail([Bind("Id, From, To, Message, Subject")] SendEmailViewModel product)
        {
            _sendEmailViewModels.Add(product);
            return Redirect("SendEmail");
        }

        public IActionResult SendEmail()
        {
            return View(_sendEmailViewModels);
        }

        public IActionResult SendEmailEdit(int? id)
        {
            // find with lambda
            SendEmailViewModel product = _sendEmailViewModels.Find(x => x.Id.Equals(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateSendEmail(int id, [Bind("Id, From, To, Message, Subject")] SendEmailViewModel product)
        {
            // hapus data lama
            SendEmailViewModel productOld = _sendEmailViewModels.Find(x => x.Id.Equals(id));
            _sendEmailViewModels.Remove(productOld);

            // input data baru
            _sendEmailViewModels.Add(product);
            return Redirect("SendEmail");
        }

        public IActionResult DeleteSendEmail(int? id)
        {
            // find data dulu
            SendEmailViewModel product = _sendEmailViewModels.Find(x => x.Id.Equals(id));
            // remove from list
            _sendEmailViewModels.Remove(product);

            return RedirectToAction("SendEmail"); ;
        }









        private static List<DataPerusahaanViewModel> _dataPerusahaanViewModel = new List<DataPerusahaanViewModel>()
        {
            new DataPerusahaanViewModel(1, "Front End", "Lindhu", 12, 4),
            new DataPerusahaanViewModel(2, "Back End", "Aldi", 7, 14),
            new DataPerusahaanViewModel(3, "QA", "Handy", 11, 12),
            new DataPerusahaanViewModel(4, "Teknisi", "Hero", 4, 20),
        };

        public IActionResult DataPerusahaanTambah()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveDataPerusahaan([Bind("Id, Divisi, Leader, PkrWnt, PkrPri")] DataPerusahaanViewModel product)
        {
            _dataPerusahaanViewModel.Add(product);
            return Redirect("DataPerusahaan");
        }

        public IActionResult DataPerusahaan()
        {
            return View(_dataPerusahaanViewModel);
        }

        public IActionResult DataPerusahaanEdit(int? id)
        {
            // find with lambda
            DataPerusahaanViewModel product = _dataPerusahaanViewModel.Find(x => x.Id.Equals(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateDataPerusahaan(int id, [Bind("Id, Divisi, Leader, PkrWnt, PkrPri")] DataPerusahaanViewModel product)
        {
            // hapus data lama
            DataPerusahaanViewModel productOld = _dataPerusahaanViewModel.Find(x => x.Id.Equals(id));
            _dataPerusahaanViewModel.Remove(productOld);

            // input data baru
            _dataPerusahaanViewModel.Add(product);
            return Redirect("DataPerusahaan");
        }

        public IActionResult DeleteDataPerusahaan(int? id)
        {
            // find data dulu
            DataPerusahaanViewModel product = _dataPerusahaanViewModel.Find(x => x.Id.Equals(id));
            // remove from list
            _dataPerusahaanViewModel.Remove(product);

            return RedirectToAction("DataPerusahaan"); ;
        }









        private static List<TokoGameViewModel> _tokoGameViewModel = new List<TokoGameViewModel>()
        {
            new TokoGameViewModel(1, "Tom Clancy The Division", "Action, Fps", 3, 2019, 400000),
            new TokoGameViewModel(2, "Minecraft", "Build, Open World", 7, 1999, 0),
            new TokoGameViewModel(3, "Far Cry 5", "Action, Fps", 1, 2020, 600000),
            new TokoGameViewModel(4, "GTA 5", "Open World", 4, 2020, 400000),
            new TokoGameViewModel(5, "Harvest Moon", "Farm", 1000, 1999, 1000000),
        };

        public IActionResult TokoGameTambah()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveTokoGame([Bind("Id, Nama, Genre, Tahun, Jumlah, Harga")] TokoGameViewModel product)
        {
            _tokoGameViewModel.Add(product);
            return Redirect("TokoGame");
        }

        public IActionResult TokoGame()
        {
            return View(_tokoGameViewModel);
        }

        public IActionResult TokoGameEdit(int? id)
        {
            // find with lambda
            TokoGameViewModel product = _tokoGameViewModel.Find(x => x.Id.Equals(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateTokoGame(int id, [Bind("Id, Nama, Genre, Tahun, Jumlah, Harga")] TokoGameViewModel product)
        {
            // hapus data lama
            TokoGameViewModel productOld = _tokoGameViewModel.Find(x => x.Id.Equals(id));
            _tokoGameViewModel.Remove(productOld);

            // input data baru
            _tokoGameViewModel.Add(product);
            return Redirect("TokoGame");
        }

        public IActionResult DeleteTokoGame(int? id)
        {
            // find data dulu
            TokoGameViewModel product = _tokoGameViewModel.Find(x => x.Id.Equals(id));
            // remove from list
            _tokoGameViewModel.Remove(product);

            return RedirectToAction("TokoGame"); ;
        }
    }
}