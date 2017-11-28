# .NET-Misc
Different small examples

## Throw vs ThrowEx
throw ex - shorter stack trace   
throw - full stack trace

## CovarianceAndContravariance
https://stackoverflow.com/questions/2662369/covariance-and-contravariance-real-world-example   
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/index   
For example since .net 4.0 IEnumerable is Covariant!!! Using out/in you can define own types
that are covariant (casting up) or contravariant (casting down).
