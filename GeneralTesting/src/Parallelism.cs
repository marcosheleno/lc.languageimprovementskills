namespace GeneralTesting;

public class Parallelism
{
    private int _endNumber = 100;
    private int _startNumber = 1;
    
    public long IsPrimeWithTaskRunning()
    {
        long result = 0;
        var range = _endNumber - _startNumber;
        var numberOfTasks = Environment.ProcessorCount;
        var tasks = new Task[numberOfTasks];
        var chunkSize = range / numberOfTasks;

        for (var i = 0; i < numberOfTasks; i++)
        {
            var chunkStart = _startNumber + chunkSize * i;
            var chunkEnd = i == numberOfTasks - 1 ? _endNumber : chunkStart + chunkSize;

            tasks[i] = Task.Run(() =>
            {
                for (var number = chunkStart; number < chunkEnd; number++)
                {
                    if (IsPrime(number))
                    {
                        Interlocked.Increment(ref result);
                    }
                }
            });
        }

        Task.WaitAll(tasks);

        return result;
    }
    
    private bool IsPrime(long number)
    {
        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0 || number <= 1)
        {
            return false;
        }

        for (long divisor = 3; divisor <= Math.Sqrt(number); divisor += 2)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}