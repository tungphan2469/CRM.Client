namespace CRM.Utilities;

public static class TaskHelpers
{
    public static void FireAndForget(this Task task, bool configureAwait = false)
    {
        task.ConfigureAwait(configureAwait)
            .GetAwaiter()
            .OnCompleted(() =>
            {
                try
                {
                    task.GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in FireAndForget: {ex.Message}");
                }
            });
    }
}