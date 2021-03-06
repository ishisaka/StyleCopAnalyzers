﻿namespace StyleCop.Analyzers.DocumentationRules
{
    using System.Collections.Immutable;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.Diagnostics;

    /// <summary>
    /// From StyleCop 4.5 this rule is disabled by default. A section of the XML header documentation for a C# element
    /// is too short.
    /// </summary>
    /// <remarks>
    /// <para>C# syntax provides a mechanism for inserting documentation for classes and elements directly into the
    /// code, through the use of XML documentation headers. For an introduction to these headers and a description of
    /// the header syntax, see the following article:
    /// <see href="http://msdn.microsoft.com/en-us/magazine/cc302121.aspx">XML Comments Let You Build Documentation
    /// Directly From Your Visual Studio .NET Source Files</see>.</para>
    ///
    /// <para>A violation of this rule occurs when part of the documentation is too short. This can often indicate that
    /// the documentation is not descriptive. For example:</para>
    ///
    /// <code language="csharp">
    /// /// &lt;summary&gt;
    /// /// A name
    /// /// &lt;/summary&gt;
    /// public class Name
    /// {
    ///     ...
    /// }
    /// </code>
    /// </remarks>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SA1632DocumentationTextMustMeetMinimumCharacterLength : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "SA1632";
        internal const string Title = "Documentation text must meet minimum character length";
        internal const string MessageFormat = "TODO: Message format";
        internal const string Category = "StyleCop.CSharp.DocumentationRules";
        internal const string Description = "A section of the Xml header documentation for a C# element is too short.";
        internal const string HelpLink = "http://www.stylecop.com/docs/SA1632.html";

        public static readonly DiagnosticDescriptor Descriptor =
            new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, AnalyzerConstants.DisabledNoTests, Description, HelpLink);

        private static readonly ImmutableArray<DiagnosticDescriptor> _supportedDiagnostics =
            ImmutableArray.Create(Descriptor);

        /// <inheritdoc/>
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return _supportedDiagnostics;
            }
        }

        /// <inheritdoc/>
        public override void Initialize(AnalysisContext context)
        {
            // TODO: Implement analysis
        }
    }
}
