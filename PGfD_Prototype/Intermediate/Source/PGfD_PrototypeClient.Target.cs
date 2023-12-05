using UnrealBuildTool;

public class PGfD_PrototypeClientTarget : TargetRules
{
	public PGfD_PrototypeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PGfD_Prototype");
	}
}
