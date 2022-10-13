namespace BreeceWorks.IDP.DuendeIdentityServer.Entities
{
    public interface IConcurrencyAware
    {
        string ConcurrencyStamp { get; set; }
    }
}
