using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using ZompioParser.Contracts;

namespace ZompioParser.Contracts
{
    public class FormView
    {
        public string Id { get; set; }

        public string FormLayout { get; set; }

        public  ZompioLayout  rootElement { get; set; }
    }


    public enum LayoutType
    {
        Default,
        Wizard
    }

    public class ZompioLayout :BaseControl
    {

        public ZompioLayout()
        {
            this.IsContainer = true;
        }

        
    }
}
