using UnrealBuildTool;

public class PGfD_PrototypeTarget : TargetRules
{
	public PGfD_PrototypeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PGfD_Prototype");
	}
}
