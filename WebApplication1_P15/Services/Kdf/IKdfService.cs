namespace ASP_P15.Services.KdfService
{
    public interface IKdfService
    {
        String DerivedKey(String password, String salt);
    }
}
