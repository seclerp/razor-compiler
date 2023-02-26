using System.Reflection;


namespace Microsoft.AspNetCore.Mvc.Razor.Extensions
{
    internal static partial class RazorExtensionsResources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(RazorExtensionsResources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }
#if !NET20
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

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

        /// <summary>Value cannot be null or empty.</summary>
        internal static string @ArgumentCannotBeNullOrEmpty => GetResourceString("ArgumentCannotBeNullOrEmpty");
        /// <summary>Inject a service from the application's service container into a property.</summary>
        internal static string @InjectDirective_Description => GetResourceString("InjectDirective_Description");
        /// <summary>The name of the property.</summary>
        internal static string @InjectDirective_MemberToken_Description => GetResourceString("InjectDirective_MemberToken_Description");
        /// <summary>PropertyName</summary>
        internal static string @InjectDirective_MemberToken_Name => GetResourceString("InjectDirective_MemberToken_Name");
        /// <summary>The type of the service to inject.</summary>
        internal static string @InjectDirective_TypeToken_Description => GetResourceString("InjectDirective_TypeToken_Description");
        /// <summary>TypeName</summary>
        internal static string @InjectDirective_TypeToken_Name => GetResourceString("InjectDirective_TypeToken_Name");
        /// <summary>Specify the view or page model for the page.</summary>
        internal static string @ModelDirective_Description => GetResourceString("ModelDirective_Description");
        /// <summary>The model type.</summary>
        internal static string @ModelDirective_TypeToken_Description => GetResourceString("ModelDirective_TypeToken_Description");
        /// <summary>TypeName</summary>
        internal static string @ModelDirective_TypeToken_Name => GetResourceString("ModelDirective_TypeToken_Name");
        /// <summary>The 'inherits' keyword is not allowed when a '{0}' keyword is used.</summary>
        internal static string @MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword => GetResourceString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword");
        /// <summary>The 'inherits' keyword is not allowed when a '{0}' keyword is used.</summary>
        internal static string FormatMvcRazorCodeParser_CannotHaveModelAndInheritsKeyword(object p0)
           => string.Format(Culture, GetResourceString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword"), p0);

        /// <summary>A property name must be specified when using the '{0}' statement. Format for a '{0}' statement is '@{0} &lt;Type Name&gt; &lt;Property Name&gt;'.</summary>
        internal static string @MvcRazorCodeParser_InjectDirectivePropertyNameRequired => GetResourceString("MvcRazorCodeParser_InjectDirectivePropertyNameRequired");
        /// <summary>A property name must be specified when using the '{0}' statement. Format for a '{0}' statement is '@{0} &lt;Type Name&gt; &lt;Property Name&gt;'.</summary>
        internal static string FormatMvcRazorCodeParser_InjectDirectivePropertyNameRequired(object p0)
           => string.Format(Culture, GetResourceString("MvcRazorCodeParser_InjectDirectivePropertyNameRequired"), p0);

        /// <summary>The '{0}' keyword must be followed by a type name on the same line.</summary>
        internal static string @MvcRazorCodeParser_KeywordMustBeFollowedByTypeName => GetResourceString("MvcRazorCodeParser_KeywordMustBeFollowedByTypeName");
        /// <summary>The '{0}' keyword must be followed by a type name on the same line.</summary>
        internal static string FormatMvcRazorCodeParser_KeywordMustBeFollowedByTypeName(object p0)
           => string.Format(Culture, GetResourceString("MvcRazorCodeParser_KeywordMustBeFollowedByTypeName"), p0);

        /// <summary>Only one '{0}' statement is allowed in a file.</summary>
        internal static string @MvcRazorCodeParser_OnlyOneModelStatementIsAllowed => GetResourceString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed");
        /// <summary>Only one '{0}' statement is allowed in a file.</summary>
        internal static string FormatMvcRazorCodeParser_OnlyOneModelStatementIsAllowed(object p0)
           => string.Format(Culture, GetResourceString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed"), p0);

        /// <summary>Invalid tag helper property '{0}.{1}'. Dictionary values must not be of type '{2}'.</summary>
        internal static string @MvcRazorParser_InvalidPropertyType => GetResourceString("MvcRazorParser_InvalidPropertyType");
        /// <summary>Invalid tag helper property '{0}.{1}'. Dictionary values must not be of type '{2}'.</summary>
        internal static string FormatMvcRazorParser_InvalidPropertyType(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("MvcRazorParser_InvalidPropertyType"), p0, p1, p2);

        /// <summary>The '@{0}' directive specified in {1} file will not be imported. The directive must appear at the top of each Razor cshtml file.</summary>
        internal static string @PageDirectiveCannotBeImported => GetResourceString("PageDirectiveCannotBeImported");
        /// <summary>The '@{0}' directive specified in {1} file will not be imported. The directive must appear at the top of each Razor cshtml file.</summary>
        internal static string FormatPageDirectiveCannotBeImported(object p0, object p1)
           => string.Format(Culture, GetResourceString("PageDirectiveCannotBeImported"), p0, p1);

        /// <summary>The '@{0}' directive must precede all other elements defined in a Razor file.</summary>
        internal static string @PageDirectiveMustExistAtTheTopOfFile => GetResourceString("PageDirectiveMustExistAtTheTopOfFile");
        /// <summary>The '@{0}' directive must precede all other elements defined in a Razor file.</summary>
        internal static string FormatPageDirectiveMustExistAtTheTopOfFile(object p0)
           => string.Format(Culture, GetResourceString("PageDirectiveMustExistAtTheTopOfFile"), p0);

        /// <summary>Mark the page as a Razor Page.</summary>
        internal static string @PageDirective_Description => GetResourceString("PageDirective_Description");
        /// <summary>An optional route template for the page.</summary>
        internal static string @PageDirective_RouteToken_Description => GetResourceString("PageDirective_RouteToken_Description");
        /// <summary>RouteTemplate</summary>
        internal static string @PageDirective_RouteToken_Name => GetResourceString("PageDirective_RouteToken_Name");
        /// <summary>View component '{0}' must have exactly one public method named '{1}' or '{2}'.</summary>
        internal static string @ViewComponent_AmbiguousMethods => GetResourceString("ViewComponent_AmbiguousMethods");
        /// <summary>View component '{0}' must have exactly one public method named '{1}' or '{2}'.</summary>
        internal static string FormatViewComponent_AmbiguousMethods(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("ViewComponent_AmbiguousMethods"), p0, p1, p2);

        /// <summary>Method '{0}' of view component '{1}' should be declared to return {2}&amp;lt;T&amp;gt;.</summary>
        internal static string @ViewComponent_AsyncMethod_ShouldReturnTask => GetResourceString("ViewComponent_AsyncMethod_ShouldReturnTask");
        /// <summary>Method '{0}' of view component '{1}' should be declared to return {2}&amp;lt;T&amp;gt;.</summary>
        internal static string FormatViewComponent_AsyncMethod_ShouldReturnTask(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("ViewComponent_AsyncMethod_ShouldReturnTask"), p0, p1, p2);

        /// <summary>Could not find an '{0}' or '{1}' method for the view component '{2}'.</summary>
        internal static string @ViewComponent_CannotFindMethod => GetResourceString("ViewComponent_CannotFindMethod");
        /// <summary>Could not find an '{0}' or '{1}' method for the view component '{2}'.</summary>
        internal static string FormatViewComponent_CannotFindMethod(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("ViewComponent_CannotFindMethod"), p0, p1, p2);

        /// <summary>Method '{0}' of view component '{1}' cannot return a {2}.</summary>
        internal static string @ViewComponent_SyncMethod_CannotReturnTask => GetResourceString("ViewComponent_SyncMethod_CannotReturnTask");
        /// <summary>Method '{0}' of view component '{1}' cannot return a {2}.</summary>
        internal static string FormatViewComponent_SyncMethod_CannotReturnTask(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("ViewComponent_SyncMethod_CannotReturnTask"), p0, p1, p2);

        /// <summary>Method '{0}' of view component '{1}' should be declared to return a value.</summary>
        internal static string @ViewComponent_SyncMethod_ShouldReturnValue => GetResourceString("ViewComponent_SyncMethod_ShouldReturnValue");
        /// <summary>Method '{0}' of view component '{1}' should be declared to return a value.</summary>
        internal static string FormatViewComponent_SyncMethod_ShouldReturnValue(object p0, object p1)
           => string.Format(Culture, GetResourceString("ViewComponent_SyncMethod_ShouldReturnValue"), p0, p1);


    }
}
