using Person.Models;
using Person.Data;
using Microsoft.EntityFrameworkCore;

namespace Person.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            //app.MapGet("person", () => "Hello Person!");
            //app.MapGet("person", () => new PersonModel("Fernando"));

            //MapGroup to create the route
            var route = app.MapGroup("person");

            route.MapPost
                (
                    //Route
                    "",

                    //Handler
                    async (PersonRequest req, PersonContext context) =>
                    {
                        var person = new PersonModel(req.Name);
                        
                        //Insert
                        await context.AddAsync(person);
                        
                        //Commit
                        await context.SaveChangesAsync();
                    }
                );

            route.MapGet
                (
                    "",
                    async (PersonContext context) =>
                    {
                       var person = await context.People.ToListAsync();
                        return Results.Ok(person);
                    }
                );

            route.MapPut
                (
                    "{id:guid}",
                    async (Guid id, PersonRequest req, PersonContext context) =>
                    {
                        //var person = await context.People.FindAsync(id);
                        var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

                        if (person == null)
                        {
                            return Results.NotFound();
                        }

                        person.UpdateName(req.Name);

                        await context.SaveChangesAsync();

                        return Results.Ok(person);

                    }
                );

            route.MapDelete
                (
                    "{id:guid}",
                    async (Guid id, PersonContext context) =>
                    {
                        var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

                        if (person == null)
                        {
                            return Results.NotFound();
                        }

                        context.People.Remove(person);

                        await context.SaveChangesAsync();

                        return Results.Ok(person);
                    }
                );
        }
    }
}
