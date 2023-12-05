using UnrealBuildTool;

public class PGfD_PrototypeEditorTarget : TargetRules
{
	public PGfD_PrototypeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PGfD_Prototype");
	}
}
