using System;
using System.Net.Mail;
public class UserServices{
    EmailServices _emailService;
    public UserServices(EmailServices aEmailServices){
        _emailService = aEmailServices;
    }
    public void Register(string email, string password){
        if (!_emailService.ValidateEmail(email))
            throw new Exception("Invalid email address.");
        //other logic
        _emailService.SendEmail(new MailMessage("test@site.com",email){Subject = "Test from SOLID"});
    }
}

public class EmailServices{
    SmtpClient _smtpClient;
    public EmailServices(SmtpClient aSmtpClient){
        _smtpClient = aSmtpClient;
    }
    public bool ValidateEmail(string email){
        return email.Contains("@");
    }
    public void SendEmail(MailMessage message){
        _smtpClient.Send(message);
    }
}