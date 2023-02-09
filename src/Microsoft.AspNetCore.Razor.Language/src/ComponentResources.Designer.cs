using System;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Razor.Language
{
  internal static class ComponentResources
  {
    private static ResourceManager s_resourceManager;

    internal static ResourceManager ResourceManager => ComponentResources.s_resourceManager ?? (ComponentResources.s_resourceManager = new ResourceManager(typeof (ComponentResources)));

    internal static CultureInfo Culture { get; set; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string GetResourceString(string resourceKey, string defaultValue = null) => ComponentResources.ResourceManager.GetString(resourceKey, ComponentResources.Culture);

    private static string GetResourceString(string resourceKey, string[] formatterNames)
    {
      string resourceString = ComponentResources.GetResourceString(resourceKey);
      if (formatterNames != null)
      {
        for (int index = 0; index < formatterNames.Length; ++index)
          resourceString = resourceString.Replace("{" + formatterNames[index] + "}", "{" + index.ToString() + "}");
      }
      return resourceString;
    }

    internal static string AttributeDirective_AttributeToken_Description => ComponentResources.GetResourceString(nameof (AttributeDirective_AttributeToken_Description));

    internal static string AttributeDirective_AttributeToken_Name => ComponentResources.GetResourceString(nameof (AttributeDirective_AttributeToken_Name));

    internal static string AttributeDirective_Description => ComponentResources.GetResourceString(nameof (AttributeDirective_Description));

    internal static string BindTagHelper_Component_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Component_Documentation));

    internal static string FormatBindTagHelper_Component_Documentation(object p0, object p1) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("BindTagHelper_Component_Documentation"), p0, p1);

    internal static string BindTagHelper_Element_Culture_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Element_Culture_Documentation));

    internal static string BindTagHelper_Element_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Element_Documentation));

    internal static string FormatBindTagHelper_Element_Documentation(object p0, object p1) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("BindTagHelper_Element_Documentation"), p0, p1);

    internal static string BindTagHelper_Element_Event_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Element_Event_Documentation));

    internal static string FormatBindTagHelper_Element_Event_Documentation(object p0) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("BindTagHelper_Element_Event_Documentation"), p0);

    internal static string BindTagHelper_Element_Format_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Element_Format_Documentation));

    internal static string FormatBindTagHelper_Element_Format_Documentation(object p0) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("BindTagHelper_Element_Format_Documentation"), p0);

    internal static string BindTagHelper_Fallback_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Fallback_Documentation));

    internal static string BindTagHelper_Fallback_Event_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Fallback_Event_Documentation));

    internal static string FormatBindTagHelper_Fallback_Event_Documentation(object p0) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("BindTagHelper_Fallback_Event_Documentation"), p0);

    internal static string BindTagHelper_Fallback_Format_Documentation => ComponentResources.GetResourceString(nameof (BindTagHelper_Fallback_Format_Documentation));

    internal static string ChildContentParameterName_Documentation => ComponentResources.GetResourceString(nameof (ChildContentParameterName_Documentation));

    internal static string FormatChildContentParameterName_Documentation(object p0) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("ChildContentParameterName_Documentation"), p0);

    internal static string ChildContentParameterName_TopLevelDocumentation => ComponentResources.GetResourceString(nameof (ChildContentParameterName_TopLevelDocumentation));

    internal static string ComponentTypeParameter_Documentation => ComponentResources.GetResourceString(nameof (ComponentTypeParameter_Documentation));

    internal static string FormatComponentTypeParameter_Documentation(object p0, object p1) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("ComponentTypeParameter_Documentation"), p0, p1);

    internal static string EventHandlerTagHelper_Documentation => ComponentResources.GetResourceString(nameof (EventHandlerTagHelper_Documentation));

    internal static string FormatEventHandlerTagHelper_Documentation(object p0, object p1) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("EventHandlerTagHelper_Documentation"), p0, p1);

    internal static string EventHandlerTagHelper_PreventDefault_Documentation => ComponentResources.GetResourceString(nameof (EventHandlerTagHelper_PreventDefault_Documentation));

    internal static string FormatEventHandlerTagHelper_PreventDefault_Documentation(object p0) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("EventHandlerTagHelper_PreventDefault_Documentation"), p0);

    internal static string EventHandlerTagHelper_StopPropagation_Documentation => ComponentResources.GetResourceString(nameof (EventHandlerTagHelper_StopPropagation_Documentation));

    internal static string FormatEventHandlerTagHelper_StopPropagation_Documentation(object p0) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("EventHandlerTagHelper_StopPropagation_Documentation"), p0);

    internal static string ImplementsDirective_Description => ComponentResources.GetResourceString(nameof (ImplementsDirective_Description));

    internal static string ImplementsDirective_TypeToken_Description => ComponentResources.GetResourceString(nameof (ImplementsDirective_TypeToken_Description));

    internal static string ImplementsDirective_TypeToken_Name => ComponentResources.GetResourceString(nameof (ImplementsDirective_TypeToken_Name));

    internal static string KeyTagHelper_Documentation => ComponentResources.GetResourceString(nameof (KeyTagHelper_Documentation));

    internal static string LayoutDirective_Description => ComponentResources.GetResourceString(nameof (LayoutDirective_Description));

    internal static string LayoutDirective_TypeToken_Description => ComponentResources.GetResourceString(nameof (LayoutDirective_TypeToken_Description));

    internal static string LayoutDirective_TypeToken_Name => ComponentResources.GetResourceString(nameof (LayoutDirective_TypeToken_Name));

    internal static string PageDirectiveCannotBeImported => ComponentResources.GetResourceString(nameof (PageDirectiveCannotBeImported));

    internal static string FormatPageDirectiveCannotBeImported(object p0, object p1) => string.Format((IFormatProvider) ComponentResources.Culture, ComponentResources.GetResourceString("PageDirectiveCannotBeImported"), p0, p1);

    internal static string PageDirective_Description => ComponentResources.GetResourceString(nameof (PageDirective_Description));

    internal static string PageDirective_RouteToken_Description => ComponentResources.GetResourceString(nameof (PageDirective_RouteToken_Description));

    internal static string PageDirective_RouteToken_Name => ComponentResources.GetResourceString(nameof (PageDirective_RouteToken_Name));

    internal static string PreserveWhitespaceDirective_BooleanToken_Description => ComponentResources.GetResourceString(nameof (PreserveWhitespaceDirective_BooleanToken_Description));

    internal static string PreserveWhitespaceDirective_BooleanToken_Name => ComponentResources.GetResourceString(nameof (PreserveWhitespaceDirective_BooleanToken_Name));

    internal static string PreserveWhitespaceDirective_Description => ComponentResources.GetResourceString(nameof (PreserveWhitespaceDirective_Description));

    internal static string RefTagHelper_Documentation => ComponentResources.GetResourceString(nameof (RefTagHelper_Documentation));

    internal static string SplatTagHelper_Documentation => ComponentResources.GetResourceString(nameof (SplatTagHelper_Documentation));

    internal static string TypeParamDirective_Constraint_Description => ComponentResources.GetResourceString(nameof (TypeParamDirective_Constraint_Description));

    internal static string TypeParamDirective_Constraint_Name => ComponentResources.GetResourceString(nameof (TypeParamDirective_Constraint_Name));

    internal static string TypeParamDirective_Description => ComponentResources.GetResourceString(nameof (TypeParamDirective_Description));

    internal static string TypeParamDirective_Token_Description => ComponentResources.GetResourceString(nameof (TypeParamDirective_Token_Description));

    internal static string TypeParamDirective_Token_Name => ComponentResources.GetResourceString(nameof (TypeParamDirective_Token_Name));
  }
}
