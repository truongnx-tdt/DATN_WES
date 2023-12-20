// <copyright file="ChartsController.cs" ownedby="Xuan Truong">
//  Copyright (c) XuanTruong. All rights reserved.
//  FileType: Visual CSharp source file
//  Created On: 20/12/2023
//  Last Modified On: 20/12/2023
//  Description: ChartsController.cs
// </copyright>

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudySystem.Data.Models.Response;

namespace StudySystem.Controllers
{
    [ApiController]
    public class ChartsController : ControllerBase
    {

        public ChartsController()
        {

        }

        [HttpGet("~/api/get-statistic")]
        public async Task<ActionResult<StudySystemAPIResponse<object>>> GetStatictic()
        {
            return new StudySystemAPIResponse<object>(StatusCodes.Status200OK, new Response<object>(true, new object()));
        }
    }
}
