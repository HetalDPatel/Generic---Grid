using Microsoft.AspNetCore.Components;

namespace GenericGridComponent_RCL
{

    public interface ITemplate
    {
        RenderFragment childContent { get; set; }
        IGrid grid { get; set; }
    }

   
}