﻿namespace StyleCop.Analyzers.ReadabilityRules
{
    using System.Collections.Immutable;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.Diagnostics;

    /// <summary>
    /// The clauses within a C# query expression are not all placed on the same line, and each clause is not placed on
    /// its own line.
    /// </summary>
    /// <remarks>
    /// <para>A violation of this rule occurs when the query clauses are not either placed all on the same line, or each
    /// on its own line. For example:</para>
    /// <code language="csharp">
    /// object x = from num in numbers
    ///     select num;
    /// </code>
    /// <para>The query clauses can correctly be written as:</para>
    /// <code language="csharp">
    /// object x = from num in numbers select num;
    /// </code>
    /// <para>or:</para>
    /// <code language="csharp">
    /// object x =
    ///     from num in numbers
    ///     select num;
    /// </code>
    /// </remarks>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SA1103QueryClausesMustBeOnSeparateLinesOrAllOnOneLine : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "SA1103";
        internal const string Title = "Query clauses must be on separate lines or all on one line";
        internal const string MessageFormat = "TODO: Message format";
        internal const string Category = "StyleCop.CSharp.ReadabilityRules";
        internal const string Description = "The clauses within a C# query expression are not all placed on the same line, and each clause is not placed on its own line.";
        internal const string HelpLink = "http://www.stylecop.com/docs/SA1103.html";

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
