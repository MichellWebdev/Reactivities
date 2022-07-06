using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

  [ApiController]
  // "controller" is a placeholder that gets replaced with whatever the controller class name is minus the word controller so in this case "BaseApi"
  [Route("api/[controller]")]
  public class BaseApiController : ControllerBase
  {

  }
}