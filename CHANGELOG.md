# Changelog

All notable changes to Keep Starting Gear will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.1.1] - 2025-11-15

### Fixed
- **Critical**: Fixed gear loss after logout/login cycles
  - Implemented persistent death state tracking to prevent gear restoration on subsequent logins
  - Death state is now properly maintained across server restarts
  - Ensures gear is only restored once per death, immediately after raid end

### Changed
- Improved state management for more reliable gear restoration
- Enhanced logging for better debugging

### Technical
- Added `hasRestoredAfterDeath` flag to profile data for persistent tracking
- Death state is preserved in profile between sessions
- Cleanup of death state happens only after successful restoration

## [2.1.0] - 2025-11-14

### Added
- Initial public release
- Automatic gear restoration after death in raid
- Configuration options for customizing behavior
- Debug logging system
- Support for SPT 4.0.4+

### Features
- Restores equipment from selected inventory slots
- Configurable slots (pockets, tactical vest, armor vest, etc.)
- Toggle for including items inside equipped containers
- Scav run protection (doesn't interfere with scav runs)
- Works seamlessly with existing mods

## [Unreleased]

### Planned
- Additional configuration options based on user feedback
- Potential support for custom gear sets
- Performance optimizations if needed

---

## Version History Reference

- **2.1.1** - Logout/login gear loss fix (current)
- **2.1.0** - Initial release
