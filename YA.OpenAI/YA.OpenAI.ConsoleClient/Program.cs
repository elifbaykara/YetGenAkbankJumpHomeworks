using OpenAI.Managers;
using OpenAI;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;


var openAiService = new OpenAIService(new OpenAiOptions()
{
    ApiKey = ""
});

while (true)
{

    Console.WriteLine("Please enter your prompt.");

    var usersPrompt = Console.ReadLine();

    var imageResult = await openAiService.Image.CreateImage(new ImageCreateRequest
    {
        Prompt = usersPrompt,
        N = 3,
        Size = StaticValues.ImageStatics.Size.Size256,
        ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
        User = "TestUser"
    });


    if (imageResult.Successful)
    {
        Console.WriteLine(string.Join("\n", imageResult.Results.Select(r => r.Url)));
    }

    Console.ReadLine();
}