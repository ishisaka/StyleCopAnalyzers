﻿namespace StyleCop.Analyzers.NamingRules
{
    using System.Collections.Immutable;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.Diagnostics;

    /// <summary>
    /// The name of a field or variable in C# does not begin with a lower-case letter.
    /// </summary>
    /// <remarks>
    /// <para>A violation of this rule occurs when the name of a field or variable begins with an upper-case letter.
    /// Constants, non-private readonly fields and static readonly must always start with an uppercase letter, whilst
    /// private readonly fields must start with a lowercase letter. Also, public or internal fields must always start
    /// with an uppercase letter.</para>
    ///
    /// <para>If the field or variable name is intended to match the name of an item associated with Win32 or COM, and
    /// thus needs to begin with an upper-case letter, place the field or variable within a special <c>NativeMethods</c>
    /// class. A <c>NativeMethods</c> class is any class which contains a name ending in <c>NativeMethods</c>, and is
    /// intended as a placeholder for Win32 or COM wrappers. StyleCop will ignore this violation if the item is placed
    /// within a <c>NativeMethods</c> class.</para>
    /// </remarks>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SA1306FieldNamesMustBeginWithLowerCaseLetter : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "SA1306";
        internal const string Title = "Field names must begin with lower-case letter";
        internal const string MessageFormat = "TODO: Message format";
        internal const string Category = "StyleCop.CSharp.NamingRules";
        internal const string Description = "The name of a field or variable in C# does not begin with a lower-case letter.";
        internal const string HelpLink = "http://www.stylecop.com/docs/SA1306.html";

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
