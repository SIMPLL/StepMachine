namespace StepMachine
{
    /// <summary>
    /// StepCountedLong
    /// =================
    /// All step conunting logic happens here
    ///
    /// </summary>
    public class StepCountedLong
    {
        /// <summary>
        /// Create new StepCountedLong, A Step is counted
        /// </summary>
        /// <param name="initialValue">initial Value</param>
        internal StepCountedLong(long initialValue)
        {
            StepCounter.Instance.CountStep();
            Number = initialValue;
        }

        /// <summary>
        /// Create new StepCountedLong, A Step is counted, initial value is 0
        /// </summary>
        internal StepCountedLong()
            : this(0)
        {
        }

        #region Properties

        /// <summary>
        /// Readonly Number Value
        /// </summary>
        public long Number { get; private set; }

        #endregion Properties

        #region Operators

        public static StepCountedLong operator +(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return new StepCountedLong(x.Number + y.Number);
        }

        public static StepCountedLong operator -(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return new StepCountedLong(x.Number - y.Number);
        }

        public static StepCountedLong operator *(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return new StepCountedLong(x.Number * y.Number);
        }

        public static StepCountedLong operator /(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return new StepCountedLong(x.Number / y.Number);
        }

        public static StepCountedLong operator %(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return new StepCountedLong(x.Number % y.Number);
        }

        public static StepCountedLong operator --(StepCountedLong x)
        {
            StepCounter.Instance.CountStep();
            x.Number--;
            return x;
        }

        public static StepCountedLong operator ++(StepCountedLong x)
        {
            StepCounter.Instance.CountStep();
            x.Number++;
            return x;
        }

        public static StepCountedLong operator ~(StepCountedLong x)
        {
            StepCounter.Instance.CountStep();
            x.Number = ~x.Number;
            return x;
        }

        public static bool operator false(StepCountedLong x)
        {
            StepCounter.Instance.CountStep();
            return (x.Number == 0);
        }

        public static bool operator true(StepCountedLong x)
        {
            StepCounter.Instance.CountStep();
            return (x.Number != 0);
        }

        /// <summary>
        /// if both are null return true if only one is null false
        /// otherwise true if Number values are same
        /// </summary>
        /// <param name="x">left hand side</param>
        /// <param name="y">right hand side</param>
        /// <returns>Equality</returns>
        public static bool operator ==(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();

            if (ReferenceEquals(x, null) && ReferenceEquals(y, null))
            {
                return true;
            }

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
            {
                return false;
            }

            return (x.Number == y.Number);
        }

        public static bool operator !=(StepCountedLong x, StepCountedLong y)
        {
            //not "==", steps are not counted because "==" is used
            return !(x.Number == y.Number);
        }

        public static bool operator >=(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return (x.Number >= y.Number);
        }

        public static bool operator <=(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return (x.Number <= y.Number);
        }

        public static bool operator <(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return (x.Number < y.Number);
        }

        public static bool operator >(StepCountedLong x, StepCountedLong y)
        {
            StepCounter.Instance.CountStep();
            return (x != null && y != null && x.Number > y.Number);
        }

        #endregion Operators

        public override bool Equals(object obj)
        {
            StepCounter.Instance.CountStep();
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            return (obj.GetType() == GetType() &&
                ((StepCountedLong)obj).Number == Number);
        }

        public override int GetHashCode()
        {
            //use the Number, limit to int maxvalue
            return (int)(Number & int.MaxValue);
        }

        public override string ToString()
        {
            return Number.ToString();
        }

        protected bool Equals(StepCountedLong other)
        {
            StepCounter.Instance.CountStep();
            return (Number == other.Number);
        }
    }
}