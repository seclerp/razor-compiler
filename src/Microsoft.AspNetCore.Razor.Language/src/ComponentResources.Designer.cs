using System;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Razor.Language
{

    internal static partial class ComponentResources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;

        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ??
            (s_resourceManager = new global::System.Resources.ResourceManager(typeof(ComponentResources)));

        internal static global::System.Globalization.CultureInfo Culture { get; set; }
#if !NET20
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions
            .AggressiveInlining)]
#endif
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>
            ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
            var value = GetResourceString(resourceKey);
            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }

        /// <summary>The C# attribute that will be applied to the current class.</summary>
        internal static string @AttributeDirective_AttributeToken_Description =>
            GetResourceString("AttributeDirective_AttributeToken_Description");

        /// <summary>Attribute</summary>
        internal static string @AttributeDirective_AttributeToken_Name =>
            GetResourceString("AttributeDirective_AttributeToken_Name");

        /// <summary>Specifies the C# attribute that will be applied to the current class.</summary>
        internal static string @AttributeDirective_Description => GetResourceString("AttributeDirective_Description");

        /// <summary>Binds the provided expression to the '{0}' property and a change event delegate to the '{1}' property of the component.</summary>
        internal static string @BindTagHelper_Component_Documentation =>
            GetResourceString("BindTagHelper_Component_Documentation");

        /// <summary>Binds the provided expression to the '{0}' property and a change event delegate to the '{1}' property of the component.</summary>
        internal static string FormatBindTagHelper_Component_Documentation(object p0, object p1)
            => string.Format(Culture, GetResourceString("BindTagHelper_Component_Documentation"), p0, p1);

        /// <summary>Specifies the culture to use for conversions.</summary>
        internal static string @BindTagHelper_Element_Culture_Documentation =>
            GetResourceString("BindTagHelper_Element_Culture_Documentation");

        internal static string @BindTagHelper_Element_Get_Documentation =>
            GetResourceString("BindTagHelper_Element_Get_Documentation");

        internal static string @BindTagHelper_Element_Set_Documentation =>
            GetResourceString("BindTagHelper_Element_Set_Documentation");

        internal static string @BindTagHelper_Element_After_Documentation =>
            GetResourceString("BindTagHelper_Element_After_Documentation");

        /// <summary>Binds the provided expression to the '{0}' attribute and a change event delegate to the '{1}' attribute.</summary>
        internal static string @BindTagHelper_Element_Documentation =>
            GetResourceString("BindTagHelper_Element_Documentation");

        /// <summary>Binds the provided expression to the '{0}' attribute and a change event delegate to the '{1}' attribute.</summary>
        internal static string FormatBindTagHelper_Element_Documentation(object p0, object p1)
            => string.Format(Culture, GetResourceString("BindTagHelper_Element_Documentation"), p0, p1);

        /// <summary>Specifies the event handler name to attach for change notifications for the value provided by the '{0}' attribute.</summary>
        internal static string @BindTagHelper_Element_Event_Documentation =>
            GetResourceString("BindTagHelper_Element_Event_Documentation");

        /// <summary>Specifies the event handler name to attach for change notifications for the value provided by the '{0}' attribute.</summary>
        internal static string FormatBindTagHelper_Element_Event_Documentation(object p0)
            => string.Format(Culture, GetResourceString("BindTagHelper_Element_Event_Documentation"), p0);

        /// <summary>Specifies a format to convert the value specified by the '{0}' attribute. The format string can currently only be used with expressions of type &lt;code&gt;DateTime&lt;/code&gt;.</summary>
        internal static string @BindTagHelper_Element_Format_Documentation =>
            GetResourceString("BindTagHelper_Element_Format_Documentation");

        /// <summary>Specifies a format to convert the value specified by the '{0}' attribute. The format string can currently only be used with expressions of type &lt;code&gt;DateTime&lt;/code&gt;.</summary>
        internal static string FormatBindTagHelper_Element_Format_Documentation(object p0)
            => string.Format(Culture, GetResourceString("BindTagHelper_Element_Format_Documentation"), p0);

        /// <summary>Binds the provided expression to an attribute and a change event, based on the naming of the bind attribute. For example: &lt;code&gt;@bind-value="..."&lt;/code&gt; and &lt;code&gt;@bind-value:event="onchange"&lt;/code&gt; will assign the current value of the expression to the 'v ...</summary>
        internal static string @BindTagHelper_Fallback_Documentation =>
            GetResourceString("BindTagHelper_Fallback_Documentation");

        /// <summary>Specifies the event handler name to attach for change notifications for the value provided by the '{0}' attribute.</summary>
        internal static string @BindTagHelper_Fallback_Event_Documentation =>
            GetResourceString("BindTagHelper_Fallback_Event_Documentation");

        /// <summary>Specifies the event handler name to attach for change notifications for the value provided by the '{0}' attribute.</summary>
        internal static string FormatBindTagHelper_Fallback_Event_Documentation(object p0)
            => string.Format(Culture, GetResourceString("BindTagHelper_Fallback_Event_Documentation"), p0);

        /// <summary>Specifies a format to convert the value specified by the corresponding bind attribute. For example: &lt;code&gt;@bind-value:format="..."&lt;/code&gt; will apply a format string to the value specified in &lt;code&gt;@bind-value="..."&lt;/code&gt;. The format string can currently o ...</summary>
        internal static string @BindTagHelper_Fallback_Format_Documentation =>
            GetResourceString("BindTagHelper_Fallback_Format_Documentation");

        /// <summary>Specifies the parameter name for the '{0}' child content expression.</summary>
        internal static string @ChildContentParameterName_Documentation =>
            GetResourceString("ChildContentParameterName_Documentation");

        /// <summary>Specifies the parameter name for the '{0}' child content expression.</summary>
        internal static string FormatChildContentParameterName_Documentation(object p0)
            => string.Format(Culture, GetResourceString("ChildContentParameterName_Documentation"), p0);

        /// <summary>Specifies the parameter name for all child content expressions.</summary>
        internal static string @ChildContentParameterName_TopLevelDocumentation =>
            GetResourceString("ChildContentParameterName_TopLevelDocumentation");

        /// <summary>Specifies the type of the type parameter {0} for the {1} component.</summary>
        internal static string @ComponentTypeParameter_Documentation =>
            GetResourceString("ComponentTypeParameter_Documentation");

        /// <summary>Specifies the type of the type parameter {0} for the {1} component.</summary>
        internal static string FormatComponentTypeParameter_Documentation(object p0, object p1)
            => string.Format(Culture, GetResourceString("ComponentTypeParameter_Documentation"), p0, p1);

        /// <summary>Sets the '{0}' attribute to the provided string or delegate value. A delegate value should be of type '{1}'.</summary>
        internal static string @EventHandlerTagHelper_Documentation =>
            GetResourceString("EventHandlerTagHelper_Documentation");

        /// <summary>Sets the '{0}' attribute to the provided string or delegate value. A delegate value should be of type '{1}'.</summary>
        internal static string FormatEventHandlerTagHelper_Documentation(object p0, object p1)
            => string.Format(Culture, GetResourceString("EventHandlerTagHelper_Documentation"), p0, p1);

        /// <summary>Specifies whether to cancel (if cancelable) the default action that belongs to the '{0}' event.</summary>
        internal static string @EventHandlerTagHelper_PreventDefault_Documentation =>
            GetResourceString("EventHandlerTagHelper_PreventDefault_Documentation");

        /// <summary>Specifies whether to cancel (if cancelable) the default action that belongs to the '{0}' event.</summary>
        internal static string FormatEventHandlerTagHelper_PreventDefault_Documentation(object p0)
            => string.Format(Culture, GetResourceString("EventHandlerTagHelper_PreventDefault_Documentation"), p0);

        /// <summary>Specifies whether to prevent further propagation of the '{0}' event in the capturing and bubbling phases.</summary>
        internal static string @EventHandlerTagHelper_StopPropagation_Documentation =>
            GetResourceString("EventHandlerTagHelper_StopPropagation_Documentation");

        /// <summary>Specifies whether to prevent further propagation of the '{0}' event in the capturing and bubbling phases.</summary>
        internal static string FormatEventHandlerTagHelper_StopPropagation_Documentation(object p0)
            => string.Format(Culture, GetResourceString("EventHandlerTagHelper_StopPropagation_Documentation"), p0);

        /// <summary>Declares an interface implementation for the current class.</summary>
        internal static string @ImplementsDirective_Description => GetResourceString("ImplementsDirective_Description");

        /// <summary>The interface type implemented by the current class.</summary>
        internal static string @ImplementsDirective_TypeToken_Description =>
            GetResourceString("ImplementsDirective_TypeToken_Description");

        /// <summary>TypeName</summary>
        internal static string @ImplementsDirective_TypeToken_Name =>
            GetResourceString("ImplementsDirective_TypeToken_Name");

        /// <summary>Ensures that the component or element will be preserved across renders if (and only if) the supplied key value matches.</summary>
        internal static string @KeyTagHelper_Documentation => GetResourceString("KeyTagHelper_Documentation");

        /// <summary>Declares a layout type for the current document.</summary>
        internal static string @LayoutDirective_Description => GetResourceString("LayoutDirective_Description");

        /// <summary>The interface type implemented by the current document.</summary>
        internal static string @LayoutDirective_TypeToken_Description =>
            GetResourceString("LayoutDirective_TypeToken_Description");

        /// <summary>TypeName</summary>
        internal static string @LayoutDirective_TypeToken_Name => GetResourceString("LayoutDirective_TypeToken_Name");

        /// <summary>The '@{0}' directive specified in {1} file will not be imported. The directive must appear at the top of each Razor file</summary>
        internal static string @PageDirectiveCannotBeImported => GetResourceString("PageDirectiveCannotBeImported");

        /// <summary>The '@{0}' directive specified in {1} file will not be imported. The directive must appear at the top of each Razor file</summary>
        internal static string FormatPageDirectiveCannotBeImported(object p0, object p1)
            => string.Format(Culture, GetResourceString("PageDirectiveCannotBeImported"), p0, p1);

        /// <summary>Mark the page as a routable component.</summary>
        internal static string @PageDirective_Description => GetResourceString("PageDirective_Description");

        /// <summary>An optional route template for the component.</summary>
        internal static string @PageDirective_RouteToken_Description =>
            GetResourceString("PageDirective_RouteToken_Description");

        /// <summary>route template</summary>
        internal static string @PageDirective_RouteToken_Name => GetResourceString("PageDirective_RouteToken_Name");

        /// <summary>True if whitespace should be preserved, otherwise false.</summary>
        internal static string @PreserveWhitespaceDirective_BooleanToken_Description =>
            GetResourceString("PreserveWhitespaceDirective_BooleanToken_Description");

        /// <summary>Preserve</summary>
        internal static string @PreserveWhitespaceDirective_BooleanToken_Name =>
            GetResourceString("PreserveWhitespaceDirective_BooleanToken_Name");

        /// <summary>Specifies whether or not whitespace should be preserved exactly. Defaults to false for better performance.</summary>
        internal static string @PreserveWhitespaceDirective_Description =>
            GetResourceString("PreserveWhitespaceDirective_Description");

        /// <summary>Populates the specified field or property with a reference to the element or component.</summary>
        internal static string @RefTagHelper_Documentation => GetResourceString("RefTagHelper_Documentation");

        /// <summary>Merges a collection of attributes into the current element or component.</summary>
        internal static string @SplatTagHelper_Documentation => GetResourceString("SplatTagHelper_Documentation");

        /// <summary>The constraints applied to the type parameter.</summary>
        internal static string @TypeParamDirective_Constraint_Description =>
            GetResourceString("TypeParamDirective_Constraint_Description");

        /// <summary>type parameter constraint</summary>
        internal static string @TypeParamDirective_Constraint_Name =>
            GetResourceString("TypeParamDirective_Constraint_Name");

        /// <summary>Declares a generic type parameter for the generated component class.</summary>
        internal static string @TypeParamDirective_Description => GetResourceString("TypeParamDirective_Description");

        /// <summary>The name of the type parameter.</summary>
        internal static string @TypeParamDirective_Token_Description =>
            GetResourceString("TypeParamDirective_Token_Description");

        /// <summary>type parameter</summary>
        internal static string @TypeParamDirective_Token_Name => GetResourceString("TypeParamDirective_Token_Name");

    }
}
