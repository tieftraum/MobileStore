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
        public async Task<ActionResult<IEnumerable<MobilePhoneResource>>> GetPhones()
        {
            var result =  await _repository.GetMobilePhones();

            if (result == null)
            {
                return NotFound();
            }

            var mapped = _mapper.Map<IEnumerable<MobilePhoneResource>>(result);
            return Ok(new { mapped });
        }

        [HttpGet("{mobileId}")]
        public async Task<ActionResult<MobilePhoneResource>> GetPhone(int mobileId)
        {
            var mobile = await _repository.GetMobileAsync(mobileId);

            if (mobile==null)
            {
                return NotFound();
            }

            var mapped = _mapper.Map<MobilePhoneResource>(mobile);
            return Ok(new { mapped });
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<MobilePhoneResource>>> GetMobileFromSearch([FromQuery]MobilePhoneFilterSearchResource resource)
        {
            var result = await _repository.GetMobilePhonesFromSearchFilter(resource);

            if (result == null)
            {
                return NotFound();
            }

            var mapped = _mapper.Map<IEnumerable<MobilePhoneResource>>(result);

            return Ok(new { mapped });
        }
    }
}
