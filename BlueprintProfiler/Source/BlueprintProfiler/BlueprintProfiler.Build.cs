// Copyright xnbmy 2026. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class BlueprintProfiler : ModuleRules
{
	public BlueprintProfiler(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		// 公有依赖：仅保留最核心的系统模块
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"Json",
				"JsonUtilities"
			}
		);

		// 私有依赖：所有编辑器相关的模块放在这里，不要与上方重复
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"UnrealEd",
				"Slate",
				"SlateCore",
				"EditorStyle",
				"EditorWidgets",
				"ToolMenus",
				"BlueprintGraph",
				"Kismet",
				"KismetCompiler",
				"GraphEditor",
				"AssetRegistry",
				"PropertyEditor",
				"WorkspaceMenuStructure",
				"LevelEditor",
				"Projects",
				"InputCore",
				"DesktopPlatform"
			}
		);
	}
}