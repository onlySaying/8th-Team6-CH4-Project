using UnrealBuildTool;
using System.Collections.Generic;

public class SpaCh4EditorTarget : TargetRules
{
	public SpaCh4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("SpaCh4");
	}
}
