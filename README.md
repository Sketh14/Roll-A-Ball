# Roll-A-Ball
My First Game As A Game Programmer In Untiy 2018.2.6f1

Add everything when available.

Change 1.0 :-
-> Removed Plane(TriggerInvisibility) in Level 7 used to trigger GameplayInvisibility Object as it caused an error:-
   - [Physics.PhysX] QuickHullConvexHullLib::findSimplex: Simplex input points appers to be coplanar.
UnityEngine.GUIUtility:ProcessEvent(Int32, IntPtr)
   - Failed to create Convex Mesh from source mesh "Plane". An internal unspecified error has occured that could mean the Quickhull algorithm found the input mesh topologically challenging.
-> Added Cube instead with trigger.

Change 2.0 :-
-> Okay, the error fixed itself.
  -Disabled and enabled Plane(TriggerInvisibility) and changed the mesh collider settings
  -Diabled convex and tried again, error persisted
  -Re-enabled convex with trigger, no changes.
  -Changed some rotation values and did the following above, the error fixed itself! But I also Changed some values by disabling everything so I had to exit and reopen the project again
  -Surprise! The error is back, if it still persists, will change the Plane to Cube.
