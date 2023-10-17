# VotingTimePlugin
Plugin to let players vote for a server time at a specified interval.

## Voting
Voting uses 24h format.

All voted times will be averaged.
### Example 1
- Vote 1: 14:00
- Vote 2: 18:00
- Vote 3: 21:00

Result: **17:30**

### Example 2
- Vote 1: 00:00
- Vote 2: 23:58

Result: **11:59**

## Command
``
/t 15:31
``


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
