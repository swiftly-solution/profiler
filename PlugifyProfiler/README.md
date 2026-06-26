# PlugifyProfiler

A C# profiling plugin for Plugify framework to monitor and analyze performance metrics in Source 2 games.

## Requirements

This plugin requires one of the following to run:
- **Plugify Launcher**, or
- **Metamod plugin** (khook branch)

For detailed installation guides for these requirements, visit:
**https://plugify.net/use-cases/integrations**

## Dependencies

To run this C# plugin, you need the following dependencies installed:

1. **Source 2 SDK Plugin** - Provides Source 2 game functions
2. **DotNet Language Module** - Required to execute C# plugins

## Installation

### 1. Install Required Modules and Plugins

Use the integrated package manager (mamba) to install all dependencies:

```bash
# Install C++ language module (required to run C++ plugins)
mamba install -n modules -c "https://untrustedmodders.github.io/plugify-module-cpp/" plugify-module-cpp

# Install plugin configuration support
mamba install -n plugins -c "https://untrustedmodders.github.io/plugify-plugin-configs/" plugify-plugin-configs

# Install PolyHook for function hooking
mamba install -n plugins -c "https://untrustedmodders.github.io/plugify-plugin-polyhook/" plugify-plugin-polyhook

# Install Source 2 SDK plugin (provides Source 2 game functions)
mamba install -n plugins -c "https://untrustedmodders.github.io/plugify-plugin-s2sdk/" plugify-plugin-s2sdk

# Install DotNet language module (required for C# plugins)
mamba install -n modules -c "https://untrustedmodders.github.io/plugify-module-dotnet/" plugify-module-dotnet
```

### 2. Install the Plugin

1. Build the plugin or download the pre-built binaries
2. Copy the plugin files to your Plugify plugins directory
3. Ensure the `PlugifyProfiler.pplugin` manifest and `PlugifyProfiler.dll` are in the same directory
4. Restart your game or reload Plugify plugins

## Usage

Once installed and loaded, the plugin will automatically start profiling the configured game functions and entities.

## Testing

To test this plugin, ensure you have:
- Plugify Launcher or Metamod plugin (khook branch) properly configured
- All dependencies installed via mamba
- A compatible Source 2 game running

## License

MIT License - See LICENSE file for details

## Author

untrustedmodders - https://github.com/untrustedmodders/