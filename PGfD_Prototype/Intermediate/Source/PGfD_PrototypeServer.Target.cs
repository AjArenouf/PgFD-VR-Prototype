using UnrealBuildTool;

public class PGfD_PrototypeServerTarget : TargetRules
{
	public PGfD_PrototypeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PGfD_Prototype");
	}
}
