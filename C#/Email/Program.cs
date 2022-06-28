using System;
using System.IO;

using MailKit.Net.Smtp;
using MimeKit;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Initialize To, From and Subject
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Example", "example@example.com"));
                message.To.Add(new MailboxAddress("Example", "example@example.com"));
                message.Subject = "Example";
                var path = args[0];

                // Create the message text
                var body = new TextPart("plain")
                {
                    Text = @"Test"
                };

                var attachment = new MimePart("document", "pdf")
                {
                    Content = new MimeContent(File.OpenRead(path), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(path)
                };

                // now create the multipart/mixed container to hold the message text and the
                // image attachment
                Multipart multipart = new("mixed")
                {
                    body,
                    attachment
                };

                // now set the multipart/mixed as the message body
                message.Body = multipart;

                using SmtpClient client = new();
                client.Connect("smtp.example.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("example@example.com", "Insert Password Here");

                client.Send(message);
                client.Disconnect(true);
            }
            catch
            {
                Console.Write("No file path was detected.\n" + "Please enter a file path after the application.\n" + "Press any key to exit.\n");
            }
        }
    }
}

