﻿# VotingTimingPlugin
Plugin to let players vote for a server time at a specified interval.

**Important:** For smooth weather transitions and rain you need to set `EnableWeatherFx` to `true` in `extra_cfg.yml`.
## Configuration
Enable the plugin in `extra_cfg.yml`
```yaml
EnablePlugins:
- VotingTimingPlugin
```

Example configuration (add to bottom of `extra_cfg.yml`)  
For a list of weather types that can be used with `BlacklistedWeathers` see [WeatherFX Types](https://assettoserver.org/docs/misc/wfx-types)
```yaml
---
!VotingTimingConfiguration
# Number of choices players can choose from at each voting interval
NumChoices: 3
# How long the vote stays open
VotingDurationSeconds: 30
# How often a vote takes place
VotingIntervalMinutes: 10
# Weather types that can't be voted on
BlacklistedWeathers:
- Cold
- Hot
- Windy
```
