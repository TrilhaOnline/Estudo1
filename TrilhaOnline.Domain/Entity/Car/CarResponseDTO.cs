namespace TrilhaOnline.Domain.Entity.Car
{
    /// <summary>
    /// Classe responsável pelo retorno do objeto com os parâmetros
    /// referente aos carros da Trilha Car e parâmetros indicadores de sucesso
    /// e mensagerias de retorno
    /// </summary>
    public class CarResponseDTO
    {
        public bool hasSuccess { get; set; }
        public string message { get; set; }   
        public CarDetailsDTO[] details { get; set; }
    }    
}
