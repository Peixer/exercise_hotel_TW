namespace CSharpTestProject.Core
{
    public class FloresHotel : Hotel
    {
        public override string Name => "Parque das flores";
        public override int Classification => 3;
        protected override int RegularWeek => 110;
        protected override int FidelidadeWeek => 80;
        protected override int RegularWeekend => 90;
        protected override int FidelidadeWeekend => 80;
    }
}