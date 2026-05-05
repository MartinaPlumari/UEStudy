// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UEStudy : ModuleRules
{
	public UEStudy(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UEStudy",
			"UEStudy/Variant_Platforming",
			"UEStudy/Variant_Platforming/Animation",
			"UEStudy/Variant_Combat",
			"UEStudy/Variant_Combat/AI",
			"UEStudy/Variant_Combat/Animation",
			"UEStudy/Variant_Combat/Gameplay",
			"UEStudy/Variant_Combat/Interfaces",
			"UEStudy/Variant_Combat/UI",
			"UEStudy/Variant_SideScrolling",
			"UEStudy/Variant_SideScrolling/AI",
			"UEStudy/Variant_SideScrolling/Gameplay",
			"UEStudy/Variant_SideScrolling/Interfaces",
			"UEStudy/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
