//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CardLanguage.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CardLanguageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public interface ICardLanguageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.stage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStage([NotNull] CardLanguageParser.StageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.stage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStage([NotNull] CardLanguageParser.StageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.endcondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndcondition([NotNull] CardLanguageParser.EndconditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.endcondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndcondition([NotNull] CardLanguageParser.EndconditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.computermoves"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComputermoves([NotNull] CardLanguageParser.ComputermovesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.computermoves"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComputermoves([NotNull] CardLanguageParser.ComputermovesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.playermoves"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlayermoves([NotNull] CardLanguageParser.PlayermovesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.playermoves"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlayermoves([NotNull] CardLanguageParser.PlayermovesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.multigameaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultigameaction([NotNull] CardLanguageParser.MultigameactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.multigameaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultigameaction([NotNull] CardLanguageParser.MultigameactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.gameaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGameaction([NotNull] CardLanguageParser.GameactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.gameaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGameaction([NotNull] CardLanguageParser.GameactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.multiaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiaction([NotNull] CardLanguageParser.MultiactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.multiaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiaction([NotNull] CardLanguageParser.MultiactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAction([NotNull] CardLanguageParser.ActionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAction([NotNull] CardLanguageParser.ActionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.loccreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoccreate([NotNull] CardLanguageParser.LoccreateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.loccreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoccreate([NotNull] CardLanguageParser.LoccreateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.locationdef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocationdef([NotNull] CardLanguageParser.LocationdefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.locationdef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocationdef([NotNull] CardLanguageParser.LocationdefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.storagecreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStoragecreate([NotNull] CardLanguageParser.StoragecreateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.storagecreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStoragecreate([NotNull] CardLanguageParser.StoragecreateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.obj"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObj([NotNull] CardLanguageParser.ObjContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.obj"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObj([NotNull] CardLanguageParser.ObjContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.init"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInit([NotNull] CardLanguageParser.InitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.init"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInit([NotNull] CardLanguageParser.InitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.playerinit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlayerinit([NotNull] CardLanguageParser.PlayerinitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.playerinit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlayerinit([NotNull] CardLanguageParser.PlayerinitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.deckinit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeckinit([NotNull] CardLanguageParser.DeckinitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.deckinit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeckinit([NotNull] CardLanguageParser.DeckinitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.deck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeck([NotNull] CardLanguageParser.DeckContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.deck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeck([NotNull] CardLanguageParser.DeckContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] CardLanguageParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] CardLanguageParser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.pointsinit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointsinit([NotNull] CardLanguageParser.PointsinitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.pointsinit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointsinit([NotNull] CardLanguageParser.PointsinitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.awards"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAwards([NotNull] CardLanguageParser.AwardsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.awards"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAwards([NotNull] CardLanguageParser.AwardsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.setaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetaction([NotNull] CardLanguageParser.SetactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.setaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetaction([NotNull] CardLanguageParser.SetactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.incaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncaction([NotNull] CardLanguageParser.IncactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.incaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncaction([NotNull] CardLanguageParser.IncactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.decaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecaction([NotNull] CardLanguageParser.DecactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.decaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecaction([NotNull] CardLanguageParser.DecactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.moveaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoveaction([NotNull] CardLanguageParser.MoveactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.moveaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoveaction([NotNull] CardLanguageParser.MoveactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.copyaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopyaction([NotNull] CardLanguageParser.CopyactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.copyaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopyaction([NotNull] CardLanguageParser.CopyactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.turnaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTurnaction([NotNull] CardLanguageParser.TurnactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.turnaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTurnaction([NotNull] CardLanguageParser.TurnactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.removeaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemoveaction([NotNull] CardLanguageParser.RemoveactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.removeaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemoveaction([NotNull] CardLanguageParser.RemoveactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.shuffleaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShuffleaction([NotNull] CardLanguageParser.ShuffleactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.shuffleaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShuffleaction([NotNull] CardLanguageParser.ShuffleactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.createaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateaction([NotNull] CardLanguageParser.CreateactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.createaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateaction([NotNull] CardLanguageParser.CreateactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.createsto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatesto([NotNull] CardLanguageParser.CreatestoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.createsto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatesto([NotNull] CardLanguageParser.CreatestoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamelist([NotNull] CardLanguageParser.NamelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamelist([NotNull] CardLanguageParser.NamelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.loclist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoclist([NotNull] CardLanguageParser.LoclistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.loclist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoclist([NotNull] CardLanguageParser.LoclistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.loc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoc([NotNull] CardLanguageParser.LocContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.loc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoc([NotNull] CardLanguageParser.LocContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.imag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImag([NotNull] CardLanguageParser.ImagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.imag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImag([NotNull] CardLanguageParser.ImagContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.card"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCard([NotNull] CardLanguageParser.CardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.card"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCard([NotNull] CardLanguageParser.CardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.owner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOwner([NotNull] CardLanguageParser.OwnerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.owner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOwner([NotNull] CardLanguageParser.OwnerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.rawstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRawstorage([NotNull] CardLanguageParser.RawstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.rawstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRawstorage([NotNull] CardLanguageParser.RawstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.locstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocstorage([NotNull] CardLanguageParser.LocstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.locstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocstorage([NotNull] CardLanguageParser.LocstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.who"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWho([NotNull] CardLanguageParser.WhoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.who"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWho([NotNull] CardLanguageParser.WhoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.who2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWho2([NotNull] CardLanguageParser.Who2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.who2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWho2([NotNull] CardLanguageParser.Who2Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.trueany"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrueany([NotNull] CardLanguageParser.TrueanyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.trueany"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrueany([NotNull] CardLanguageParser.TrueanyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.whereclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhereclause([NotNull] CardLanguageParser.WhereclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.whereclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhereclause([NotNull] CardLanguageParser.WhereclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.boolatt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolatt([NotNull] CardLanguageParser.BoolattContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.boolatt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolatt([NotNull] CardLanguageParser.BoolattContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.attrcomp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttrcomp([NotNull] CardLanguageParser.AttrcompContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.attrcomp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttrcomp([NotNull] CardLanguageParser.AttrcompContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.cardatt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCardatt([NotNull] CardLanguageParser.CardattContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.cardatt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCardatt([NotNull] CardLanguageParser.CardattContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.posq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPosq([NotNull] CardLanguageParser.PosqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.posq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPosq([NotNull] CardLanguageParser.PosqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean([NotNull] CardLanguageParser.BooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean([NotNull] CardLanguageParser.BooleanContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.intop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntop([NotNull] CardLanguageParser.IntopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.intop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntop([NotNull] CardLanguageParser.IntopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.mult"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMult([NotNull] CardLanguageParser.MultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.mult"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMult([NotNull] CardLanguageParser.MultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.subtract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtract([NotNull] CardLanguageParser.SubtractContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.subtract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtract([NotNull] CardLanguageParser.SubtractContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.mod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMod([NotNull] CardLanguageParser.ModContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.mod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMod([NotNull] CardLanguageParser.ModContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.divide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivide([NotNull] CardLanguageParser.DivideContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.divide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivide([NotNull] CardLanguageParser.DivideContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.sizeof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSizeof([NotNull] CardLanguageParser.SizeofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.sizeof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSizeof([NotNull] CardLanguageParser.SizeofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.maxof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaxof([NotNull] CardLanguageParser.MaxofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.maxof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaxof([NotNull] CardLanguageParser.MaxofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.unionof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnionof([NotNull] CardLanguageParser.UnionofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.unionof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnionof([NotNull] CardLanguageParser.UnionofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.sum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSum([NotNull] CardLanguageParser.SumContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.sum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSum([NotNull] CardLanguageParser.SumContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] CardLanguageParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] CardLanguageParser.IntContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.namegr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamegr([NotNull] CardLanguageParser.NamegrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.namegr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamegr([NotNull] CardLanguageParser.NamegrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CardLanguageParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] CardLanguageParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CardLanguageParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] CardLanguageParser.NameContext context);
}