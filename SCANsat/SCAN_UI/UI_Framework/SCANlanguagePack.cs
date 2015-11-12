﻿using System;
using System.Collections.Generic;
using System.Linq;
using SCANsat.SCAN_Platform;
using System.Text.RegularExpressions;
using System.Reflection;

namespace SCANsat.SCAN_UI.UI_Framework
{
	public class SCANlanguagePack : SCAN_ConfigNodeStorage
	{
		[Persistent]
		public bool activePack = true;
		[Persistent]
		public string language = "English (USA)";

		//Settings Window Help Tooltips
		[Persistent]
		public string settingsHelpAnomalies = "Select the marker used to display anomalies on the map.";
		[Persistent]
		public string settingsHelpBackground = "Toggle background scanning on some or all celestial bodies.";
		[Persistent]
		public string settingsHelpTimeWarp = "Adjust the scanning frequency during TimeWarp. Higher settings result in fewer gaps in the maps but may have a performance impact at high TimeWarp.";
		[Persistent]
		public string settingsHelpGroundTracks = "Display a visible indicator of scanning activity in map mode.";
		[Persistent]
		public string settingsHelpGroundTracksActive = "The ground track indicator can be limited to only be displayed for the active vessel.";
		[Persistent]
		public string settingsHelpOverlayTooltips = "Displays tooltips for the current mouse position when a planetary overlay map is activated. These tooltips include The cursor coordinates, terrain height, slope, biome name, and resource abundance, depending on scanning coverage.";
		[Persistent]
		public string settingsHelpWindowTooltips = "Display tooltips on some map window buttons. These are primarily used to identify icon buttons.";
		[Persistent]
		public string settingsHelpStockToolbar = "Use the stock toolbar. Only one stock button is available. Can be used concurrently with the Blizzy78 Toolbar.";
		[Persistent]
		public string settingsHelpMechJeb = "The SCANsat zoom map target selection mode can be used to select a MechJeb landing site.";
		[Persistent]
		public string settingsHelpResetWindows = "Reset all window positions. Use this in case a window has been dragged completely off screen or if any windows are not visible.";
		[Persistent]
		public string settingsHelpResetPlanetData = "Resets all SCANsat data for the current celestial body. A confirmation window will open before activating Cannot be reversed.";
		[Persistent]
		public string settingsHelpResetAllData = "Resets all SCANsat data for all celestial bodies. A confirmation window will open before activating. Cannot be reversed.";
		[Persistent]
		public string settingsHelpVesselsSensorsPasses = "Information about the currently active SCANsat sensors. Vessels indicates the number of vessels with active sensors. Sensors indicates the total number of sensors; instruments with multiple sensor types count each individual sensor. Passes indicates the number of sensor updates performed per second This value is affected by the TimeWarp Resolution setting.";
		[Persistent]
		public string settingsHelpGreyScale = "Use a true grey-scale color spectrum for black-and-white SCANsat maps. Pixels on the altitude map will interpolate between black and white; the min and max terrain heights for each celestial body define the limits.";
		[Persistent]
		public string settingsHelpExportCSV = "Export a .csv file along with map texture when using the Export button on the big map. The file contains coordinates and the terrain height for each pixel. Pixels are labeled from left to right and from top to bottom.";
		[Persistent]
		public string settingsHelpSetMapWidth = "Enter an exact value for the SCANsat big map texture width. Values are limited to 550 - 9999 pixels wide. Press the Set button to apply the value.";

