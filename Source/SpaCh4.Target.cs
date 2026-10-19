using UnrealBuildTool;
using System.Collections.Generic;

public class SpaCh4Target : TargetRules
{
	public SpaCh4Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("SpaCh4");
	}
}
