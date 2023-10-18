using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class RolVsMaestrosController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RolVsMaestrosController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<RolVsMaestrosDto>>> Get()
    {
        var roles = await _unitOfWork.RolVsMaestro.GetAllAsync();
        return _mapper.Map<List<RolVsMaestrosDto>>(roles);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RolVsMaestrosDto>> Get(int id)
    {
        var rol = await _unitOfWork.RolVsMaestro.GetByIdAsync(id);
        if (rol == null)
            return NotFound();
        return _mapper.Map<RolVsMaestrosDto>(rol);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolVsMaestrosDto>> Post([FromBody] RolVsMaestrosDto rolVsMaestrosDto)
    {
        var rol = _mapper.Map<RolVsMaestro>(rolVsMaestrosDto);
        _unitOfWork.RolVsMaestro.Add(rol);
        await _unitOfWork.SaveAsync();
        if (rol == null)
            return BadRequest();
        rolVsMaestrosDto.Id = rol.Id;
        return CreatedAtAction(nameof(Post), new { Id = rolVsMaestrosDto.Id }, rolVsMaestrosDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RolVsMaestrosDto>> Put(int id, [FromBody] RolVsMaestrosDto rolVsMaestrosDto)
    {
        if (rolVsMaestrosDto == null)
            return BadRequest();
        if (rolVsMaestrosDto.Id == 0)
            rolVsMaestrosDto.Id = id;
        if (rolVsMaestrosDto.Id != id)
            return NotFound();
        var rol = _mapper.Map<RolVsMaestro>(rolVsMaestrosDto);
        _unitOfWork.RolVsMaestro.Update(rol);
        await _unitOfWork.SaveAsync();
        return rolVsMaestrosDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var rol = await _unitOfWork.RolVsMaestro.GetByIdAsync(id);
        if (rol == null)
            return NotFound();
        _unitOfWork.RolVsMaestro.Remove(rol);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}