using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace CRD.Common
{
    public class AdapterItem
    {
        public ManagementObject MO;
        public string Caption;

        public AdapterItem(string caption, ManagementObject mo)
        {
            this.Caption = caption;
            this.MO = mo;
        }
        public override string ToString()
        {
            return Caption;
        }

    }
}
