using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCreator.Services;

namespace TCreator.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject] AppState MyAppState { get; set; }
    }
}
