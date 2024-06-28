# Blazor Puzzle #39

## What The Form!

YouTube Video: https://youtu.be/GDaB12I7iFI

Blazor Puzzle Home Page: https://blazorpuzzle.com

### The Challenge:

This is a .NET 8 Blazor Web App with no interactivity and an EditForm. 

Even though the model properties are required, we are getting validation errors when we submit the form.

How can we fix this?

### The Solution:

Update the @code block with this:

```c#
@code {

    [SupplyParameterFromForm]
    private NewUserModel newUser { get; set; }

    string Message { get; set; } = string.Empty;

    protected override void OnInitialized()
    {
        newUser ??= new NewUserModel();
    }

    private void CreateUser()
    {
        Message = $"New User {newUser.Name} Created";
    }
}
```

newUser is only created if it's not supplied by the form. 

Boom!