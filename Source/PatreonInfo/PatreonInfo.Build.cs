// Copyright Green Forest Games. All Rights Reserved.

using UnrealBuildTool;

public class PatreonInfo : ModuleRules
{
	public PatreonInfo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

#if UE_5_2_OR_LATER
		IWYUSupport = IWYUSupport.Full;
#else
		bEnforceIWYU = true;
#endif

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"UMG",
			"CoreUObject",
			"Engine",
			"HTTP",
			"Json",
			"JsonUtilities",
			"ApplicationCore" // Clipboard
		});

#if UE_4_26_OR_LATER
		PublicDependencyModuleNames.AddRange(new[]
		{
			"DeveloperSettings"
		});
#endif
	}
}