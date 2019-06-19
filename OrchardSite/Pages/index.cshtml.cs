using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;

namespace OrchardSite.Pages
{
    public class indexModel : PageModel
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string numCel { get; set; }
        public string mensaje { get; set; }
        public string host { get; set; }
        public void OnGet()
        {


        }

        public void OnPost()
        {
            nombre = Request.Form[nameof(nombre)];
            correo = Request.Form[nameof(correo)];
            numCel = Request.Form[nameof(numCel)];
            mensaje = Request.Form[nameof(mensaje)];
            //host = Request.Host.ToString();
            //bool seguro = Request.IsHttps;
            //string protocolo = Request.Protocol;
            //String headers = Request.Headers.ToString();
            

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test Mensaje", "chaclaxforever@gmail.com"));
            message.To.Add(new MailboxAddress("martius", "martinballasco@gmail.com"));
            message.Subject = "Contacto en ChaclaForever";
            message.Body = new TextPart("plain")
            {
                Text = $"Hola, soy: \n" +
                       $"Nombre : {nombre} \n" +
                       $"Correo : {correo} \n" +
                       $"Número Celular : {numCel} \n" +
                       $"Mensaje : {mensaje}+\n"+ 
                       $"Host   : {host} \n" 
                       //$"HTTPS ? : {seguro} \n" +
                       //$"Protocolo : {protocolo} \n" +
                       //$"headers : {headers}"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, true);
                client.Authenticate("chaclaxforever@gmail.com", "chaclax123$");
                client.Send(message);
                client.Disconnect(true);
            }
           

        }
    }
}