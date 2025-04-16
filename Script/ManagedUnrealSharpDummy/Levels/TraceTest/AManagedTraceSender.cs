using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedUnrealSharpDummy.Levels.TraceTest;

[UClass]
public class AManagedTraceSender : APawn
{
    protected override void BeginPlay()
    {
        base.BeginPlay();
        PrintString($"Logging message from {nameof(BeginPlay)} of {nameof(AManagedTraceSender)}.");
    }
}