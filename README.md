# Framework Profiler

Here is a set of profilers which were used to test the performance between SwiftlyS2, CounterStrikeSharp and ModSharp.

Environment:

- 4 vCores x AMD Ryzen 9 9950X
- 12GB RAM DDR5
- `sv_stressbots 1`
- `mp_warmuptime 99999`
- 31 Bots
- 1 Player
- Linux

## Results

![Results](https://cdn.skuzzi.ro/9rhH3TkMjNM4660AjSF9NxH2tvHrUIqx.png)

## Memory Results

### SwiftlyS2

![MemResults](https://cdn.skuzzi.ro/g96yO0Q10ivfA6qxQF3ETHmEZIyWdIpe.png)

### CounterStrikeSharp

![MemResults](https://cdn.skuzzi.ro/P6Xw5TC1kZ4GnOAJbzsP0bypSCt1PgZx.png)

![MemLeaksResults](https://cdn.skuzzi.ro/yC6zfCsyfam6XkhUBwEFMMSR8iIjLmlN.png)

### ModSharp

![MemResults](https://cdn.skuzzi.ro/6kNWRBOXQqd3tISmFoKI4A6ie21KWfVk.png)

## Why is there no data for ConVar Replication?

There's no data because every time i tried to run the data, i got errors and client disconnect.

### CounterStrikeSharp

![Error](https://cdn.skuzzi.ro/AB2635LEeiQZa09EuqkfGl49rpra80TV.png)

### ModSharp

![Error](https://cdn.skuzzi.ro/OEO0XIVqC24ryFzCgf0gm1IqvuzXDCEX.png)

## Why is there no data for "CCLCMsg_Move Simulate Data"?

Because CounterStrikeSharp and ModSharp are not implementing handlers to work with net messages from clients to servers.