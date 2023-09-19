namespace ECM.dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int FamiliaId { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
    }
}