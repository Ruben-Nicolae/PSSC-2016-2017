using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Factory
{
    class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();
        List<Subject.Subject> _subjects;


        private SubjectsFactory()
        {

        }

        public Subject.Subject createInstance(Subject.Subject subject)
        {

            subject = new Subject.Subject(new Subject.SubjectInformation());

            return subject;
        }
    }
}
