using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KonusarakOgren.Models;
using Microsoft.Data.Sqlite;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using HtmlAgilityPack;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
//todo delete çalışmıyor düzelt
namespace KonusarakOgren.Controllers
{
    public class HomeController : Controller
    {
        List<login> c = new List<login>();
        private List<CreateModel> model = new List<CreateModel>();
        private List<exams_model> exams_modeli = new List<exams_model>();
        private List<Sinav> Sinav_Model = new List<Sinav>();
        private List<yazi_model> yazi_modeli = new List<yazi_model>();
        public static class MyGlobalVariables
        {
            public static string baslik1 { get; set; }
            public static string baslik2 { get; set; }
            public static string baslik3 { get; set; }
            public static string baslik4 { get; set; }
            public static string baslik5 { get; set; }
            public static string yazi1 { get; set; }
            public static string yazi2 { get; set; }
            public static string yazi3 { get; set; }
            public static string yazi4 { get; set; }
            public static string yazi5 { get; set; }

        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> CreateAsync()
        {

            var httpclient = new HttpClient();
            var text = await httpclient.GetStringAsync("http://www.wired.com");
            var htmldocument = new HtmlDocument();
            htmldocument.LoadHtml(text);
            var asd = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]/div/ul/li[2]/a[2]/h2")[0];
            var asd_link = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]/div/ul/li[2]/a[1]")[0];
            var asd2 = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[2]/div/ul/li[2]/a[2]/h2")[0];
            var asd2_link = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[2]/div/ul/li[2]/a[1]")[0];
            var asd3 = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[1]/div/ul/li[2]/a[2]/h2")[0];
            var asd3_link = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[1]/div/ul/li[2]/a[1]")[0];
            var asd4 = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/ul/li[2]/a[2]/h2")[0];
            var asd4_link = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/ul/li[2]/a[1]")[0];
            var asd5 = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[2]/div/ul/li[2]/a[2]/h2")[0];
            var asd5_link = htmldocument.DocumentNode.SelectNodes("/html/body/div[3]/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[2]/div/ul/li[2]/a[1]")[0];
            MyGlobalVariables.baslik1 = asd.InnerText;
            var q_link = VeriAl(asd_link.OuterHtml);
            MyGlobalVariables.yazi1 = q_link.Result.Replace("'", "‘");

            MyGlobalVariables.baslik2 = asd2.InnerText;
            var q2_link = VeriAl(asd2_link.OuterHtml);
            MyGlobalVariables.yazi2 = q2_link.Result.Replace("'", "‘");

            MyGlobalVariables.baslik3 = asd3.InnerText;
            var q3_link = VeriAl(asd3_link.OuterHtml);
            MyGlobalVariables.yazi3 = q3_link.Result.Replace("'", "‘");

            MyGlobalVariables.baslik4 = asd4.InnerText;
            var q4_link = VeriAl(asd4_link.OuterHtml);
            MyGlobalVariables.yazi4 = q4_link.Result.Replace("'", "‘");

            MyGlobalVariables.baslik5 = asd5.InnerText;
            var q5_link = VeriAl(asd5_link.OuterHtml);
            MyGlobalVariables.yazi5 = q5_link.Result.Replace("'", "‘");


            
            MultipleModel temp = new MultipleModel();
            //temp.Sorular = new List<Sorular>();
            //temp.Sorular.Add(new Sorular {A_sikki="", B_sikki = "" , C_sikki = "" , D_sikki = "" ,soru_id="", soru = "" , cevap = "" });// bu satırda yaptığım işlemin önemi yok hata engellemek için yapıldı sadece.
            model.Add(new CreateModel()
            {

                baslik = MyGlobalVariables.baslik1,
                yazi = MyGlobalVariables.yazi1

            });
            model.Add(new CreateModel()
            {

                baslik = MyGlobalVariables.baslik2,
                yazi = MyGlobalVariables.yazi2

            });
            model.Add(new CreateModel()
            {

                baslik = MyGlobalVariables.baslik3,
                yazi = MyGlobalVariables.yazi3

            });
            model.Add(new CreateModel()
            {

                baslik = MyGlobalVariables.baslik4,
                yazi = MyGlobalVariables.yazi4

            });
            model.Add(new CreateModel()
            {

                baslik = MyGlobalVariables.baslik5,
                yazi = MyGlobalVariables.yazi5

            });

