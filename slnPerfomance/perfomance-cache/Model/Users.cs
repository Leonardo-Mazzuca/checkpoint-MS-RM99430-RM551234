namespace perfomance_cache.Model
{
    public class Users
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public DateTime UltimoAcesso { get; set; }
    }
}
