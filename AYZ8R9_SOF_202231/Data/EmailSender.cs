﻿using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Identity.UI.Services;

    public class EmailSender : IEmailSender
    {

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                UseDefaultCredentials = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("SBence@stud.uni-obuda.hu", "Megbuktamarhin1"),
                TargetName = "STARTTLS/smtp.office365.com",
                EnableSsl = true

            })
            {
                MailMessage message = new MailMessage()
                {
                    From = new MailAddress("SBence@stud.uni-obuda.hu"),
                    Subject = subject,
                    IsBodyHtml = true,
                    Body = htmlMessage,
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                };
                message.To.Add(email);

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {

                }
            }
            return Task.CompletedTask;
        }
    }

