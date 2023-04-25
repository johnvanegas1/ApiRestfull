using DTO_s;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using UsesCases.ActualizarClientes;
using UsesCases.CreaciónUsuario;
using UsesCases.ObtenerClientes;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        readonly ICreateClientInputPort _inputPort;
        readonly ICreateClientOutputPort _outputPort;
        readonly IGetClientsInputPort _getClientsInputPort;
        readonly IGetClientsOutputPort _getClientsOutputPort;
        readonly IUpdateClientInputPort _updateClientInputPort;
        readonly IUpdateClientOutputPort _updateClientOutputPort;

        public ClientesController(ICreateClientInputPort inputPort, ICreateClientOutputPort outputPort, IGetClientsInputPort getClientsInputPort, 
            IGetClientsOutputPort getClientsOutputPort, IUpdateClientInputPort updateClientInputPort, IUpdateClientOutputPort updateClientOutputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
            _getClientsInputPort = getClientsInputPort;
            _getClientsOutputPort = getClientsOutputPort;
            _updateClientInputPort = updateClientInputPort;
            _updateClientOutputPort = updateClientOutputPort;
        }




        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<ClienteOutDTO> Get()
        {
            try
            {
                _getClientsInputPort.Handler();
                return ((IPresenters<IEnumerable<ClienteOutDTO>>)_getClientsOutputPort).Content;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IEnumerable<ClienteOutDTO> Get(int id)
        {
            _getClientsInputPort.Handler(id);
            return ((IPresenters<IEnumerable<ClienteOutDTO>>)_getClientsOutputPort).Content; 
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ClienteOutDTO> Post(ClienteDTO cliente)
        {
            await _inputPort.Handler(cliente);
            return ((IPresenters<ClienteOutDTO>)_outputPort).Content;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ClienteOutDTO Put(int id, [FromBody] ClienteDTO cliente)
        {
            _updateClientInputPort.Handler(id, cliente);
            return ((IPresenters<ClienteOutDTO>)_updateClientOutputPort).Content;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
