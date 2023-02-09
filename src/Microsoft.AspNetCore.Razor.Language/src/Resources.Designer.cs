using System;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Razor.Language
{
  internal static class Resources
  {
    private static ResourceManager s_resourceManager;

    internal static ResourceManager ResourceManager => Microsoft.AspNetCore.Razor.Language.Resources.s_resourceManager ?? (Microsoft.AspNetCore.Razor.Language.Resources.s_resourceManager = new ResourceManager(typeof (Microsoft.AspNetCore.Razor.Language.Resources)));

    internal static CultureInfo Culture { get; set; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string GetResourceString(string resourceKey, string defaultValue = null) => Microsoft.AspNetCore.Razor.Language.Resources.ResourceManager.GetString(resourceKey, Microsoft.AspNetCore.Razor.Language.Resources.Culture);

    private static string GetResourceString(string resourceKey, string[] formatterNames)
    {
      string resourceString = Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(resourceKey);
      if (formatterNames != null)
      {
        for (int index = 0; index < formatterNames.Length; ++index)
          resourceString = resourceString.Replace("{" + formatterNames[index] + "}", "{" + index.ToString() + "}");
      }
      return resourceString;
    }

    internal static string AddTagHelperDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (AddTagHelperDirective_Description));

    internal static string AddTagHelperDirective_StringToken_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (AddTagHelperDirective_StringToken_Description));

    internal static string AddTagHelperDirective_StringToken_Name => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (AddTagHelperDirective_StringToken_Name));

    internal static string ArgumentCannotBeNullOrEmpty => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ArgumentCannotBeNullOrEmpty));

    internal static string Block_Type_Not_Specified => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Block_Type_Not_Specified));

    internal static string BlockDirectiveCannotBeImported => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (BlockDirectiveCannotBeImported));

    internal static string FormatBlockDirectiveCannotBeImported(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("BlockDirectiveCannotBeImported"), p0);

    internal static string BlockName_Code => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (BlockName_Code));

    internal static string BlockName_ExplicitExpression => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (BlockName_ExplicitExpression));

    internal static string CodeWriter_InvalidNewLine => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CodeWriter_InvalidNewLine));

    internal static string FormatCodeWriter_InvalidNewLine(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("CodeWriter_InvalidNewLine"), p0);

    internal static string CSharpToken_CharacterLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_CharacterLiteral));

    internal static string CSharpToken_Comment => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_Comment));

    internal static string CSharpToken_Identifier => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_Identifier));

    internal static string CSharpToken_IntegerLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_IntegerLiteral));

    internal static string CSharpToken_Keyword => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_Keyword));

    internal static string CSharpToken_Newline => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_Newline));

    internal static string CSharpToken_RealLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_RealLiteral));

    internal static string CSharpToken_StringLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_StringLiteral));

    internal static string CSharpToken_Whitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CSharpToken_Whitespace));

    internal static string Diagnostic_CodeTarget_UnsupportedExtension => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Diagnostic_CodeTarget_UnsupportedExtension));

    internal static string FormatDiagnostic_CodeTarget_UnsupportedExtension(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("Diagnostic_CodeTarget_UnsupportedExtension"), p0, p1);

    internal static string DirectiveDescriptor_InvalidDirectiveKeyword => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveDescriptor_InvalidDirectiveKeyword));

    internal static string FormatDirectiveDescriptor_InvalidDirectiveKeyword(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveDescriptor_InvalidDirectiveKeyword"), p0);

    internal static string DirectiveDescriptor_InvalidNonOptionalToken => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveDescriptor_InvalidNonOptionalToken));

    internal static string DirectiveExpectsIdentifier => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveExpectsIdentifier));

    internal static string FormatDirectiveExpectsIdentifier(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveExpectsIdentifier"), p0);

    internal static string DirectiveExpectsNamespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveExpectsNamespace));

    internal static string FormatDirectiveExpectsNamespace(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveExpectsNamespace"), p0);

    internal static string DirectiveExpectsQuotedStringLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveExpectsQuotedStringLiteral));

    internal static string FormatDirectiveExpectsQuotedStringLiteral(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveExpectsQuotedStringLiteral"), p0);

    internal static string DirectiveExpectsTypeName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveExpectsTypeName));

    internal static string FormatDirectiveExpectsTypeName(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveExpectsTypeName"), p0);

    internal static string DirectiveMustAppearAtStartOfLine => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveMustAppearAtStartOfLine));

    internal static string FormatDirectiveMustAppearAtStartOfLine(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveMustAppearAtStartOfLine"), p0);

    internal static string DirectiveTokensMustBeSeparatedByWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveTokensMustBeSeparatedByWhitespace));

    internal static string FormatDirectiveTokensMustBeSeparatedByWhitespace(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveTokensMustBeSeparatedByWhitespace"), p0);

    internal static string DocumentMissingTarget => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DocumentMissingTarget));

    internal static string FormatDocumentMissingTarget(object p0, object p1, object p2) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DocumentMissingTarget"), p0, p1, p2);

    internal static string DuplicateDirective => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DuplicateDirective));

    internal static string FormatDuplicateDirective(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DuplicateDirective"), p0);

    internal static string EndBlock_Called_Without_Matching_StartBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (EndBlock_Called_Without_Matching_StartBlock));

    internal static string ErrorComponent_Newline => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ErrorComponent_Newline));

    internal static string FeatureDependencyMissing => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (FeatureDependencyMissing));

    internal static string FormatFeatureDependencyMissing(object p0, object p1, object p2) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("FeatureDependencyMissing"), p0, p1, p2);

    internal static string FeatureMustBeInitialized => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (FeatureMustBeInitialized));

    internal static string FormatFeatureMustBeInitialized(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("FeatureMustBeInitialized"), p0);

    internal static string FunctionsDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (FunctionsDirective_Description));

    internal static string HtmlToken_NewLine => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (HtmlToken_NewLine));

    internal static string HtmlToken_RazorComment => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (HtmlToken_RazorComment));

    internal static string HtmlToken_Text => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (HtmlToken_Text));

    internal static string HtmlToken_WhiteSpace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (HtmlToken_WhiteSpace));

    internal static string InheritsDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (InheritsDirective_Description));

    internal static string InheritsDirective_TypeToken_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (InheritsDirective_TypeToken_Description));

    internal static string InheritsDirective_TypeToken_Name => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (InheritsDirective_TypeToken_Name));

    internal static string IntermediateNodeBuilder_PopInvalid => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (IntermediateNodeBuilder_PopInvalid));

    internal static string FormatIntermediateNodeBuilder_PopInvalid(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("IntermediateNodeBuilder_PopInvalid"), p0);

    internal static string IntermediateNodeReference_CollectionIsReadOnly => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (IntermediateNodeReference_CollectionIsReadOnly));

    internal static string FormatIntermediateNodeReference_CollectionIsReadOnly(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("IntermediateNodeReference_CollectionIsReadOnly"), p0);

    internal static string IntermediateNodeReference_NodeNotFound => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (IntermediateNodeReference_NodeNotFound));

    internal static string FormatIntermediateNodeReference_NodeNotFound(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("IntermediateNodeReference_NodeNotFound"), p0, p1);

    internal static string IntermediateNodeReference_NotInitialized => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (IntermediateNodeReference_NotInitialized));

    internal static string IntermediateNodes_InvalidParentNode => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (IntermediateNodes_InvalidParentNode));

    internal static string FormatIntermediateNodes_InvalidParentNode(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("IntermediateNodes_InvalidParentNode"), p0, p1);

    internal static string InvalidOperation_SpanIsNotChangeOwner => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (InvalidOperation_SpanIsNotChangeOwner));

    internal static string FormatInvalidOperation_SpanIsNotChangeOwner(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("InvalidOperation_SpanIsNotChangeOwner"), p0, p1);

    internal static string InvalidTagHelperLookupText => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (InvalidTagHelperLookupText));

    internal static string FormatInvalidTagHelperLookupText(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("InvalidTagHelperLookupText"), p0);

    internal static string InvalidTagHelperPrefixValue => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (InvalidTagHelperPrefixValue));

    internal static string FormatInvalidTagHelperPrefixValue(object p0, object p1, object p2) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("InvalidTagHelperPrefixValue"), p0, p1, p2);

    internal static string KeyMustNotBeNull => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (KeyMustNotBeNull));

    internal static string Language_Does_Not_Support_RazorComment => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Language_Does_Not_Support_RazorComment));

    internal static string MismatchedContentEncoding => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (MismatchedContentEncoding));

    internal static string FormatMismatchedContentEncoding(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("MismatchedContentEncoding"), p0, p1);

    internal static string ParseError_AtInCode_Must_Be_Followed_By_Colon_Paren_Or_Identifier_Start => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_AtInCode_Must_Be_Followed_By_Colon_Paren_Or_Identifier_Start));

    internal static string ParseError_BlockComment_Not_Terminated => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_BlockComment_Not_Terminated));

    internal static string ParseError_DirectiveMustHaveValue => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_DirectiveMustHaveValue));

    internal static string FormatParseError_DirectiveMustHaveValue(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_DirectiveMustHaveValue"), p0);

    internal static string ParseError_Expected_CloseBracket_Before_EOF => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Expected_CloseBracket_Before_EOF));

    internal static string FormatParseError_Expected_CloseBracket_Before_EOF(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_Expected_CloseBracket_Before_EOF"), p0, p1);

    internal static string ParseError_Expected_EndOfBlock_Before_EOF => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Expected_EndOfBlock_Before_EOF));

    internal static string FormatParseError_Expected_EndOfBlock_Before_EOF(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_Expected_EndOfBlock_Before_EOF"), p0, p1, p2);
    }

    internal static string ParseError_HelperDirectiveNotAvailable => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_HelperDirectiveNotAvailable));

    internal static string FormatParseError_HelperDirectiveNotAvailable(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_HelperDirectiveNotAvailable"), p0);

    internal static string ParseError_IncompleteQuotesAroundDirective => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_IncompleteQuotesAroundDirective));

    internal static string FormatParseError_IncompleteQuotesAroundDirective(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_IncompleteQuotesAroundDirective"), p0);

    internal static string ParseError_InlineMarkup_Blocks_Cannot_Be_Nested => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_InlineMarkup_Blocks_Cannot_Be_Nested));

    internal static string ParseError_MarkupBlock_Must_Start_With_Tag => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_MarkupBlock_Must_Start_With_Tag));

    internal static string ParseError_MissingEndTag => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_MissingEndTag));

    internal static string FormatParseError_MissingEndTag(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_MissingEndTag"), p0);

    internal static string ParseError_NamespaceImportAndTypeAlias_Cannot_Exist_Within_CodeBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_NamespaceImportAndTypeAlias_Cannot_Exist_Within_CodeBlock));

    internal static string ParseError_OuterTagMissingName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_OuterTagMissingName));

    internal static string ParseError_RazorComment_Not_Terminated => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_RazorComment_Not_Terminated));

    internal static string ParseError_ReservedWord => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_ReservedWord));

    internal static string FormatParseError_ReservedWord(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_ReservedWord"), p0);

    internal static string ParseError_Sections_Cannot_Be_Nested => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Sections_Cannot_Be_Nested));

    internal static string FormatParseError_Sections_Cannot_Be_Nested(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_Sections_Cannot_Be_Nested"), p0);

    internal static string ParseError_SingleLine_ControlFlowStatements_CannotContainMarkup => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_SingleLine_ControlFlowStatements_CannotContainMarkup));

    internal static string ParseError_TextTagCannotContainAttributes => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_TextTagCannotContainAttributes));

    internal static string ParseError_Unexpected_Character_At_Start_Of_CodeBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Unexpected_Character_At_Start_Of_CodeBlock));

    internal static string FormatParseError_Unexpected_Character_At_Start_Of_CodeBlock(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_Unexpected_Character_At_Start_Of_CodeBlock"), p0);

    internal static string ParseError_Unexpected_EndOfFile_At_Start_Of_CodeBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Unexpected_EndOfFile_At_Start_Of_CodeBlock));

    internal static string ParseError_Unexpected_Nested_CodeBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Unexpected_Nested_CodeBlock));

    internal static string ParseError_Unexpected_WhiteSpace_At_Start_Of_CodeBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Unexpected_WhiteSpace_At_Start_Of_CodeBlock));

    internal static string ParseError_UnexpectedEndTag => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_UnexpectedEndTag));

    internal static string FormatParseError_UnexpectedEndTag(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_UnexpectedEndTag"), p0);

    internal static string ParseError_UnfinishedTag => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_UnfinishedTag));

    internal static string FormatParseError_UnfinishedTag(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_UnfinishedTag"), p0);

    internal static string ParseError_Unterminated_String_Literal => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Unterminated_String_Literal));

    internal static string Parser_Context_Not_Set => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Parser_Context_Not_Set));

    internal static string ParserContext_CannotCompleteTree_NoRootBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParserContext_CannotCompleteTree_NoRootBlock));

    internal static string ParserContext_CannotCompleteTree_OutstandingBlocks => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParserContext_CannotCompleteTree_OutstandingBlocks));

    internal static string ParserContext_NoCurrentBlock => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParserContext_NoCurrentBlock));

    internal static string PhaseDependencyMissing => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (PhaseDependencyMissing));

    internal static string FormatPhaseDependencyMissing(object p0, object p1, object p2) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("PhaseDependencyMissing"), p0, p1, p2);

    internal static string PhaseMustBeInitialized => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (PhaseMustBeInitialized));

    internal static string FormatPhaseMustBeInitialized(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("PhaseMustBeInitialized"), p0);

    internal static string RazorProject_PathMustStartWithForwardSlash => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RazorProject_PathMustStartWithForwardSlash));

    internal static string RemoveTagHelperDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RemoveTagHelperDirective_Description));

    internal static string RemoveTagHelperDirective_StringToken_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RemoveTagHelperDirective_StringToken_Description));

    internal static string RemoveTagHelperDirective_StringToken_Name => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RemoveTagHelperDirective_StringToken_Name));

    internal static string RenderingContextRequiresDelegate => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RenderingContextRequiresDelegate));

    internal static string FormatRenderingContextRequiresDelegate(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("RenderingContextRequiresDelegate"), p0, p1);

    internal static string RewriterError_EmptyTagHelperBoundAttribute => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RewriterError_EmptyTagHelperBoundAttribute));

    internal static string FormatRewriterError_EmptyTagHelperBoundAttribute(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("RewriterError_EmptyTagHelperBoundAttribute"), p0, p1, p2);
    }

    internal static string SectionDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (SectionDirective_Description));

    internal static string SectionDirective_NameToken_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (SectionDirective_NameToken_Description));

    internal static string SectionDirective_NameToken_Name => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (SectionDirective_NameToken_Name));

    internal static string SectionExample => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (SectionExample));

    internal static string Token_Unknown => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Token_Unknown));

    internal static string TagHelper_InvalidBoundAttributeName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributeName));

    internal static string FormatTagHelper_InvalidBoundAttributeName(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributeName"), p0, p1, p2, p3);
    }

    internal static string TagHelper_InvalidBoundAttributeNameStartsWith => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributeNameStartsWith));

    internal static string FormatTagHelper_InvalidBoundAttributeNameStartsWith(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributeNameStartsWith"), p0, p1, p2, p3);
    }

    internal static string TagHelper_InvalidBoundAttributeNullOrWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributeNullOrWhitespace));

    internal static string FormatTagHelper_InvalidBoundAttributeNullOrWhitespace(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributeNullOrWhitespace"), p0, p1);
    }

    internal static string TagHelper_InvalidBoundAttributePrefix => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributePrefix));

    internal static string FormatTagHelper_InvalidBoundAttributePrefix(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributePrefix"), p0, p1, p2, p3);
    }

    internal static string TagHelper_InvalidBoundAttributePrefixStartsWith => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributePrefixStartsWith));

    internal static string FormatTagHelper_InvalidBoundAttributePrefixStartsWith(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributePrefixStartsWith"), p0, p1, p2, p3);
    }

    internal static string TagHelper_InvalidRestrictedChild => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidRestrictedChild));

    internal static string FormatTagHelper_InvalidRestrictedChild(object p0, object p1, object p2) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidRestrictedChild"), p0, p1, p2);

    internal static string TagHelper_InvalidRestrictedChildNullOrWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidRestrictedChildNullOrWhitespace));

    internal static string FormatTagHelper_InvalidRestrictedChildNullOrWhitespace(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidRestrictedChildNullOrWhitespace"), p0);

    internal static string TagHelper_InvalidTargetedAttributeName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidTargetedAttributeName));

    internal static string FormatTagHelper_InvalidTargetedAttributeName(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidTargetedAttributeName"), p0, p1);

    internal static string TagHelper_InvalidTargetedAttributeNameNullOrWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidTargetedAttributeNameNullOrWhitespace));

    internal static string TagHelper_InvalidTargetedParentTagName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidTargetedParentTagName));

    internal static string FormatTagHelper_InvalidTargetedParentTagName(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidTargetedParentTagName"), p0, p1);

    internal static string TagHelper_InvalidTargetedParentTagNameNullOrWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidTargetedParentTagNameNullOrWhitespace));

    internal static string TagHelper_InvalidTargetedTagName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidTargetedTagName));

    internal static string FormatTagHelper_InvalidTargetedTagName(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidTargetedTagName"), p0, p1);

    internal static string TagHelper_InvalidTargetedTagNameNullOrWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidTargetedTagNameNullOrWhitespace));

    internal static string TagHelperAssemblyNameCannotBeEmptyOrNull => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperAssemblyNameCannotBeEmptyOrNull));

    internal static string TagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey));

    internal static string FormatTagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey"), p0, p1);
    }

    internal static string TagHelperBlockRewriter_TagHelperAttributeListMustBeWellFormed => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperBlockRewriter_TagHelperAttributeListMustBeWellFormed));

    internal static string TagHelperParseTreeRewriter_CannotHaveNonTagContent => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperParseTreeRewriter_CannotHaveNonTagContent));

    internal static string FormatTagHelperParseTreeRewriter_CannotHaveNonTagContent(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelperParseTreeRewriter_CannotHaveNonTagContent"), p0, p1);
    }

    internal static string TagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag));

    internal static string FormatTagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag"), p0, p1, p2);
    }

    internal static string TagHelperParseTreeRewriter_InconsistentTagStructure => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperParseTreeRewriter_InconsistentTagStructure));

    internal static string FormatTagHelperParseTreeRewriter_InconsistentTagStructure(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelperParseTreeRewriter_InconsistentTagStructure"), p0, p1, p2, p3);
    }

    internal static string TagHelperParseTreeRewriter_InvalidNestedTag => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperParseTreeRewriter_InvalidNestedTag));

    internal static string FormatTagHelperParseTreeRewriter_InvalidNestedTag(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelperParseTreeRewriter_InvalidNestedTag"), p0, p1, p2);
    }

    internal static string TagHelperPrefixDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperPrefixDirective_Description));

    internal static string TagHelperPrefixDirective_PrefixToken_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperPrefixDirective_PrefixToken_Description));

    internal static string TagHelperPrefixDirective_PrefixToken_Name => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelperPrefixDirective_PrefixToken_Name));

    internal static string TagHelpers_AttributesMustHaveAName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelpers_AttributesMustHaveAName));

    internal static string FormatTagHelpers_AttributesMustHaveAName(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelpers_AttributesMustHaveAName"), p0);

    internal static string TagHelpers_CannotHaveCSharpInTagDeclaration => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelpers_CannotHaveCSharpInTagDeclaration));

    internal static string FormatTagHelpers_CannotHaveCSharpInTagDeclaration(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelpers_CannotHaveCSharpInTagDeclaration"), p0);

    internal static string TagHelpers_CodeBlocks_NotSupported_InAttributes => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelpers_CodeBlocks_NotSupported_InAttributes));

    internal static string TagHelpers_InlineMarkupBlocks_NotSupported_InAttributes => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelpers_InlineMarkupBlocks_NotSupported_InAttributes));

    internal static string FormatTagHelpers_InlineMarkupBlocks_NotSupported_InAttributes(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelpers_InlineMarkupBlocks_NotSupported_InAttributes"), p0);

    internal static string TagHelpersParseTreeRewriter_FoundMalformedTagHelper => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelpersParseTreeRewriter_FoundMalformedTagHelper));

    internal static string FormatTagHelpersParseTreeRewriter_FoundMalformedTagHelper(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelpersParseTreeRewriter_FoundMalformedTagHelper"), p0);

    internal static string TagHelpersParseTreeRewriter_MissingCloseAngle => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelpersParseTreeRewriter_MissingCloseAngle));

    internal static string FormatTagHelpersParseTreeRewriter_MissingCloseAngle(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelpersParseTreeRewriter_MissingCloseAngle"), p0);

    internal static string UnexpectedDirectiveKind => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (UnexpectedDirectiveKind));

    internal static string FormatUnexpectedDirectiveKind(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("UnexpectedDirectiveKind"), p0);

    internal static string UnexpectedDirectiveLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (UnexpectedDirectiveLiteral));

    internal static string FormatUnexpectedDirectiveLiteral(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("UnexpectedDirectiveLiteral"), p0, p1);

    internal static string UnexpectedEOFAfterDirective => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (UnexpectedEOFAfterDirective));

    internal static string FormatUnexpectedEOFAfterDirective(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("UnexpectedEOFAfterDirective"), p0, p1);

    internal static string UnsupportedChecksumAlgorithm => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (UnsupportedChecksumAlgorithm));

    internal static string FormatUnsupportedChecksumAlgorithm(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("UnsupportedChecksumAlgorithm"), p0, p1, p2, p3);
    }

    internal static string PropertyMustNotBeNull => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (PropertyMustNotBeNull));

    internal static string FormatPropertyMustNotBeNull(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("PropertyMustNotBeNull"), p0, p1);

    internal static string RazorProjectEngineMissingFeatureDependency => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RazorProjectEngineMissingFeatureDependency));

    internal static string FormatRazorProjectEngineMissingFeatureDependency(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("RazorProjectEngineMissingFeatureDependency"), p0, p1);

    internal static string RazorLanguageVersion_InvalidVersion => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RazorLanguageVersion_InvalidVersion));

    internal static string FormatRazorLanguageVersion_InvalidVersion(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("RazorLanguageVersion_InvalidVersion"), p0);

    internal static string VirtualFileSystem_FileDoesNotBelongToDirectory => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (VirtualFileSystem_FileDoesNotBelongToDirectory));

    internal static string FormatVirtualFileSystem_FileDoesNotBelongToDirectory(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("VirtualFileSystem_FileDoesNotBelongToDirectory"), p0, p1);
    }

    internal static string VirtualFileSystem_InvalidRelativePath => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (VirtualFileSystem_InvalidRelativePath));

    internal static string FormatVirtualFileSystem_InvalidRelativePath(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("VirtualFileSystem_InvalidRelativePath"), p0);

    internal static string Rewriter_InsufficientStack => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Rewriter_InsufficientStack));

    internal static string NamespaceDirective_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (NamespaceDirective_Description));

    internal static string NamespaceDirective_NamespaceToken_Description => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (NamespaceDirective_NamespaceToken_Description));

    internal static string NamespaceDirective_NamespaceToken_Name => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (NamespaceDirective_NamespaceToken_Name));

    internal static string TagHelper_InvalidBoundAttributeParameterName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributeParameterName));

    internal static string FormatTagHelper_InvalidBoundAttributeParameterName(
      object p0,
      object p1,
      object p3)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributeParameterName"), p0, p1, p3);
    }

    internal static string TagHelper_InvalidBoundAttributeParameterNullOrWhitespace => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundAttributeParameterNullOrWhitespace));

    internal static string FormatTagHelper_InvalidBoundAttributeParameterNullOrWhitespace(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundAttributeParameterNullOrWhitespace"), p0);

    internal static string DirectiveExpectsCSharpAttribute => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveExpectsCSharpAttribute));

    internal static string FormatDirectiveExpectsCSharpAttribute(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveExpectsCSharpAttribute"), p0);

    internal static string TagHelper_InvalidBoundDirectiveAttributeName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundDirectiveAttributeName));

    internal static string FormatTagHelper_InvalidBoundDirectiveAttributeName(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundDirectiveAttributeName"), p0, p1, p2);
    }

    internal static string TagHelper_InvalidBoundDirectiveAttributePrefix => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidBoundDirectiveAttributePrefix));

    internal static string FormatTagHelper_InvalidBoundDirectiveAttributePrefix(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidBoundDirectiveAttributePrefix"), p0, p1, p2);
    }

    internal static string TagHelper_InvalidRequiredDirectiveAttributeName => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (TagHelper_InvalidRequiredDirectiveAttributeName));

    internal static string FormatTagHelper_InvalidRequiredDirectiveAttributeName(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("TagHelper_InvalidRequiredDirectiveAttributeName"), p0, p1);
    }

    internal static string DirectiveExpectsBooleanLiteral => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveExpectsBooleanLiteral));

    internal static string FormatDirectiveExpectsBooleanLiteral(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveExpectsBooleanLiteral"), p0);

    internal static string CssRewriter_ImportNotAllowed => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (CssRewriter_ImportNotAllowed));

    internal static string DirectiveGenericTypeParameterIdentifierMismatch => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (DirectiveGenericTypeParameterIdentifierMismatch));

    internal static string FormatDirectiveGenericTypeParameterIdentifierMismatch(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("DirectiveGenericTypeParameterIdentifierMismatch"), p0, p1, p2);
    }

    internal static string ParseError_Unexpected_Identifier_At_Position => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (ParseError_Unexpected_Identifier_At_Position));

    internal static string FormatParseError_Unexpected_Identifier_At_Position(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("ParseError_Unexpected_Identifier_At_Position"), p0, p1);

    internal static string Component_EditorRequiredParameterNotSpecified => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (Component_EditorRequiredParameterNotSpecified));

    internal static string FormatComponent_EditorRequiredParameterNotSpecified(object p0, object p1) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("Component_EditorRequiredParameterNotSpecified"), p0, p1);

    internal static string RazorDiagnosticDescriptor_DefaultError => Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString(nameof (RazorDiagnosticDescriptor_DefaultError));

    internal static string FormatRazorDiagnosticDescriptor_DefaultError(object p0) => string.Format((IFormatProvider) Microsoft.AspNetCore.Razor.Language.Resources.Culture, Microsoft.AspNetCore.Razor.Language.Resources.GetResourceString("RazorDiagnosticDescriptor_DefaultError"), p0);
  }
}
