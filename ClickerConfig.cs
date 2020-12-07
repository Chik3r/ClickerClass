﻿using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ClickerClass
{
	[Label("Configuration")]
	public class ClickerConfigClient : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		// Automatically set by tModLoader
		public static ClickerConfigClient Instance;

		[Header("General Options")]

		[Label("Display Class Tags")]
		[Tooltip("Toggle the display of class tags for items made for custom classes on the tooltip")]
		[DefaultValue(true)]
		public bool ShowClassTags = true;
		
		[Label("Display 'hold auto select' text")]
		[Tooltip("Toggle the display of the 'Hold auto select for clicker effects' suggestion text for clicker weapons\n-The key will continue to work regardless of this toggle-")]
		[DefaultValue(true)]
		public bool ShowEffectSuggestion = true;

		[Label("Display Custom Cursors")]
		[Tooltip("Toggle the display of 'Custom Cursors' for clicker weapons")]
		[DefaultValue(true)]
		public bool ShowCustomCursors = true;
	}
}
