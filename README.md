```markdown
# SerpentX: Evolution (WorkShopSnake)

This repository contains the Unity-based prototype for "SerpentX: Evolution", a 3D snake survival game. This scaffold provides starter scripts and documentation so development can begin in Unity 2021 LTS or later.

Quick start:
1. Clone the repo.
2. Open Unity Hub -> Add -> select this folder.
3. Create a new scene named "Main" and follow Assets/Scenes/README for setup.

Architecture highlights:
- Scripts under Assets/Scripts follow subsystem separation (Snake, AI, Score, Spawn, UI).
- Core starter scripts are included as skeletons: SnakeController, SegmentFollower, ScoreManager, GameManager, SpawnManager.

Next steps (recommended):
- Open Unity, create the Main scene and add a basic terrain and a player head GameObject.
- Attach SnakeController to the head and configure segment prefabs.
- Implement SpawnManager to spawn food prefabs and test pickups.

See DESIGN.md for the full design and roadmap.
```