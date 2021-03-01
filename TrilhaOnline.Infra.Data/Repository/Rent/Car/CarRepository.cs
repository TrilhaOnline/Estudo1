using Dapper;
using System;
using System.Data;
using System.Linq;
using TrilhaOnline.Domain.Entity.Car;
using TrilhaOnline.Domain.Interface.Car;
using TrilhaOnline.Infra.Data.Context;

namespace TrilhaOnline.Infra.Data.Repository.Rent.Car
{
    /// <summary>
    /// Classe responsável pela manipulação de dados junto ao Banco de Dados do Trilha car
    /// Específico para manipulação de dados dos carros da Trilha Car
    /// </summary>
    /// <typeparam name="Request"></typeparam>
    /// <typeparam name="Response"></typeparam>
    public class CarRepository<Request, Response> : ICar<Request, Response> where Request : CarRequestDTO where Response : CarResponseDTO
    {
        private Response _response;

        /// <summary>
        /// Método construtor
        /// </summary>
        public CarRepository()
        {
            _response = (Response)new CarResponseDTO();
        }

        /// <summary>
        /// Método interno de conexão com o Banco
        /// </summary>
        internal IDbConnection Connect
        {
            get => BaseContext.Conn();
        }        

        /// <summary>
        /// Método implícito da interface, responsável pelo retorno dos carros da Trilha Car
        /// </summary>
        /// <returns></returns>
        public Response GetAllCars()
        {
            using (IDbConnection cn = Connect)
            {
                if(cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                _response.details = new CarDetailsDTO[] { };
                _response.details = cn.Query<CarDetailsDTO>("SP_TRL_GET_CARS", new { }, commandType: CommandType.StoredProcedure).ToArray();

                return _response;
            }
        }

        /// <summary>
        /// Método implícito da interface, responsável pelo retorno de carros por ID da Trilha Car
        /// </summary>
        /// <param name="idCar"></param>
        /// <returns></returns>
        public Response GetCarById(int idCar)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método implícito da interface, responsável pela inclusão de carros da Trilha Car
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int InsertCar(Request data)
        {
            using (IDbConnection cn = Connect)
            {
                if(cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                var result = cn.Execute("SP_TRL_INSERT_CARS", new
                {
                    @nameCar = data.nameCar,
                    @versionCar = data.versionCar,
                    @yearCar = data.yearCar,
                    @hourValueCar = data.hourValueCar
                }, commandType: CommandType.StoredProcedure);
                
                return result;
            }
        }

        /// <summary>
        /// Método implícito da interface, responsável pela alteração de carros da Trilha Car
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int UpdateCar(Request data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método implícito da interface, responsável pelo exclusão de carros da Trilha Car
        /// </summary>
        /// <param name="idCar"></param>
        /// <returns></returns>
        public int DeleteCar(int idCar)
        {
            throw new NotImplementedException();
        }
    }
}
