using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Youtrack = Pulumi.Youtrack;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new Youtrack.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

