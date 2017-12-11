using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerDemo
{
    /// <summary>
    /// SwaggerDemo controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class HomeController: Controller
    {
        /// <summary>
        /// returns today's date
        /// </summary>
        /// <returns>string message</returns>
        [HttpGet("")]
        public Task<string> Index() => Task.FromResult($"Hello, Today is {DateTime.Now}");
        /// <summary>
        /// returns day string for given date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>day of week string</returns>
        [HttpGet("WhatDayIsIt")]
        public Task<string> WhatDayisit(DateTime date) => Task.FromResult(date.DayOfWeek.ToString());
        /// <summary>
        /// create a new date item
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateDate(string date)
        {
            return CreatedAtAction("Get", new { date = DateTime.Now.ToShortDateString() }, new { });
        }

    }
}
