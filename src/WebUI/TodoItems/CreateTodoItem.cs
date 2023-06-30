using CleanArchitecture.Application.TodoItems.Commands.CreateTodoItem;

namespace CleanArchitecture.WebUI.TodoItems;

public class CreateTodoItem : EndpointBase
{
    public override void Map(WebApplication app)
    {
        MapPost(app,
            async (ISender sender, CreateTodoItemCommand command) => await sender.Send(command));
    }
}
