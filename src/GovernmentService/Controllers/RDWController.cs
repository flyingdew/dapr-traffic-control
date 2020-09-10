﻿using GovernmentService.Models;
using GovernmentService.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GovernmentService.Controllers
{
    [ApiController]
    public class RDWController : ControllerBase
    {
        private readonly ILogger<RDWController> _logger;
        private readonly IVehicleInfoRepository _vehicleInfoRepository;

        public RDWController(ILogger<RDWController> logger, IVehicleInfoRepository vehicleInfoRepository)
        {
            _logger = logger;
            _vehicleInfoRepository = vehicleInfoRepository;
        }

        [Route("rdw")]
        [HttpGet("rdw/vehicle/{licenseNumber}")]
        public ActionResult GetVehicleDetails(string licenseNumber)
        {
            VehicleInfo info = _vehicleInfoRepository.GetVehicleInfo(licenseNumber);
            return Ok(info);
        }
    }
}