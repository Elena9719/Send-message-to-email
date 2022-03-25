using System;
using System.Net;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Diagnostics;

namespace NetConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(10000);
           

            MailAddress from = new MailAddress("argfgahatha.com", "Tommmm");
            MailAddress to = new MailAddress("fdgdfghtgh@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Attachments.Add(new Attachment("C://AHDL82Setup.log"));
            m.Subject = "Tecт";
            m.Body = "<h2>письмо тест работы smtp сервера </ h2 >";
            m.IsBodyHtml = true;
           
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("hgjdjjx9@gmail.com", "password");//email,password
            smtp.EnableSsl = true;
            smtp.Send(m);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

      
        }

    }

    
