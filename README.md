# ForceRoundEnd
An SCP:SL Exiled plugin that forces the round to end on command

### Notes
- This command will only run when there is at least 1 player on the server
- This command will only run by roles tha have the RoundEvent permission set

### RemoteAdmin Command
- forceend / roundend / fe / re (Ends the round at the current state)

### Config
```yaml
force_round_end:
# Sets whether this plugin will be enabled
  is_enabled: true
  # Sets whether this plugin will display a message when it is loaded/unloaded
  enable_log_message: true
```
