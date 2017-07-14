//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from YarnSpinnerParser.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="YarnSpinnerParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IYarnSpinnerParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.dialogue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDialogue([NotNull] YarnSpinnerParser.DialogueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNode([NotNull] YarnSpinnerParser.NodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeader([NotNull] YarnSpinnerParser.HeaderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header_title"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeader_title([NotNull] YarnSpinnerParser.Header_titleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeader_tag([NotNull] YarnSpinnerParser.Header_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header_line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeader_line([NotNull] YarnSpinnerParser.Header_lineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBody([NotNull] YarnSpinnerParser.BodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] YarnSpinnerParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.shortcut_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShortcut_statement([NotNull] YarnSpinnerParser.Shortcut_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.shortcut"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShortcut([NotNull] YarnSpinnerParser.ShortcutContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_statement([NotNull] YarnSpinnerParser.If_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.if_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_clause([NotNull] YarnSpinnerParser.If_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.else_if_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElse_if_clause([NotNull] YarnSpinnerParser.Else_if_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.else_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElse_clause([NotNull] YarnSpinnerParser.Else_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.set_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSet_statement([NotNull] YarnSpinnerParser.Set_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.option_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOption_statement([NotNull] YarnSpinnerParser.Option_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] YarnSpinnerParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.function_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_statement([NotNull] YarnSpinnerParser.Function_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.action_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAction_statement([NotNull] YarnSpinnerParser.Action_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.line_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine_statement([NotNull] YarnSpinnerParser.Line_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.hashtag_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHashtag_block([NotNull] YarnSpinnerParser.Hashtag_blockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.hashtag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHashtag([NotNull] YarnSpinnerParser.HashtagContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expParens</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpParens([NotNull] YarnSpinnerParser.ExpParensContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expMultDivMod</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpMultDivMod([NotNull] YarnSpinnerParser.ExpMultDivModContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expMultDivModEquals</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpMultDivModEquals([NotNull] YarnSpinnerParser.ExpMultDivModEqualsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expComparison</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpComparison([NotNull] YarnSpinnerParser.ExpComparisonContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expNegative</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpNegative([NotNull] YarnSpinnerParser.ExpNegativeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expAndOrXor</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpAndOrXor([NotNull] YarnSpinnerParser.ExpAndOrXorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expPlusMinusEquals</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpPlusMinusEquals([NotNull] YarnSpinnerParser.ExpPlusMinusEqualsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expAddSub</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpAddSub([NotNull] YarnSpinnerParser.ExpAddSubContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expNot</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpNot([NotNull] YarnSpinnerParser.ExpNotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expValue</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpValue([NotNull] YarnSpinnerParser.ExpValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>expEquality</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpEquality([NotNull] YarnSpinnerParser.ExpEqualityContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueNumber</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueNumber([NotNull] YarnSpinnerParser.ValueNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueTrue</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueTrue([NotNull] YarnSpinnerParser.ValueTrueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueFalse</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueFalse([NotNull] YarnSpinnerParser.ValueFalseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueVar</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueVar([NotNull] YarnSpinnerParser.ValueVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueString</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueString([NotNull] YarnSpinnerParser.ValueStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueFunc</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueFunc([NotNull] YarnSpinnerParser.ValueFuncContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>valueNull</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueNull([NotNull] YarnSpinnerParser.ValueNullContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] YarnSpinnerParser.VariableContext context);
}
