using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Engine;

namespace ManagedUnrealSharpDummy.Levels.TraceTest;

[UClass(ClassFlags.Abstract), GeneratedType("UTraceBluePrintFunctionLibrary", "ManagedUnrealSharpDummy.Levels.TraceTest.UTraceBluePrintFunctionLibrary")]
public class UTraceBluePrintFunctionLibrary : UBlueprintFunctionLibrary
{
    [UFunction(FunctionFlags.BlueprintCallable, Category = "Class"),GeneratedType(nameof(GetUniqueActorsByHitResult))]
    public static IList<AActor> GetUniqueActorsByHitResult(IList<FHitResult> hitResults) 
        => hitResults.Select(result => result.Actor).Distinct().ToList();
    
    [UFunction(FunctionFlags.BlueprintCallable, Category = "Class"),GeneratedType(nameof(GetUniqueHitResult))]
    public static IList<FHitResult> GetUniqueHitResult(IList<FHitResult> hitResults) 
        => hitResults.DistinctBy(result => result.Actor).ToList();
}