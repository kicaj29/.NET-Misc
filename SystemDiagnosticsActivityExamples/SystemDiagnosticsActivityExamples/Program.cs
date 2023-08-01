// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

// https://www.w3.org/TR/trace-context/#traceparent-header

// In this way we can create activity with selected traceId.
string traceId = "5bc8be621de4fccb9ac7df8dd6583333";
ActivityTraceId activityTraceId = ActivityTraceId.CreateFromString(traceId);

var activity = new Activity("MyTestActivity");
activity.SetIdFormat(ActivityIdFormat.W3C);

Console.WriteLine(activity.Id);

ActivitySpanId createdActivitySpanId = ActivitySpanId.CreateRandom();

activity.SetParentId(activityTraceId, createdActivitySpanId, ActivityTraceFlags.Recorded);
//activity.SetParentId("5bc8be621de4fccb9ac7df8dd6583333");

activity.Start();

Console.WriteLine(activity.Id);
Console.WriteLine(Activity.Current?.Id);

Console.ReadKey();

