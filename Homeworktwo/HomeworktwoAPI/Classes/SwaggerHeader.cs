using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace HomeworktwoAPI.Classes
{
    public class SwaggerHeader: IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "app-version",
                In = ParameterLocation.Header,
                Description="Enter version key",
                
                Schema = new OpenApiSchema
                {
                    Type = "float"
                }
                
            });
        }
    }
}
