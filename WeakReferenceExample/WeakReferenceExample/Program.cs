// https://learn.microsoft.com/en-us/dotnet/api/system.weakreference?view=net-7.0

// https://www.philosophicalgeek.com/2014/08/14/prefer-weakreferencet-to-weakreference/
// https://www.philosophicalgeek.com/2014/08/20/short-vs-long-weak-references-and-object-resurrection/

// "A weak reference allows the garbage collector to collect an object while still allowing an application to access the object."

// Create the cache.
using WeakReferenceExample;

int cacheSize = 50;
Random r = new Random();
Cache c = new Cache(cacheSize);

string DataName = "";
GC.Collect(0);
GC.WaitForPendingFinalizers();
//GC.Collect(0); // if we call WeakReference with trackResurrection = true call GC.Collect(0); to wipe objects from memory

// Randomly access objects in the cache.
for (int i = 0; i < c.Count; i++)
{
    int index = r.Next(c.Count);

    // Access the object by getting a property value.
    DataName = c[index].Name;
}
// Show results.
double regenPercent = c.RegenerationCount / (double)c.Count;
Console.WriteLine($"Cache size: {c.Count}, Regenerated: {regenPercent:P0}");

Console.WriteLine("-----------END-------------------");
