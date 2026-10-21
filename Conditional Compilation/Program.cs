#define SHOW_EXTRA_INFO

using System;

Console.WriteLine("Application Started!");

#if DEBUG
Console.WriteLine("Debug configuration is active.");
#else
Console.WriteLine("Debug configuration is not active");
#endif


#if SHOW_EXTRA_INFO
Console.WriteLine("Display Extra Information");
#endif

