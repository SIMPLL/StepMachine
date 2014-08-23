namespace StepMachine
{
    /// <summary>
    /// StepCounter
    /// =============
    /// StepCounter Instance stores the number of basic calculations
    /// To use StepCounter accurately avoid using C#'s builtin data types
    /// StepCounter
    /// </summary>
    internal class StepCounter
    {
        private static readonly object LockInstance = new object();

        private volatile static StepCounter _instanceStepCounter;

        internal static StepCounter Instance
        {
            get
            {
                if (_instanceStepCounter != null)
                {
                    return _instanceStepCounter;
                }

                lock (LockInstance)
                {
                    if (_instanceStepCounter == null)
                    {
                        _instanceStepCounter = new StepCounter();
                    }
                }

                return _instanceStepCounter;
            }
        }

        internal int Steps { get; private set; }
        /// <summary>
        /// Increase step count by 1
        /// </summary>
        internal void CountStep()
        {
            Steps++;
        }

        /// <summary>
        /// Increase step count by given value
        /// </summary>
        /// <param name="steps">steps to increase</param>
        internal void CountStep(int steps)
        {
            Steps += steps;
        }

        internal void ResetStepCounter()
        {
            Steps = 0;
        }
    }
}