		//Resource Settings Window Help Tooltips
		[Persistent]
		public string resourceSettingsHelpOverlayWindow = "Open the planetary overlay map control window.";
		[Persistent]
		public string resourceSettingsHelpBiomeLock = "Circumvents the requirement for stock surface biome scans SCANsat displays will show the full accuracy for resource abundance with or without any surface biome scans.";
		[Persistent]
		public string resourceSettingsHelpInstant = "By default, the stock M700 resource scanner's orbital survey will fill in all SCANsat resource maps this can be disabled, requiring standard SCANsat methods for all resource scanning Disabled automatically when stock resource scanning is disabled.";
		[Persistent]
		public string resourceSettingsHelpNarrowBand = "Numerous SCANsat functions require a Narrow-Band resource scanner on-board the current vessel or in orbit of a celestial body for fully accurate resource abundance data. Disable this to circumvent these restrictions.";
		[Persistent]
		public string resourceSettingsHelpDisableStock = "Disables all stock resource scanning functions SCANsat scanning methods will be required for all resource data. Replaces several stock resource functions with SCANsat tools. These include The right-click readouts, the high resolution narrow-band scanner map, and the planetary overlay maps.";
		[Persistent]
		public string resourceSettingsHelpResetSCANsatResource = "Resets all SCANsat resource data for the current celestial body. Other SCANsat data is not affected. A confirmation window will open before activating. Cannot be reversed.";
		[Persistent]
		public string resourceSettingsHelpResetStockResource = "Resets the stock resource scanning coverage for the current celestial body. A reload or scene change may be required for all changes to take effect. A confirmation window will open before activating. Cannot be reversed.";
		[Persistent]
		public string resourceSettingsHelpOverlayInterpolation = "Change the number of resource abundance measurements used in constructing the planetary overlay and big map resource overlay. Decrease the value to increase the accuracy of the map Lower values will result in slower map generation.";
		[Persistent]
		public string resourceSettingsHelpOverlayHeight = "Change the texture size (map width is 2XHeight) used in constructing the planetary overlay and big map resource overlay. Increase the value to increase the quality and accuracy of the map. Higher values will result in slower map generation.";
		[Persistent]
		public string resourceSettingsHelpOverlayBiomeHeight = "Change the texture size (map width is 2XHeight) used in constructing the planetary overlay biome map. Increase the value to increase the quality and accuracy of the map. Higher values will result in slower map generation.";
		[Persistent]
		public string resourceSettingsHelpOverlayTransparency = "Create a grey background for planetary overlay resource maps. Used to make clear which sections of the celestial body have been scanned but contain no resources.";
		[Persistent]
		public string resourceSettingsHelpScanThreshold = "A threshold level used to apply the stock resource scan to a celestial body after scanning with SCANsat sensors. This is useful when contracts or other addons require that a stock resource scan be performed. Set a value from 0-100 in the text box and click on the Set button. The current celestial body will be checked immediately; other celestial bodies will be checked upon loading or upon entering another body's SOI.";

