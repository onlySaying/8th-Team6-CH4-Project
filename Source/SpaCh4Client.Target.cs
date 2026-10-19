using UnrealBuildTool;
using System.Collections.Generic;

public class SpaCh4ClientTarget : TargetRules
{
	public SpaCh4ClientTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("SpaCh4");
	}
}
