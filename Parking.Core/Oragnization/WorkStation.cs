namespace Parking.Core.Oragnization
{
    using System;
    using System.Runtime.CompilerServices;

    public class WorkStation : Park
    {
        public bool isPublic
        {
            get
            {
                return (!(!base.Attributes.ContainsKey("ISPUBLIC") || string.IsNullOrEmpty(base.Attributes["ISPUBLIC"].ToString())) && (base.Attributes["ISPUBLIC"].ToString() != "0"));
            }
        }

        public string mac { get; set; }

        public string resolution { get; set; }
    }
}