            temp.CreateModel = model;

            return View(temp);

        }
        public async Task<string> VeriAl(string endpoint)
        {
            int IcerikBaslangicIndex = endpoint.IndexOf("\"") + 1;
            int IcerikBitisIndex = endpoint.Substring(IcerikBaslangicIndex).IndexOf("\"");
            string yazi = endpoint.Substring(IcerikBaslangicIndex, IcerikBitisIndex);
            var httpclient2 = new HttpClient();
            var text2 = await httpclient2.GetStringAsync("http://www.wired.com" + yazi);
            var htmldocument2 = new HtmlDocument();
            htmldocument2.LoadHtml(text2);
            string paragrafhtml;
            if (yazi.Contains("better"))
            {
                paragrafhtml = htmldocument2.DocumentNode.SelectNodes("/html/body/div[1]/div/main/article/div[2]/div/div/div[1]/div[1]/p[2]/text()")[0].InnerText;
                return (paragrafhtml);
            }
            else if (yazi.Contains("story"))
            {
                paragrafhtml = htmldocument2.DocumentNode.SelectNodes("/html/body/div[1]/div/main/article/div[2]/div/div[1]/div[1]/div[1]/p[1]/text()")[0].InnerText;
                return (paragrafhtml);
                
            }
            else {
                paragrafhtml = "Bağlantının linki story ile başlamadığı için yazının xpath adresi değişmiş!";
                return (paragrafhtml);
            }
            
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(MultipleModel multipleModel, IFormCollection form)
        {
            string strDDLValue = form["yazi_listesi"].ToString();
            multipleModel.yazi = strDDLValue;

            foreach (var item in multipleModel.Sorular)
            {
                using (var connection = new SqliteConnection("" +
            new SqliteConnectionStringBuilder
            {
                DataSource = "hello.db"
            }))
                {
                    connection.Open();


                    using (var transaction = connection.BeginTransaction())
                    {
                        var insertCommand = connection.CreateCommand();
                        insertCommand.Transaction = transaction;

                        insertCommand.Parameters.AddWithValue("$yazi", strDDLValue);
                        insertCommand.Parameters.AddWithValue("$soru", item.soru);
                        insertCommand.Parameters.AddWithValue("$A_sikki", item.A_sikki);
                        insertCommand.Parameters.AddWithValue("$B_sikki", item.B_sikki);
                        insertCommand.Parameters.AddWithValue("$C_sikki", item.C_sikki);
                        insertCommand.Parameters.AddWithValue("$D_sikki", item.D_sikki);
                        insertCommand.Parameters.AddWithValue("$cevap", item.cevap.ToString());
                        if (strDDLValue == MyGlobalVariables.yazi1)
                            insertCommand.Parameters.AddWithValue("$baslik", MyGlobalVariables.baslik1);
                        else if (strDDLValue == MyGlobalVariables.yazi2)
                            insertCommand.Parameters.AddWithValue("$baslik", MyGlobalVariables.baslik2);
                        else if (strDDLValue == MyGlobalVariables.yazi3)
                            insertCommand.Parameters.AddWithValue("$baslik", MyGlobalVariables.baslik3);
                        else if (strDDLValue == MyGlobalVariables.yazi4)
                            insertCommand.Parameters.AddWithValue("$baslik", MyGlobalVariables.baslik4);
                        else
                            insertCommand.Parameters.AddWithValue("$baslik", MyGlobalVariables.baslik5);
                        insertCommand.CommandText = "INSERT INTO Sorular (  soru, A_sikki,B_sikki,C_sikki,D_sikki,cevap, yazi, baslik ) VALUES (  $soru, $A_sikki,$B_sikki,$C_sikki,$D_sikki,$cevap, $yazi, $baslik )";
                        insertCommand.ExecuteNonQuery();


                        transaction.Commit();

                    }
                }
            }
            return RedirectToAction("Exams", "Home");
        }
        [Authorize]
        public IActionResult Exams()
        {


            using (var connection = new SqliteConnection("" +
    new SqliteConnectionStringBuilder
    {
        DataSource = "hello.db"
    }))
            {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    var selectCommand = connection.CreateCommand();
                    selectCommand.Transaction = transaction;

                    selectCommand.CommandText = "SELECT DISTINCT baslik FROM Sorular";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        string x;
                        while (reader.Read())
                        {
                            exams_modeli.Add(new exams_model()
                            {

                                baslik = reader.GetString(0)

                            }); ;

                        }
                    }

                    transaction.Commit();

                }
            }
            return View(exams_modeli);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(string baslik)
        {

            using (var connection = new SqliteConnection("" +
                new SqliteConnectionStringBuilder
                {
                    DataSource = "hello.db"
                }))
            {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    var selectCommand = connection.CreateCommand();
                    selectCommand.Transaction = transaction;

                    selectCommand.CommandText = $"SELECT DISTINCT baslik FROM CreateModel where baslik='{baslik}'";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        string x;
                        while (reader.Read())
                        {
                            exams_modeli.Add(new exams_model()
                            {

                                baslik = reader.GetString(0)

                            }); ;

                        }
                    }

                    transaction.Commit();

                }
            }
            return View(exams_modeli.FirstOrDefault());
        } 

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(exams_model model)
        {

            string baslik = model.baslik;

            using (var connection = new SqliteConnection("" +
                new SqliteConnectionStringBuilder
                {
                    DataSource = "hello.db"
                }))
            {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    var selectCommand = connection.CreateCommand();
                    selectCommand.Transaction = transaction;
                    selectCommand.CommandText = $"SELECT DISTINCT yazi FROM CreateModel where baslik='{baslik}'";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yazi_modeli.Add(new yazi_model()
                            {

                                yazi = reader.GetString(0)

                            }); ;

                        }

                    }
                    string x = yazi_modeli.FirstOrDefault().yazi;
                    x = x.Replace("'", "‘");
                    selectCommand.CommandText = $"Delete FROM Sorular where yazi='{x}'";
                    selectCommand.ExecuteNonQuery();


                    selectCommand.CommandText = $"Delete FROM CreateModel where baslik='{baslik}'";
                    selectCommand.ExecuteNonQuery();
                    transaction.Commit();
                }

            }
            return RedirectToAction("Exams");
        }

        [Authorize]
        public IActionResult Sinav(string baslik)
        {
            using (var connection = new SqliteConnection("" +
                new SqliteConnectionStringBuilder
                {
                    DataSource = "hello.db"
                }))
            {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    var selectCommand = connection.CreateCommand();
                    selectCommand.Transaction = transaction;

                    selectCommand.CommandText = $"SELECT * FROM Sorular where baslik='{baslik}'";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        string x;
                        while (reader.Read())
                        {
                            Sinav_Model.Add(new Sinav()
                            {
                                soru_id = reader.GetInt32(0),
                                soru = reader.GetString(1),
                                A_sikki = reader.GetString(2),
                                B_sikki = reader.GetString(3),
                                C_sikki = reader.GetString(4),
                                D_sikki = reader.GetString(5),
                                cevap = reader.GetString(6),
                                yazi = reader.GetString(7),
                                baslik = reader.GetString(8),

                            }); ;

                        }
                    }

                    transaction.Commit();

                }
            }
            return View(Sinav_Model);
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(login p)
        {
            var ad = p.kullanici_adi;
            var sifre = p.sifre;


            using (var connection = new SqliteConnection("" +
                new SqliteConnectionStringBuilder
                {
                    DataSource = "hello.db"
                }))
            {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    var selectCommand = connection.CreateCommand();
                    selectCommand.Transaction = transaction;
                    //KULLANICI KAYIT
                    //selectCommand.Parameters.AddWithValue("$kullanici_adi", ad);
                    //selectCommand.Parameters.AddWithValue("$sifre", sifre);
                    //selectCommand.CommandText = "INSERT INTO login (  kullanici_adi, sifre ) VALUES (  $kullanici_adi, $sifre)";
                    //selectCommand.ExecuteNonQuery();

                    selectCommand.CommandText = $"SELECT kullanici_adi,sifre FROM login where kullanici_adi='{ad}' AND sifre ='{sifre}'";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        string x;
                        while (reader.Read())
                        {
                            c.Add(new login()
                            {
                                kullanici_adi = reader.GetString(0),
                                sifre = reader.GetString(1)

                            }); ;

                        }
                    }

                    transaction.Commit();

                }


                var bilgiler = c.FirstOrDefault();
                if (bilgiler != null)
                {
                    var claims = new List<Claim>
                {  new Claim(ClaimTypes.Name,p.kullanici_adi) };

                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Exams", "Home");
                }
                return View();

            }
        }
    }
}


