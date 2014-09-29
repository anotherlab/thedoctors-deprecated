using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorXF.Resources;

namespace DoctorXF
{
    public class LocalizedStrings
    {
        private static readonly LocalizationResources _LocalizationResources = new LocalizationResources();

        public LocalizationResources LocalizationResources { get { return _LocalizationResources; } }
    }
}
