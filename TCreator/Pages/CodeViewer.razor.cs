using BlazorMonaco;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCreator.Pages
{
    public class CodeViewerBase : ComponentBase
    {
		public StandaloneEditorConstructionOptions EditorConstructionOptions(MonacoEditor editor)
		{
			return new StandaloneEditorConstructionOptions
			{
				AutomaticLayout = true,
				Language = "csharp",
				Value = ""
			};
		}
	}
}
