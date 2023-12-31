using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ExampleBlazorDS.Components
{
    public class CButtonBase : ComponentBase
    {
        [Parameter]
        public string ButtonText { get; set; } = "Button";

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        protected void HandleClick(MouseEventArgs args)
        {
            OnClick.InvokeAsync(args);
        }
    }
}
