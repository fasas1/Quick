using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickLogistics.Models;
using QuickLogistics.Models.Dto;
using QuickLogistics.Repository;
using QuickLogistics.Repository.IRepository;
using System.Net;

namespace QuickLogistics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentRepository _dbShipment;
        private IMapper _mapper;
        private readonly APIResponse _response;
        public ShipmentController(IShipmentRepository dbShipment, IMapper mapper)
        {
            _dbShipment = dbShipment;
            _response = new APIResponse();
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetShipments()
        {
            try
            {
                var shipmentList = await _dbShipment.GetAllAsync(
                   includeProperties: "Vehicle,Driver" );

                _response.Result = _mapper.Map<List<ShipmentDto>>(shipmentList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<APIResponse>> GetShipment(int id)
        {
            try
            {
             if(id == 0)
                {
                     _response.IsSuccess = false;
                     _response.StatusCode=HttpStatusCode.BadRequest;
                     return BadRequest(_response);
                }
                
              Shipment shipment = await _dbShipment.GetAsync(u => u.ShipmentId == id, includeProperties: "Vehicle,Driver");
                if(shipment == null)
                {
                    _response.IsSuccess = false;
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = _mapper.Map<ShipmentDto>(shipment);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message }; ;
            }
            return _response;
        }

    }
}
