# NotiApp-SebastianArciniegas

Despues de las entidades se implementan los metodos en los repositorios

Se continua con la Unidad de trabajo (UnitOfWork) que se implementa de la Interfaz de IUnitOfWork

Se crean los Dtos de cada entidad ./Api/Dtos/

Se mapean las entidades en el archivo ./Api/Profiles/MappingProfile //Se implementa el autoMapper en api.csproj

Se Crean las extensiones que se usaran en el contenedor(Program.cs), las extensiones se crean en ./Api/Extensions/ApplicationServiceExtension.cs

implementar las Extensions en el program.cs =>
    builder.Services.AddApplicationService();
    builder.Services.ConfigureRateLimit();
    builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());

Despues del "if(app.Environment.IsDevelopment()) {app.UseSwagger();app.UseSwaggerUI();}"
    app.UseCors("CorsPolicy");


Debajo del "app.UseHttpsRedirection();"
    Colocar "app.UseIpRateLimiting();"

crear BaseController en ./Api/Controllers/ y heredar de Controller Base
        [ApiController]
        [Route("api/notiapp[controller]")]
        public class BaseController : ControllerBase

Los siguientes controladores que se creen heredaran de BaseController
        
