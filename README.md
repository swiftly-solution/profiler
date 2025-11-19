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

![Results](https://cdn.skuzzi.ro/15TGv1nR8KF56BnxghfnsigWLAXTkQVn.png)

## Memory Results

### SwiftlyS2

![MemResults](https://cdn.skuzzi.ro/yLTICJRjx6TS6mHYPQj6ISsv1xElv2kW.png)

### CounterStrikeSharp

![MemResults](https://cdn.skuzzi.ro/P6Xw5TC1kZ4GnOAJbzsP0bypSCt1PgZx.png)

![MemLeaksResults](https://cdn.skuzzi.ro/yC6zfCsyfam6XkhUBwEFMMSR8iIjLmlN.png)

### ModSharp

![MemResults](https://cdn.skuzzi.ro/aq8xK8O0ECRnqOf2FtKwnDj3SxnPVbut.png)

## Why is there no data for ConVar Replication?

There's no data because every time i tried to run the data, i got errors and client disconnect.

### CounterStrikeSharp

![Error](https://cdn.skuzzi.ro/AB2635LEeiQZa09EuqkfGl49rpra80TV.png)

### ModSharp

![Error](https://cdn.skuzzi.ro/OEO0XIVqC24ryFzCgf0gm1IqvuzXDCEX.png)

## Why is there no data for "CCLCMsg_Move Simulate Data"?

Because CounterStrikeSharp and ModSharp are not implementing handlers to work with net messages from clients to servers.