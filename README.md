# RestaurantOpeningHoursTask
The default json payload gets the works done, but it could be better refactored by making it much simpler "monday": [ { "type": "opening_hours", "openhour": 32400, "closehour":72000 } ],

It is expected that the json payload should align with the above structure, as it is meant to reduce executive time and optimise server resources usage.

This project is created with C# programming language, on a Dotnet Core Framework

Design Patterns: Mediator The following packages should be updated.

<PackageReference Include="MediatR" Version="9.0.0" />
<PackageReference Include="MediatR.Extensions.Microsoft.DependencyInjection" Version="9.0.0" />
<PackageReference Include="Swashbuckle.AspNetCore.Swagger" Version="6.1.3" />
<PackageReference Include="Swashbuckle.AspNetCore.SwaggerGen" Version="6.1.3" />
<PackageReference Include="Swashbuckle.AspNetCore.SwaggerUI" Version="6.1.3" />

Kindly endeavour to run a dotnet restore on this solution.
