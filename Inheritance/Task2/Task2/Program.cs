using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom room = new ClassRoom(new GoodPupil(), new GoodPupil(), new BadPupil(), new ExcelentPupil());
            room.GetReadInfo();
            Console.ReadKey();
        }
    }

    public class Pupil
    {
        public virtual void Study()
        { }

        public virtual void Read()
        { }

        public virtual void Write()
        { }

        public virtual void Relax()
        { }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("excelent studying");
        }
        public override void Read()
        {
            Console.WriteLine("excelent reading");
        }
        public override void Write()
        {
            Console.WriteLine("excelent writing");
        }
        public override void Relax()
        {
            Console.WriteLine("excelent relaxing");
        }

    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("good studying");
        }
        public override void Read()
        {
            Console.WriteLine("good reading");
        }
        public override void Write()
        {
            Console.WriteLine("good writing");
        }
        public override void Relax()
        {
            Console.WriteLine("good relaxing");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("bad studying");
        }
        public override void Read()
        {
            Console.WriteLine("bad reading");
        }
        public override void Write()
        {
            Console.WriteLine("bad writing");
        }
        public override void Relax()
        {
            Console.WriteLine("bad relaxing");
        }

    }

    public class ClassRoom
    {
        Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if(pupils.Length > 4)
            {
                throw new Exception("Too many pupils for one class...");
            }
            this.pupils = pupils;
        }

        public void GetStudyInfo()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }

        public void GetReadInfo()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }

        public void GetWriteInfo()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }

        public void GetRealaxInfo()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }
    }

}
