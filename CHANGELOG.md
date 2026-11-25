# Changelog

## [2.0.0] - 2026-11-25

Unity 6 release.

### Changed
- Requires Unity 6000.0 or newer.
- Code split into `Runtime/` (game code) and `Editor/` (Editor-only assembly, never in builds).
- Namespace `ArchNet.<Category>`; every file starts with a short description and a link to the documentation.
- Files moved with their `.meta`: existing scenes, prefabs and assets keep their references.
- Several masks can be highlighted at once (ids were never set, so only one could be).
- Clicks raise an `OnClick` event instead of doing nothing.
- Did not compile before (renamed CanvasExtension method); depends on Canvas Extension, now declared.
