using TrilhaOnline.Domain.Entity.Car;

namespace TrilhaOnline.Domain.Interface.Car
{
    /// <summary>
    /// Interface responsável por tornar implícito os métodos que serão
    /// utilizados na manipulação de dados da classe repositório referente 
    /// aos carros da Trilha Car
    /// </summary>
    /// <typeparam name="Request"></typeparam>
    /// <typeparam name="Response"></typeparam>
    public interface ICar<Request, Response> where Request : CarRequestDTO where Response : CarResponseDTO
    {
        /// <summary>
        /// Método de retorno de todos os carros da Trilha Car
        /// </summary>
        /// <returns></returns>
        Response GetAllCars();
        /// <summary>
        /// Método responsável pelo retorno de carros por Id
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Response GetCarById(int idCar);
        /// <summary>
        /// Método responsável pela inclusão de carros da trilha car
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int InsertCar(Request data);
        /// <summary>
        /// Método responsável pela alteração de carros da trilha car
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int UpdateCar(Request data);
        /// <summary>
        /// Método responsável pela exclusão de carros da trilha car
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int DeleteCar(int idCar);
    }
}
