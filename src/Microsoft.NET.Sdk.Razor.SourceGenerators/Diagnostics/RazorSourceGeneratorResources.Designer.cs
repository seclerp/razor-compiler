// Decompiled with JetBrains decompiler
// Type: Microsoft.NET.Sdk.Razor.SourceGenerators.Diagnostics.RazorSourceGeneratorResources
// Assembly: Microsoft.NET.Sdk.Razor.SourceGenerators, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60
// MVID: 3F6FDABC-C2D2-4CBB-883A-10E7D5EBEBA8
// Assembly location: /usr/local/share/dotnet/sdk/7.0.100/Sdks/Microsoft.NET.Sdk.Razor/source-generators/Microsoft.NET.Sdk.Razor.SourceGenerators.dll

using System;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.NET.Sdk.Razor.SourceGenerators.Diagnostics
{
  internal static class RazorSourceGeneratorResources
  {
    private static ResourceManager s_resourceManager;

    internal static ResourceManager ResourceManager => RazorSourceGeneratorResources.s_resourceManager ?? (RazorSourceGeneratorResources.s_resourceManager = new ResourceManager(typeof (RazorSourceGeneratorResources)));

    internal static CultureInfo Culture { get; set; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string GetResourceString(string resourceKey, string defaultValue = null) => RazorSourceGeneratorResources.ResourceManager.GetString(resourceKey, RazorSourceGeneratorResources.Culture);

    private static string GetResourceString(string resourceKey, string[] formatterNames)
    {
      string resourceString = RazorSourceGeneratorResources.GetResourceString(resourceKey);
      if (formatterNames != null)
      {
        for (int index = 0; index < formatterNames.Length; ++index)
          resourceString = resourceString.Replace("{" + formatterNames[index] + "}", "{" + index.ToString() + "}");
      }
      return resourceString;
    }

    internal static string InvalidRazorLangTitle => RazorSourceGeneratorResources.GetResourceString(nameof (InvalidRazorLangTitle));

    internal static string InvalidRazorLangMessage => RazorSourceGeneratorResources.GetResourceString(nameof (InvalidRazorLangMessage));

    internal static string FormatInvalidRazorLangMessage(object p0) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("InvalidRazorLangMessage"), p0);

    internal static string RecomputingTagHelpersTitle => RazorSourceGeneratorResources.GetResourceString(nameof (RecomputingTagHelpersTitle));

    internal static string RecomputingTagHelpersMessage => RazorSourceGeneratorResources.GetResourceString(nameof (RecomputingTagHelpersMessage));

    internal static string FormatRecomputingTagHelpersMessage(object p0, object p1) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("RecomputingTagHelpersMessage"), p0, p1);

    internal static string TargetPathNotProvidedTitle => RazorSourceGeneratorResources.GetResourceString(nameof (TargetPathNotProvidedTitle));

    internal static string TargetPathNotProvidedMessage => RazorSourceGeneratorResources.GetResourceString(nameof (TargetPathNotProvidedMessage));

    internal static string FormatTargetPathNotProvidedMessage(object p0) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("TargetPathNotProvidedMessage"), p0);

    internal static string GeneratedOutputFullPathNotProvidedTitle => RazorSourceGeneratorResources.GetResourceString(nameof (GeneratedOutputFullPathNotProvidedTitle));

    internal static string GeneratedOutputFullPathNotProvidedMessage => RazorSourceGeneratorResources.GetResourceString(nameof (GeneratedOutputFullPathNotProvidedMessage));

    internal static string FormatGeneratedOutputFullPathNotProvidedMessage(object p0) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("GeneratedOutputFullPathNotProvidedMessage"), p0);

    internal static string CurrentCompilationReferenceNotFoundTitle => RazorSourceGeneratorResources.GetResourceString(nameof (CurrentCompilationReferenceNotFoundTitle));

    internal static string CurrentCompilationReferenceNotFoundMessage => RazorSourceGeneratorResources.GetResourceString(nameof (CurrentCompilationReferenceNotFoundMessage));

    internal static string SkippingGeneratedFileWriteTitle => RazorSourceGeneratorResources.GetResourceString(nameof (SkippingGeneratedFileWriteTitle));

    internal static string SkippingGeneratedFileWriteMessage => RazorSourceGeneratorResources.GetResourceString(nameof (SkippingGeneratedFileWriteMessage));

    internal static string FormatSkippingGeneratedFileWriteMessage(object p0) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("SkippingGeneratedFileWriteMessage"), p0);

    internal static string SourceTextNotFoundTitle => RazorSourceGeneratorResources.GetResourceString(nameof (SourceTextNotFoundTitle));

    internal static string SourceTextNotFoundMessage => RazorSourceGeneratorResources.GetResourceString(nameof (SourceTextNotFoundMessage));

    internal static string FormatSourceTextNotFoundMessage(object p0) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("SourceTextNotFoundMessage"), p0);

    internal static string UnexpectedProjectItemReadCallTitle => RazorSourceGeneratorResources.GetResourceString(nameof (UnexpectedProjectItemReadCallTitle));

    internal static string UnexpectedProjectItemReadCallMessage => RazorSourceGeneratorResources.GetResourceString(nameof (UnexpectedProjectItemReadCallMessage));

    internal static string FormatUnexpectedProjectItemReadCallMessage(object p0) => string.Format((IFormatProvider) RazorSourceGeneratorResources.Culture, RazorSourceGeneratorResources.GetResourceString("UnexpectedProjectItemReadCallMessage"), p0);

    internal static string InvalidRazorContextComputedTitle => RazorSourceGeneratorResources.GetResourceString(nameof (InvalidRazorContextComputedTitle));

    internal static string InvalidRazorContextComputedMessage => RazorSourceGeneratorResources.GetResourceString(nameof (InvalidRazorContextComputedMessage));

    internal static string MetadataReferenceNotProvidedTitle => RazorSourceGeneratorResources.GetResourceString(nameof (MetadataReferenceNotProvidedTitle));

    internal static string MetadataReferenceNotProvidedMessage => RazorSourceGeneratorResources.GetResourceString(nameof (MetadataReferenceNotProvidedMessage));
  }
}
