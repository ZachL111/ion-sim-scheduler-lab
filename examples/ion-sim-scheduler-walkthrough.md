# Ion Sim Scheduler Lab Walkthrough

I use this file as a small checklist before changing the C# implementation.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 154 | ship |
| stress | state drift | 191 | ship |
| edge | review cost | 165 | ship |
| recovery | decision risk | 201 | ship |
| stale | input pressure | 186 | ship |

Start with `recovery` and `baseline`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

If `baseline` becomes less cautious without a clear reason, I would inspect the drag input first.
