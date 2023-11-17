﻿using CineCordobaBack.Entidades;
using CordobaCineBack.Entidades;
using CordobaCineBack.Fachada.Implementacion;
using CordobaCineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CordobaCineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CineController : ControllerBase
    {
        private IAplicacion app;

        public CineController()
        {
            app = new Aplicacion();
        }
        // GET: api/<CineController>
        [HttpGet("/generos")]

        public IActionResult GetGeneros()
        {
            List<Generos> lgenero = null;
            try
            {
                lgenero = app.TraerGeneros();
                return Ok(lgenero);
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno");
            }
        }

        [HttpGet("/VentasVacaciones")]
        public IActionResult GetEntregasSegunFecha(int genero,string vacaciones)
        {
            List<DetalleComprobante> lstvacas;
            try
            {
                lstvacas = app.ObtenerConsultaVacacion(genero, vacaciones);
                return Ok(lstvacas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }
        [HttpGet("/Sucursales")]
        public IActionResult GetSucursales()
        {
            List<Sucursales> lsuc = null;
            try
            {
                lsuc = app.TraerSucursales();
                return Ok(lsuc);
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno");
            }
        }
        [HttpGet("/Peliculas")]
        public IActionResult GetPeliculas()
        {
            List<Peliculas> lpeli = null;
            try
            {
                lpeli = app.traerPeliculas();
                return Ok(lpeli);
            }
            catch (Exception)
            {

                return StatusCode(500, "Error Interno");
            }
        }

        [HttpGet("/Ganancia")]
        public IActionResult GetGanancias(int sucursal, int peliculas)
        {
            List<Comprobantes> lstdeta;
            try
            {
                lstdeta = app.ConsultarGanancia(sucursal, peliculas);
                return Ok(lstdeta);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

    }
}
