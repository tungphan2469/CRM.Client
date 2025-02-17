namespace CRM.Utilities.Navigation;

public static class UriHelper
{
    public const string GoBackSegment = "..";

    public const string GoBackQueryParameterName = "__GOBACK__";
    public const string DataQueryParameterName = "__DATA__";

    public static bool IsGoingBack(this IDictionary<string, object>? query)
    {
        return query != null && query.ContainsKey(GoBackQueryParameterName);
    }

    public static T? GetData<T>(this IDictionary<string, object>? query)
    {
        if (query == null) return default;

        var hasData = query.TryGetValue(DataQueryParameterName, out var arg);

        if (hasData && arg is T tValue) return tValue;

        return default;
    }

    public static string StandardPath(string target)
    {
        var route = $"{Shell.Current.CurrentState.Location.ToString()}/{target}";
        var segments = route.Split('/');
        var seenSegments = new HashSet<string>();
        var newSegments = new List<string>();

        foreach (var segment in segments)
        {
            if (seenSegments.Contains(segment))
            {
                newSegments.Remove(segment);
            }
            seenSegments.Add(segment);
            newSegments.Add(segment);
        }
        return $"/{string.Join("/", newSegments)}";
    }
}