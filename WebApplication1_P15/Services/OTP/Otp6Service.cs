namespace ASP_P15.Services.OTP
{
    public class Otp6Service : IOtpService
    {
        public string GeneratePassword()
        {
            return new Random().Next(100000, 999999).ToString();
        }
    }
}
