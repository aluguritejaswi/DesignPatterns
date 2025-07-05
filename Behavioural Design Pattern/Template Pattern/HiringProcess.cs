using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    public abstract class HiringProcess
    {
        public void HireFreshers()
        {
            FirstRoundTest();
            GroupDiscussion();
            TechincalInterview();
            HRInterview();
        }

        private void HRInterview()
        {
            Console.WriteLine("Conduct HR Interview");
        }

        public abstract void TechincalInterview();

        private void GroupDiscussion()
        {
            Console.WriteLine("Conduct Group Discussion");
        }

        public abstract void FirstRoundTest();
    }

    public class CSEDepartment : HiringProcess
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Conduct CSE Department - First Interview");
        }

        public override void TechincalInterview()
        {
            Console.WriteLine("Conduct CSE Department - Technique Interview");
        }
    }

    public class ECEDepartment : HiringProcess
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Conduct ECE Department - First Interview");
        }

        public override void TechincalInterview()
        {
            Console.WriteLine("Conduct ECE Department - Technique Interview");
        }
    }
}
