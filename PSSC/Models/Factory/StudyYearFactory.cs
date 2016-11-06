using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Factory
{
    class StudyYearFactory
    {
        public static readonly StudyYearFactory Instance = new StudyYearFactory();

        public StudyYearFactory()
        {

        }

        public Deanship.StudyYear createInstance(Deanship.StudyYear studyYear)
        {
            return studyYear;
        }
    }
}
