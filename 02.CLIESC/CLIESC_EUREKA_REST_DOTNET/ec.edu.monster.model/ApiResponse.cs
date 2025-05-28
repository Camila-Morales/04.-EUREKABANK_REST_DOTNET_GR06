namespace ec.edu.monster.model
{
    public class ApiResponse<T>
    {
        public string Mensaje { get; set; }
        public T Response { get; set; }
    }
}
