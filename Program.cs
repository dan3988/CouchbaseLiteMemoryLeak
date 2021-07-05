using System;
using System.Diagnostics;

using Couchbase.Lite;

Couchbase.Lite.Support.NetDesktop.EnableTextLogging("cb.log");

var blob = new Blob("application/x-binary", new byte[20 * 1024 * 1204]);
var array = new MutableArrayObject();
var sw = Stopwatch.StartNew();

array.AddBlob(blob);

sw.Stop();

Console.WriteLine(sw.Elapsed);