		//Color Config Window Help Tooltips
		[Persistent]
		public string colorTerrainHelpMin = "Defines the low altitude cutoff for the terrain color palette. Anything below this altitude will be shown with the lowest color.";
		[Persistent]
		public string colorTerrainHelpMax = "Defines the high altitude cutoff for the terrain color palette. Anything above this altitude will be shown with the highest color.";
		[Persistent]
		public string colorTerrainHelpClampToggle = "Used to define a cutoff between the low and high altitude values. This is particularly useful for ocean planets where it helps to define a sharp distinction between land and ocean.";
		[Persistent]
		public string colorTerrainHelpClamp = "Defines the clamp altitude cutoff. Anything below the cutoff will be represented by the first two colors in the selected color palette. Anything above the cutoff will be represented with the remaining colors.";
		[Persistent]
		public string colorTerrainHelpReverse = "Reverses the order of the currently selected color palette.";
		[Persistent]
		public string colorTerrainHelpDiscrete = "Draws the map using only the specific colors defined by each palette, instead of smoothly interpolating between them.";
		[Persistent]
		public string colorTerrainHelpPaletteSize = "Adjust the number of colors available in the currently selected color palette.";
		[Persistent]
		public string colorBiomeHelpStock = "Use the stock biome color scheme for SCANsat biome maps.";
		[Persistent]
		public string colorBiomeHelpWhiteBorder = "Draw a white border between biomes. Does not apply to the planetary overlay biome maps.";
		[Persistent]
		public string colorBiomeHelpTransparency = "Adjust the transparency of biome maps. Terrain elevation is shown behind the biome maps Set to 0% to disable terrain drawing.";
		[Persistent]
		public string colorPickerHelpLow = "The top color swatch shows the updated color selection for the low end of this color spectrum. The bottom color swatch shows the currently active color.";
		[Persistent]
		public string colorPickerHelpHigh = "The top color swatch shows the updated color selection for the high end of this color spectrum. The bottom color swatch shows the currently active color.";
		[Persistent]
		public string colorPickerHelpValue = "This slider adjusts the Value (in HSV color terms) or. Brightness for the currently selected color.";
		[Persistent]
		public string colorResourceHelpFineControl = "Activates Fine Control Mode where the sliders will only show values within 5% of the current selection.";
		[Persistent]
		public string colorResourceHelpMin = "The low cutoff for resource concentration on the selected celestial body. Resource deposits at this level will be displayed using the low end of the current resource overlay color spectrum Resource deposits below this value will not be shown.";
		[Persistent]
		public string colorResourceHelpMax = "The high cutoff for resource concentration on the selected celestial body. Resource deposits above this value will be shown using the high end of the current resource overlay color spectrum.";
		[Persistent]
		public string colorResourceHelpTransparency = "Defines the level of transparency for resource overlays. Increase to allow more of the underlying terrain, slope, or biome map to be visible. This also affect the transparency of resource deposits on the planetary overlay resource map.";
		[Persistent]
		public string colorResourceHelpApply = "Applies the current values for the selected resource and celestial body only.";
		[Persistent]
		public string colorResourceHelpApplyAll = "Applies the current values for the selected resource for all celestial bodies.";
		[Persistent]
		public string colorResourceHelpDefault = "Reverts to the default values for the selected resource and celestial body only.";
		[Persistent]
		public string colorResourceHelpDefaultAll = "Reverts to the default values for the selected resource for all celestial bodies.";
		[Persistent]
		public string colorHelpSaveToConfig = "Save all color configuration values to the config file found in your SCANsat/Resources folder These values serve as the defaults for new saves and for all. Revert To Default buttons Values do not need to be saved to the config file to be applied for this save file.";

		public override void OnDecodeFromConfigNode()
		{
			Regex openBracket = new Regex(@"\[(?=\d+:?\w?\d?\])");

			Regex closeBraket = new Regex(@"(?<=\{\d+:?\w?\d?)\]");

			Regex newLines = new Regex(@"\\n");

			var stringFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public).Where(a => a.FieldType == typeof(string)).ToList();

			for (int i = 0; i < stringFields.Count(); i++)
			{
				FieldInfo f = stringFields[i];

				f.SetValue(this, openBracket.Replace((string)f.GetValue(this), "{"));

				f.SetValue(this, closeBraket.Replace((string)f.GetValue(this), "}"));

				f.SetValue(this, newLines.Replace((string)f.GetValue(this), Environment.NewLine));
			}
		}

		public override void OnEncodeToConfigNode()
		{
			Regex openCurlyBracket = new Regex(@"\{(?=\d+:?\w?\d?\})");

			Regex closeCurlyBraket = new Regex(@"(?<=\[\d+:?\w?\d?)\}");

			Regex newLines = new Regex(@"\n");

			var stringFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public).Where(a => a.FieldType == typeof(string)).ToList();

			for (int i = 0; i < stringFields.Count(); i++)
			{
				FieldInfo f = stringFields[i];

				f.SetValue(this, openCurlyBracket.Replace((string)f.GetValue(this), "["));

				f.SetValue(this, closeCurlyBraket.Replace((string)f.GetValue(this), "]"));

				f.SetValue(this, newLines.Replace((string)f.GetValue(this), @"\n"));
			}
		}

	}
}
