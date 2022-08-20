using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using TrainingService.Interface;
using TrainingService.Model;
using TrainingService.Model.Training;

namespace TrainingAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class RegisterController : ControllerBase
    {
        private readonly IExerciseRegisterService _exerciseRegisterService;
        private readonly ITrainingRegisterService _trainingRegisterService;

        public RegisterController(IExerciseRegisterService exerciseRegisterService,
                                  ITrainingRegisterService trainingRegisterService)
        {
            _exerciseRegisterService = exerciseRegisterService; 
            _trainingRegisterService = trainingRegisterService;
        }

        [HttpPost($"Register/{nameof(Exercise)}")]
        public IActionResult Exercise([FromBody] ExerciseRegisterModel exercise)
        {
            try
            {
                _exerciseRegisterService.Register(exercise);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost($"Register/{nameof(Training)}")]
        public IActionResult Training([FromBody] TrainingRegisterModel training)
        {
            try
            {
                _trainingRegisterService.Register(training);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}