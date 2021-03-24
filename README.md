C# OpenPixelControl Client
==========================

An [OpenPixelControl protocol](http://openpixelcontrol.org) client written in C#, with support for the [Fadecandy](http://www.misc.name/fadecandy/) LED controller board specifically.

This is a fork of [Hunter Carlson's OpenPixelControl library](https://github.com/HunterCarlson/OpenPixelControl), mildly modified for ease of integration into Unity projects as a DLL.

Modified to:
- Use persistent TCP connections instead of per-message connections. (Avoids out-of-memory crashes [discussed here](https://github.com/scanlime/fadecandy/issues/28#issuecomment-42154605).)
- Build a library instead of a console application. (The console application is retained as an example.)
- Forego some extra functionality, such as WebSockets support and the FadeCandyGui example.
