namespace CSharpTestProject.Core
{
    public class AtlanticoHotel : Hotel
    {
        public override string Name => "Mar Atlântico";
        public override int Classification => 5;
        protected override int RegularWeek => 220;
        protected override int FidelidadeWeek => 100;
        protected override int RegularWeekend => 150;
        protected override int FidelidadeWeekend => 40;
    }
}