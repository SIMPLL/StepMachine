namespace StepMachine
{
    /// <summary>
    /// Stepper
    /// ==========
    /// Works as a Facade for the StepMachine
    /// call Start() whenever new algorithm is tested
    ///
    /// </summary>
    public class Stepper
    {
        /// <summary>
        /// Start or Rest StepCounter
        /// </summary>
        public static void Start()
        {
            StepCounter.Instance.ResetStepCounter();
        }

        public static int TotalSteps
        {
            get
            {
                return StepCounter.Instance.Steps;
            }
        }

        /// <summary>
        /// Create StepCountedLong
        /// </summary>
        /// <param name="initialValue">initial Value</param>
        /// <returns>StepCountedLong Object</returns>
        public static StepCountedLong NewLong(long initialValue)
        {
            return new StepCountedLong(initialValue);
        }

        /// <summary>
        /// Create StepCountedLong : Initialize to Zero
        /// </summary>
        /// <returns>StepCountedLong Object</returns>
        public static StepCountedLong NewLong()
        {
            return new StepCountedLong();
        }

        /// <summary>
        /// Create an array of StepCountedLong
        /// </summary>
        /// <param name="initialValues">initial values</param>
        /// <returns>StepCountedLong array</returns>
        public static StepCountedLong[] NewArrayOfLongs(params long[] initialValues)
        {
            var array = new StepCountedLong[initialValues.Length];
            //considered as initialize so the operation in the for loop is ignored
            for (int i = 0; i < initialValues.Length; i++)
            {
                array[i] = NewLong(initialValues[i]);
            }
            return array;
        }
    }
}