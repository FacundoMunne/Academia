namespace BibliotecaDeClases
{
    public class BusinessEntity
    {
        private int _ID;
        private States _State;

        public int ID { get => _ID; set => _ID = value; }
        public States Sate { get => _State; set => _State = value; }

        public enum States
        {
            Activo,
            Inactivo,
            Pendiente
        }
    }
}
