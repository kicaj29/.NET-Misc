// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection;

Console.WriteLine("Hello, World!");

Console.WriteLine($"Activity.Current?.Id:       {Activity.Current?.Id}");
Console.WriteLine($"Activity.Current?.ParentId: {Activity.Current?.ParentId}");
Console.WriteLine("--------------------------------------------------");

// https://www.w3.org/TR/trace-context/#traceparent-header

// In this way we can create activity with selected traceId.
string traceId = "5bc8be621de4fccb9ac7df8dd6583333";
ActivityTraceId activityTraceId = ActivityTraceId.CreateFromString(traceId);

var firstActivity = new Activity("MyTestActivity");
firstActivity.SetIdFormat(ActivityIdFormat.W3C);

Console.WriteLine(firstActivity.Id);

ActivitySpanId createdActivitySpanId = ActivitySpanId.CreateRandom();

firstActivity.SetParentId(activityTraceId, createdActivitySpanId, ActivityTraceFlags.Recorded);
//activity.SetParentId("5bc8be621de4fccb9ac7df8dd6583333");

firstActivity.Start();

Console.WriteLine($"firstActivity.Id:           {firstActivity.Id}");
Console.WriteLine($"firstActivity.ParentId:     {firstActivity.ParentId}");
Console.WriteLine($"Activity.Current?.Id:       {Activity.Current?.Id}");
Console.WriteLine($"Activity.Current?.ParentId: {Activity.Current?.ParentId}");
Console.WriteLine("--------------------------------------------------");

var secondActivity = new Activity("MyTestActivityChild");
firstActivity.SetIdFormat(ActivityIdFormat.W3C);

activityTraceId = ActivityTraceId.CreateRandom();
createdActivitySpanId = ActivitySpanId.CreateRandom();

secondActivity.Start();
Console.WriteLine($"secondActivity.Id:          {secondActivity.Id} (it inherits traceId from the previous Activity.Current)");
Console.WriteLine($"secondActivity.ParentId:    {secondActivity.ParentId}");
Console.WriteLine($"Activity.Current?.Id:       {Activity.Current?.Id}");
Console.WriteLine($"Activity.Current?.ParentId: {Activity.Current?.ParentId} (it points to firstActivity.Id)");
Console.WriteLine("--------------------------------------------------");

secondActivity.Dispose();

Console.WriteLine($"firstActivity.Id:           {firstActivity.Id}");
Console.WriteLine($"firstActivity.ParentId:     {firstActivity.ParentId}");
Console.WriteLine($"Activity.Current?.Id:       {Activity.Current?.Id} (Activity.Current is again the same as firstActivity)");
Console.WriteLine($"Activity.Current?.ParentId: {Activity.Current?.ParentId}");
Console.WriteLine("--------------------------------------------------");

Console.ReadKey();

