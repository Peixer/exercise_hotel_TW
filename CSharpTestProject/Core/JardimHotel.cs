namespace CSharpTestProject.Core
{
    public class JardimHotel : IHotel
    {
        public override string Name => "Jardim Botânico";
        public override int Classification => 4;
        protected override int RegularWeek => 160;
        protected override int FidelidadeWeek => 110;
        protected override int RegularWeekend => 60;
        protected override int FidelidadeWeekend => 50;
    }
}