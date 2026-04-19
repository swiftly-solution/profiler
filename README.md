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

<img width="1920" height="997" alt="WWhVWtt4o0uLpAM3pTntz5bV9of39q5A" src="https://github.com/user-attachments/assets/20ba2c7c-7bd1-4f98-ab01-72bd493c5da6" />


## Memory Results

### SwiftlyS2

<img width="227" height="66" alt="yLTICJRjx6TS6mHYPQj6ISsv1xElv2kW" src="https://github.com/user-attachments/assets/e1d3ab76-487c-4eae-9746-6a41d656c739" />


### CounterStrikeSharp

<img width="298" height="81" alt="P6Xw5TC1kZ4GnOAJbzsP0bypSCt1PgZx" src="https://github.com/user-attachments/assets/648fb6ff-bd3c-478b-a9f7-11be34939a41" />


<img width="368" height="126" alt="yC6zfCsyfam6XkhUBwEFMMSR8iIjLmlN" src="https://github.com/user-attachments/assets/28a4d819-9121-4cb2-8ba0-3667799b946f" />


### ModSharp

<img width="245" height="62" alt="aq8xK8O0ECRnqOf2FtKwnDj3SxnPVbut" src="https://github.com/user-attachments/assets/04f0d7ca-765f-43dc-8785-f0143603f04b" />

## Why is there no data for ConVar Replication?

There's no data because every time i tried to run the data, i got errors and client disconnect.

### CounterStrikeSharp

<img width="817" height="638" alt="AB2635LEeiQZa09EuqkfGl49rpra80TV" src="https://github.com/user-attachments/assets/1ff1ef5c-8c34-4889-9b20-54770c5d03f6" />

### ModSharp

<img width="550" height="483" alt="OEO0XIVqC24ryFzCgf0gm1IqvuzXDCEX" src="https://github.com/user-attachments/assets/525838d8-0f53-41a8-a793-cdab7bd33c19" />


## Why is there no data for "CCLCMsg_Move Simulate Data"?

Because CounterStrikeSharp and ModSharp are not implementing handlers to work with net messages from clients to servers.
