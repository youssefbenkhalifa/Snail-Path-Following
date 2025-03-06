# Snail Path Following Using Unity Project

## Overview
This project implements a game where a snail character follows a predefined path within a Unity scene. The snail moves along a series of waypoints, rotates to face its direction of movement, and loops continuously.

## Features
- Movement along a set of waypoints.
- Automatic rotation to align with the direction of movement.
- Looping behavior to ensure continuous movement.
- Basic animation support for a more dynamic effect.

## Implementation Details

### Waypoint System
- The snail follows a sequence of waypoints placed as child objects under a `Path` GameObject.
- The script retrieves and stores the positions of these waypoints.
- A public variable allows assignment of the `Path` GameObject from the Unity Editor.

### Movement & Rotation
- The snail moves smoothly between waypoints using `Lerp` or `MoveTowards`.
- The rotation is handled using `Quaternion.LookRotation` to ensure the snail faces the direction of movement.


## How to Clone the Project
To clone this project, run the following command in your terminal:
```sh
 git clone https://github.com/youssefbenkhalifa/Snail-Path-Following
```
## Contribution
Feel free to modify and improve the project. Suggestions and contributions are always welcome!

## License
This project is open-source and free to use for educational and personal development purposes.