using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamoDb.Libs.DynamoDb;   
using Microsoft.AspNetCore.Mvc;

namespace DynamoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamoDbController : Controller
    {
        private readonly IDynamoDbExamples _dynamoDbExample;

        public DynamoDbController(IDynamoDbExamples dynamoDbExample)
        {
            _dynamoDbExample = dynamoDbExample;
        }

        [Route("createtable")]
        public IActionResult CreateDynamoDbTable()
        {
            _dynamoDbExample.CreateDynamoDbTable();
            return Ok();
        }
    }
}