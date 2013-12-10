using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jint.Test262.Support
{
    internal static class Timeout
    {
        public static T Run<T>(Func<T> action, TimeSpan timeout)
        {
            T result = default(T);
            ExceptionDispatchInfo exception = null;

            using (var @event = new ManualResetEvent(false))
            {
                var thread = new Thread(p =>
                {
                    try
                    {
                        result = action();
                    }
                    catch (Exception e)
                    {
                        bool isAbort = false;

                        var current = e;
                        while (current != null)
                        {
                            isAbort = current is ThreadAbortException;
                            if (isAbort)
                                break;
                            current = current.InnerException;
                        }

                        if (!isAbort)
                            exception = ExceptionDispatchInfo.Capture(e);
                    }
                    finally
                    {
                        @event.Set();
                    }
                });

                thread.Start();

                bool success = @event.WaitOne(timeout);

                if (!success)
                    thread.Abort();

                thread.Join();

                if (!success)
                    throw new InvalidOperationException("Timeout expired");
            }

            if (exception != null)
                exception.Throw();

            return result;
        }
    }
}
