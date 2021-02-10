using AutoItX3Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class mailLogin
    {
        public static int dosyaSayisi, i = 0, control = 0;
        public IWebDriver driver { get; set; }
        public int mailLog(string mail, string pass)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                //options.EnableMobileEmulation("iPhone 6");
                //options.AddArgument("--headless");
                driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://www.instagram.com/");
                Thread.Sleep(2000);
                Thread.Sleep(2000);
                IWebElement Login = driver.FindElement(By.XPath("//button[contains(text(), 'Giriş Yap')]"));


                Login.Click(); Thread.Sleep(2500);

                IWebElement userName = driver.FindElement(By.Name("username"));
                IWebElement password = driver.FindElement(By.Name("password"));




                userName.SendKeys("Gladyo2035");
                password.SendKeys("musto321");
                Thread.Sleep(2500);
                IWebElement loginBtn = driver.FindElement(By.XPath("//button[contains(.,'Giriş Yap')]"));
                loginBtn.Click();
                Thread.Sleep(3500);
                //driver.Navigate().GoToUrl("https://www.instagram.com/accounts/onetap/?next=%2F");
                //IWebElement SimdiDegil = driver.FindElement(By.XPath("//button[contains(.,'Şimdi Değil')]"));


                //SimdiDegil.Click(); Thread.Sleep(2500);
                //IWebElement SimdiDegil2 = driver.FindElement(By.XPath("//button[contains(text(), 'İptal')]"));
                //SimdiDegil2.Click();
                return (control);
            }
            catch (Exception)
            {
                driver.Quit();
                MessageBox.Show("Bir hata meydana geldi hesap bilgilerinizi ya da internet hızınızı kontrol edin");
                return (control);

            }

            
            ////driver.Navigate().GoToUrl("https://www.instagram.com/");
        }

        public int FaceLog(string mail, string pass)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.EnableMobileEmulation("iPhone 6");
                driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://www.instagram.com/");
                Thread.Sleep(2000);
                Thread.Sleep(2000);
                IWebElement Login = driver.FindElement(By.XPath("//button[contains(text(), 'Giriş Yap')]"));
                Login.Click(); Thread.Sleep(2500);

                driver.FindElement(By.XPath("//form[@id='loginForm']/div/div/button/span[2]")).Click();
                IWebElement userName = driver.FindElement(By.Name("email"));
                IWebElement password = driver.FindElement(By.Name("pass"));
                userName.SendKeys("m.zeycan20@hotmail.com");
                password.SendKeys("mzeycan2035");
                Thread.Sleep(2500);
                IWebElement loginBtn = driver.FindElement(By.XPath("//button[contains(.,'Giriş Yap')]"));
                loginBtn.Click();
                Console.WriteLine("Hesap Bilgileri Girildi!");
                Thread.Sleep(2500);
                //driver.Navigate().GoToUrl("https://www.instagram.com/accounts/onetap/?next=%2F");
                IWebElement SimdiDegil = driver.FindElement(By.XPath("//button[contains(.,'Şimdi Değil')]"));


                SimdiDegil.Click(); Thread.Sleep(2500);
                IWebElement SimdiDegil2 = driver.FindElement(By.XPath("//button[contains(text(), 'İptal')]"));
                SimdiDegil2.Click();
                return (control);
            }
            catch (Exception)
            {

                MessageBox.Show("Yanlış şifre girdiniz");
                driver.Quit();
                return (control);

            }
        }
            public void mailShare()
        {
            IWebElement SimdiDegil2 = driver.FindElement(By.XPath("//button[contains(text(), 'İptal')]"));
            SimdiDegil2.Click();
            string yol = "Data source=Insta.db3";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            
            baglanti.Open();
            string sql = "Select * From Images where Date ='" + DateTime.Now.Date.ToString("dd/MM/yyyy") +"' and Time ='"+ DateTime.Now.ToString("HH:mm")+"'";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            SQLiteDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string loc = @reader["Location"].ToString();
                try
                {
                    IWebElement Fileupload = driver.FindElement(By.XPath("//div[@id='react-root']/section/nav[2]/div/div/div[2]/div/div/div[3]"));
                    AutoItX3 autoit = new AutoItX3();
                    Fileupload.Click();
                    Thread.Sleep(1000);
                    autoit.WinActivate("Aç");
                    Thread.Sleep(1000);
                    autoit.Send(@reader.GetString(1));
                    autoit.Send("{ENTER}");
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//button[contains(.,'İleri')]")).Click();
                    Thread.Sleep(2000);
                    IWebElement aciklama=driver.FindElement(By.XPath("//div[@id='react-root']/section/div[2]/section/div/textarea"));
                    aciklama.SendKeys(reader.GetString(4));
                    driver.FindElement(By.XPath("//button[contains(.,'Paylaş')]")).Click();
                    Thread.Sleep(6000);
                    if (i == 0)
                    {
                        driver.FindElement(By.XPath("//button[contains(.,'Şimdi Değil')]")).Click();
                    }
                    Thread.Sleep(2000);
                    i++;
                    SQLiteCommand sil = new SQLiteCommand("delete from Images where id = '" + id.ToString() + "'", baglanti);
                    sil.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    driver.Quit();
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                
            }
        }
        public void Follow(int takip )
        {
            
            string[] stringSeparators = new string[] { "\r\n" };
            driver.FindElement(By.XPath("//div[@id='react-root']/section/nav[2]/div/div/div[2]/div/div/div[5]/a/span/img")).Click();
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.XPath("//li[3]/a"));
            string takipci = element.Text;
            IWebElement name = driver.FindElement(By.XPath("//h2"));
            string nicki = name.Text;
            string[] takipcim = takipci.Split(stringSeparators, StringSplitOptions.None);
            
            element.Click();
            Thread.Sleep(2000);
            for (int i = 1; i <= Convert.ToInt32(takipcim[0]); i++)
            {

                IWebElement kullanıcı = driver.FindElement(By.XPath("//li[" + i + "]/div/div[2]/div/div/div/a"));
                //*[@id='react - root']/section/main/div/ul/div/li["+i+ "]
                kullanıcı.Click();
                Thread.Sleep(2000);

                IWebElement takipci2 = driver.FindElement(By.XPath("//li[3]/a"));
                string sayi = takipci2.Text;
                string[] takipcisayisi = sayi.Split(stringSeparators, StringSplitOptions.None);

                driver.FindElement(By.XPath("//li[3]/a")).Click();
                Thread.Sleep(2000);

                if (Convert.ToInt32(takipcisayisi[0])>=takip)
                {
                    for (int j = 1; j <= takip; j++)
                    {
                        string jsCommand = "" +
                        "window.scrollTo(0," + 54 * j + ");";
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        IWebElement buttons = driver.FindElement(By.XPath("//li[" + j + "]/div/div[2]/button"));
                        if ("Takip Et" == buttons.Text)
                        {
                            buttons.Click();
                            Thread.Sleep(1000);

                        }
                        js.ExecuteScript(jsCommand);
                    }
                }
                else
                {
                    for (int j = 1; j <= Convert.ToInt32(takipcisayisi[0]); j++)
                    {
                        string jsCommand = "" +
                        "window.scrollTo(0," + 54 * j + ");";
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        IWebElement buttons = driver.FindElement(By.XPath("//li[" + j + "]/div/div[2]/button"));
                        if ("Takip Et" == buttons.Text)
                        {
                            buttons.Click();
                            Thread.Sleep(1000);

                        }

                        js.ExecuteScript(jsCommand);

                    }
                }
                
                driver.Navigate().GoToUrl("https://www.instagram.com/" + nicki + "/following/");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//li[3]/a")).Click();
                Thread.Sleep(2000);
            }
        }
        public void KontrolluFollow(string name, int sayi)
        {
                int t = 2;
                string[] stringSeparators = new string[] { "\r\n" };
                driver.Navigate().GoToUrl("https://www.instagram.com/" + name + "/");
                IWebElement takipci2 = driver.FindElement(By.XPath("//li[2]/a"));
                string sayi2 = takipci2.Text;
                string[] takipcisayisi = sayi2.Split(stringSeparators, StringSplitOptions.None);

            driver.FindElement(By.XPath("//li[3]/a")).Click();
            //driver.Navigate().GoToUrl("https://www.instagram.com/" + name + "/followers/");
            Thread.Sleep(2000);
                while (0 <= sayi)
                {
                    try
                    {
                     string jsCommand = "" +
                        "window.scrollTo(0," + 54 * t + ");";
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript(jsCommand);
                    IWebElement buttons = driver.FindElement(By.CssSelector(".wo9IH:nth-child("+t+") .sqdOP"));

                        if ("Takip Et" == buttons.Text)
                        {
                            buttons.Click();
                            Thread.Sleep(1000);
                            sayi--;
                        }
                        t++;
                        
                        //if (Convert.ToInt32(takipcisayisi[0]) == i)
                        //{js.ExecuteScript(jsCommand);
                        //    break;
                        //}
                    }
                    catch (Exception)
                    {
                    
                    t++;
                        continue;
                    }
                    
                }
            }
        public int mailLog2(string mail, string pass)
        {
            try
            {
                DesiredCapabilities capabilities = new DesiredCapabilities();
                string user_agent = "Mozilla/5.0 (iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en-us) AppleWebKit/528.18 (KHTML, like Gecko) Version/4.0 Mobile/7A341 Safari/528.16";
                var options = new FirefoxOptions();
                //options.AddAdditionalCapability("device", "iPhone 11");
                options.SetPreference("general.useragent.override", user_agent );
                //options.AddArguments("-headless");
                driver = new FirefoxDriver(options);
                driver.Navigate().GoToUrl("https://www.instagram.com/");
                Thread.Sleep(2000);
                Thread.Sleep(2000);
                IWebElement Login = driver.FindElement(By.XPath("//button[contains(text(), 'Giriş Yap')]"));


                Login.Click(); Thread.Sleep(2500);

                IWebElement userName = driver.FindElement(By.Name("username"));
                IWebElement password = driver.FindElement(By.Name("password"));




                userName.SendKeys("Gladyo2035");
                password.SendKeys("musto321");
                Thread.Sleep(2500);
                IWebElement loginBtn = driver.FindElement(By.XPath("//button[contains(.,'Giriş Yap')]"));
                loginBtn.Click();
                Thread.Sleep(3500);
                //driver.Navigate().GoToUrl("https://www.instagram.com/accounts/onetap/?next=%2F");
                //IWebElement SimdiDegil = driver.FindElement(By.XPath("//button[contains(.,'Şimdi Değil')]"));
                //SimdiDegil.Click();
                //Thread.Sleep(2500);
                //IWebElement SimdiDegil2 = driver.FindElement(By.XPath("//button[contains(text(), 'İptal')]"));
                //SimdiDegil2.Click();
                return (control);
            }
            catch (Exception)
            {
                driver.Quit();
                MessageBox.Show("Bir hata meydana geldi hesap bilgilerinizi ya da internet hızınızı kontrol edin");
                return (control);

            }


            ////driver.Navigate().GoToUrl("https://www.instagram.com/");
        }

    }
}
