// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = String.Empty;
    });
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Hello World!");
app.MapGet("/twit", () => "Hey");

app.UseHttpMethodOverride();
app.UseAuthorization();
app.MapControllers();

app.Run();
