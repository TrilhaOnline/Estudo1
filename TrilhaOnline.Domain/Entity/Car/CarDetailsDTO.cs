namespace TrilhaOnline.Domain.Entity.Car
{
    /// <summary>
    /// Classe responsável pela cosntrução de parâmetros 
    /// relacionados as partes do carro da trilha car, e utilizados no objeto request e response 
    /// dos construtores principais
    /// </summary>
    public class CarDetailsDTO
    {
        public int idCar { get; set; }
        public string nameCar { get; set; }
        public string versionCar { get; set; }
        public string yearCar { get; set; }
        public string hourValueCar { get; set; }
    }
}
