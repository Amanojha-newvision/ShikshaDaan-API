namespace Entity
{
    public class SetupAccount
    {
        public int Id { get; set; }
        public string SuperAdminEmail { get; set; } = string.Empty;
        public string CreatePassword { get; set; }
        public string ConfirmPassword { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
