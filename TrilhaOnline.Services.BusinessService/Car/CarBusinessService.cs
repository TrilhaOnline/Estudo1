using TrilhaOnline.Domain.Entity.Car;
using TrilhaOnline.Infra.Data.Repository.Rent.Car;

namespace TrilhaOnline.Services.BusinessService.Car
{
    /// <summary>
    /// Classe de negócios responsável pelo tratamento de regras na adminsitração
    /// de carros da trilha car
    /// </summary>
    public class CarBusinessService
    {
        private CarResponseDTO _responseCars;
        private CarRepository<CarRequestDTO, CarResponseDTO> _repository;

        /// <summary>
        /// Método construtor
        /// </summary>
        public CarBusinessService()
        {
            _responseCars = new CarResponseDTO();
            _responseCars.details = new CarDetailsDTO[] { };
            _repository = new CarRepository<CarRequestDTO, CarResponseDTO>();
        }

        /// <summary>
        /// Método responsável pelo retorno de todos os carros da trilha car
        /// </summary>
        /// <returns></returns>
        public CarResponseDTO GetAllCars()
        {
            var resultDetails = _repository.GetAllCars();
            if (resultDetails.details.Length > 0)
            {
                _responseCars.hasSuccess = true;
                _responseCars.message = "data returned successfully";
                _responseCars.details = resultDetails.details;
            }
            else
            {
                _responseCars.hasSuccess = false;
                _responseCars.message = "did not return records";
                _responseCars.details = new CarDetailsDTO[0] { };
            }
            return _responseCars;
        }

        /// <summary>
        /// Método Responsável pela inclusão de carros da nossa trilha Car
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool InsertCar(CarRequestDTO data)
        {
            if (_repository.InsertCar(data) > 0)
                return true;
            else
                return false;
        }
    }
}
