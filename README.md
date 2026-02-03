# HW4
## Devlog
In "FLoppy Bird", the systems in `Player` and `GameController` (keeping track of points and game state) were the "control", and the `UIController` was the "view" listening to them. The `Player` class especially was used to keep track of the logic, and then sent "notifications" (via events and delegates) to the `UIController` about important updates. The use of the event system through the singleton (`Locator`) made it much easier to notify the other scripts about changes without needing an instance of the `Player` and get/set methods to access the `_score` variable when it came to displaying points. While this is on the smaller scale of game projects, if there were more classes it would get really difficult to make sure everything lined up in the components and the scripts if we needed `Player` references everywhere. It's confusing even on small scale, so using the `Locator` singleton was good practice in having less wires crossed.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
