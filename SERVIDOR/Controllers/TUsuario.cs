using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SERVIDOR.models;
using Microsoft.EntityFrameworkCore;
using Blazor.Share;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;


namespace SERVIDOR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TUsuario : ControllerBase
    {
        private readonly BlazorContext _blazorContext;
        public TUsuario(BlazorContext blazorContext)
        {
            _blazorContext = blazorContext;
        }
        //metodo de consulta general de usuarios//

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var RespuestaAPI = new RespuestaAPI<List<UsuarioDTO>>();
            var ListaUsuarioDTO = new List<UsuarioDTO>();
            try
            {
                foreach (var item in await _blazorContext.Usuarios.ToListAsync())
                {
                    ListaUsuarioDTO.Add(new UsuarioDTO
                    {
                        Idusuario = item.Idusuario,
                        TipoUsuario = item.TipoUsuario,
                    });

                }


            }
            catch (Exception ex)
            {
                {
                    RespuestaAPI.RespuestaPeticion = false;
                    RespuestaAPI.Mensaje = ex.Message;
                }
            }
            return Ok(RespuestaAPI);
        }

        //registro para registro de usuario//
        [HttpPost]
        [Route("Registro")]
        public async Task<IActionResult> Registro(UsuarioDTO usuarioGET)
        {
            var RespuestaApi = new RespuestaAPI<int>();
            try
            {
                var DBusuario = new Usuario
                {
                    Idusuario = usuarioGET.Idusuario,
                    TipoUsuario = usuarioGET.TipoUsuario,
                };
                _blazorContext.Usuarios.Add(DBusuario);
                await _blazorContext.SaveChangesAsync();
                if (DBusuario.Idusuario != 0)
                {
                    RespuestaApi.RespuestaPeticion = true;
                    RespuestaApi.Valor = DBusuario.Idusuario;

                }
                else
                {
                    RespuestaApi.RespuestaPeticion = false;
                    RespuestaApi.Mensaje = "Registro no realizado";
                }
            }
            catch (Exception ex)
            {
                RespuestaApi.RespuestaPeticion = false;
                RespuestaApi.Mensaje = ex.Message;

            }
            return Ok(RespuestaApi);
        }
        [HttpPut]
        [Route("Editar/{id}")]
        public async Task<IActionResult> Editar(UsuarioDTO usuario, int id)
        {
            var RespuestaAPI = new RespuestaAPI<int>();
            try
            {
                var DBUsuario = await _blazorContext.Usuarios.FirstOrDefaultAsync(e => e.Idusuario == id);
                if (DBUsuario == null)
                {
                    DBUsuario.Idusuario = usuario.Idusuario;
                    DBUsuario.TipoUsuario = usuario.TipoUsuario;
                    _blazorContext.Usuarios.Update(DBUsuario);
                    await _blazorContext.SaveChangesAsync();
                    RespuestaAPI.RespuestaPeticion = true;
                    RespuestaAPI.Valor = DBUsuario.Idusuario;
                }
                else
                {
                    RespuestaAPI.RespuestaPeticion = false;
                    RespuestaAPI.Mensaje = "Usuario no encontrado";

                }
            }
            catch (Exception ex)
            {

            }
            return Ok(RespuestaAPI);

        }
        //API ELIMINAR USUARIO//
        [HttpDelete]
        [Route("Eiminar/{id}")]

        public async Task<IActionResult> Eliminar(int id)
        {
            var RespuestaApi = new RespuestaAPI<int>();
            try
            {
                var DBUsuario = await _blazorContext.Usuarios.FirstOrDefaultAsync(e => e.Idusuario == id);
                if (DBUsuario != null)
                {
                    _blazorContext.Usuarios.Remove(DBUsuario);
                    await _blazorContext.SaveChangesAsync();
                    RespuestaApi.RespuestaPeticion = true;

                }
                else
                {
                    RespuestaApi.RespuestaPeticion = false;
                    RespuestaApi.Mensaje = "Usuario No encontrado";

                }
            }
            catch (Exception ex)
            {
                RespuestaApi.RespuestaPeticion = false;
                RespuestaApi.Mensaje = ex.Message;

            }
            return Ok(RespuestaApi);
        }
    }
}