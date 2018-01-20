using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace StackoverFlowX
{
    [XmlRoot("StepList")]
    public class Steplist
    {
        [XmlElement("Step")]
        public List<Step> Steps { get; set; }
    }
    public class Step
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Desc")]
        public string Desc { get; set; }
    }
}
