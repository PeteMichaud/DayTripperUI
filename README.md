# DayTripper Pathfinding Tool

Initial release, this works but it's in a pretty rough state.

<img src="https://github.com/PeteMichaud/DayTripperUI/tree/master/Resources/screenshot.png" width=90%>

DayTripper is a .NET application that allows you to load an elevation 
map and specify a start point and end point to find the best path 
through the terrain given the parameters you set.

## Usage

After opening the program:

  1. Click Load Elevation Map 
  2. (Optional) Click to Load any or all of Passability, Water, or Road map. 
	* Note: These maps must all be the same size as the elevation map.
	* None of these are required
  3. Click Initialize Loaded Map
  4. Select Start and Goal Coordinates by either typing them into the number boxes, or by using the picker tool
  5. (Optional) Adjust the search settings to taste. (Note: the defaults are fine.)
  6. Once the map is done initializing, click Find Path
  7. (Optional) Adjust which layers are visible from the View menu

Protip: Zoom using the View menu, or by Alt + MouseWheel

## Map Details

  * I recommend using png files because they are relatively small and not lossy
  * Elevation Maps should be grayscale. Black is low, White is high.
  * All other maps should be black and white where white represents one of water, roads, or passable terrain
	* Technically it treats anything above 50% gray as white and anything below as black

## Example Maps

Elevation
<img src="https://github.com/PeteMichaud/DayTripperUI/tree/master/Resources/elevation.png" width=90%>

Passability
<img src="https://github.com/PeteMichaud/DayTripperUI/tree/master/Resources/passability.png" width=90%>

Water
<img src="https://github.com/PeteMichaud/DayTripperUI/tree/master/Resources/water.png" width=90%>

Roads
<img src="https://github.com/PeteMichaud/DayTripperUI/tree/master/Resources/roads.png" width=90%>

## Technical Details

  * Pathfinding uses a pretty optimized version of the A* algorithm.
  * If you want to change the step cost calculation check DayTripper.SearchTile.CalculateCost() 
    * Most people won't need to do this, since a lot of different settings are exposed in the SearchSettings
  * All the pathfinding is handled by the DTPathfinder DLL, which uses .NET core and should build on any 
	platform in case you want to use it, for example, in a Unity project.
  * The Winforms app isn't .NET core, but you may still be able to build it with mono. I haven't tried, but I 
	don't think I used any code that mono can't build.