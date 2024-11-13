using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuleCoding.Code.HelperClasses;
public class Person
{
    public enum NiceOrNaughty
    {
        Nice,
        Naughty
    }
    public string Name { get; set; }
    public NiceOrNaughty NiceOrNaughtyStatus { get; set; }
}
