# Aim-God
An external C# exploit for CS:GO

## The external approach
With most game hacks there's essentially two methods of achieving cheating, External and internal.
This hack was created in c# and so it's quite assumeable that this hack is external.

The basic approach to doing this is using race conditions to beat the game to changing a variable through memory. Accessing these variables seems easy in theory, but understanding process memory requires a decent knowledge of computer science. And therefore creates alot of unexplainable issues that will pop up like weeds in a garden.

## THIS IS NOT A DOWNLOADABLE HACK
I created this repo for educational purposes. Therefore I have excluded Memory.cs to avoid compilation.
Dont ask for copies, you're not getting one.

## Features
- Triggerbot (Random Reaction time variation)
- Visuals (Custom Team Colours, Custom player selection processing, Anti Flashbang, Inner Glow)
- Aimbot (Custom cursor movements, Custom player selection)
- Chams (Custom Colours, Brighter player models)
- Sleek UI (Thanks to Metro Framework)

## Understanding the code
The codebase for Aim God is built for customiseability in a modular fashion. All modules are started on seperate
threads that are held open through while loops.
Hack behaviours are custom and tweaked for user enjoyment.
All behaviour processing modules have a parent class that dictates the input and output. That processing
module is then selected by the end user and stored in Settings.cs where it can be accessed by respective hack modules.
 
 This method was chosen for its flexibility and exploit extendability.

 
 ## Points of interest
 - The entity class - Base.cs (This class is the interface between the majority of hack functions and Process Memory)
 - OffsetHandler.cs (This is the offset manager I created, A better implementation would be a Signature scanner)
