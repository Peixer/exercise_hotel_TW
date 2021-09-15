using System;
using System.ComponentModel;

namespace CSharpTestProject.Core
{
    public interface IHotel
    {
        public string Name { get; }
        public abstract int Classification { get; }
        protected abstract int RegularWeek { get; }
        protected abstract int FidelidadeWeek { get; }
        protected abstract int RegularWeekend { get; }
        protected abstract int FidelidadeWeekend { get; }
    }
}