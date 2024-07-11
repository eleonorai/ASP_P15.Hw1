using ASP_P15.Services.Hash;
using ASP_P15.Services.KdfService;

namespace ASP_P15.Services.Kdf
{
    // Згідно з пунктом 5.1 стандарту RFC 2898
    public class Pbkdf1Service(IHashService hashService) : IKdfService
    {
        private readonly IHashService _hashService = hashService;
        public string DerivedKey(string password, string salt)
        {
            String t1 = _hashService.Digest(password + salt);
            String t2 = _hashService.Digest(t1);
            return t2;
        }
    }
}
