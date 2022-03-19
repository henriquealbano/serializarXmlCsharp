using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlExemplo
{

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CATALOG
    {

        private CATALOGPLANT[] pLANTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PLANT")]
        public CATALOGPLANT[] PLANT
        {
            get
            {
                return this.pLANTField;
            }
            set
            {
                this.pLANTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CATALOGPLANT
    {

        private string cOMMONField;

        private string bOTANICALField;

        private string zONEField;

        private string lIGHTField;

        private string pRICEField;

        private string aVAILABILITYField;

        /// <remarks/>
        public string COMMON
        {
            get
            {
                return this.cOMMONField;
            }
            set
            {
                this.cOMMONField = value;
            }
        }

        /// <remarks/>
        public string BOTANICAL
        {
            get
            {
                return this.bOTANICALField;
            }
            set
            {
                this.bOTANICALField = value;
            }
        }

        /// <remarks/>
        public string ZONE
        {
            get
            {
                return this.zONEField;
            }
            set
            {
                this.zONEField = value;
            }
        }

        /// <remarks/>
        public string LIGHT
        {
            get
            {
                return this.lIGHTField;
            }
            set
            {
                this.lIGHTField = value;
            }
        }

        /// <remarks/>
        public string PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }

        /// <remarks/>
        public string AVAILABILITY
        {
            get
            {
                return this.aVAILABILITYField;
            }
            set
            {
                this.aVAILABILITYField = value;
            }
        }
    }


}
