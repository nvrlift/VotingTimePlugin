# VotingTimePlugin
Plugin to let players vote for a server time at a specified interval.
## Configuration
Enable the plugin in `extra_cfg.yml`
```yaml
EnablePlugins:
- VotingTimePlugin
```

Example configuration (add to bottom of `extra_cfg.yml`)  
```yaml
---
!VotingTimeConfiguration
# How long the vote stays open
VotingDurationSeconds: 30
# How often a vote takes place
VotingIntervalMinutes: 10
```
