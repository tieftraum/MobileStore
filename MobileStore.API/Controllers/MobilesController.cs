using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Domain.Interfaces;
using MobileStore.Domain.Models;
using MobileStore.Domain.Resources;

namespace MobileStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilesController : ControllerBase
    {
        private readonly IMobilePhonesRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MobilesController(IMobilePhonesRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobilePhone>>> GetPhones()
        {
            var result =  await _repository.GetMobilePhones();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(new { result });

        }

        [HttpGet("{mobileId}")]
        public async Task<IActionResult> GetPhone(int mobileId)
        {
            var mobile = await _repository.GetMobileAsync(mobileId);

            if (mobile==null)
            {
                return NotFound();
            }
            return Ok(new { mobile });
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<MobilePhoneResource>>> GetMobileFromSearch([FromQuery]MobilePhoneFilterSearchResource resource)
        {
            var result = await _repository.GetMobilePhonesFromSearchFilter(resource);

            if (result == null)
            {
                return NotFound();
            }

            var mappedResult = _mapper.Map<IEnumerable<MobilePhone>, IEnumerable<MobilePhoneResource>>(result);

            return Ok(new { mappedResult });
        }
    }
}
