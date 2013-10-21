// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NPOI.OpenXmlFormats.Dml</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Dml
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextSpacingPercent
    {

        private int valField;
        /*<xsd:restriction base="ST_Percentage">
              <xsd:minInclusive value="0" />
              <xsd:maxInclusive value="13200000" />
          </xsd:restriction>*/
        [XmlAttribute]
        public int val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextSpacingPoint
    {

        private int valField;
        /*<xsd:restriction base="xsd:int">
              <xsd:minInclusive value="0" />
              <xsd:maxInclusive value="158400" />
          </xsd:restriction>*/
        [XmlAttribute]
        public int val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextTabStop
    {

        private int posField;

        private bool posFieldSpecified;

        private ST_TextTabAlignType algnField;

        private bool algnFieldSpecified;

        [XmlAttribute]
        public int pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        [XmlIgnore]
        public bool posSpecified
        {
            get
            {
                return this.posFieldSpecified;
            }
            set
            {
                this.posFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_TextTabAlignType algn
        {
            get
            {
                return this.algnField;
            }
            set
            {
                this.algnField = value;
            }
        }

        [XmlIgnore]
        public bool algnSpecified
        {
            get
            {
                return this.algnFieldSpecified;
            }
            set
            {
                this.algnFieldSpecified = value;
            }
        }
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextTabAlignType
    {

        /// <remarks/>
        l,

        /// <remarks/>
        ctr,

        /// <remarks/>
        r,

        /// <remarks/>
        dec,
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextTabStopList
    {

        private List<CT_TextTabStop> tabField;

        public CT_TextTabStopList()
        {
            this.tabField = new List<CT_TextTabStop>();
        }

        [XmlElement("tab", Order = 0)]
        public List<CT_TextTabStop> tab
        {
            get
            {
                return this.tabField;
            }
            set
            {
                this.tabField = value;
            }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextLineBreak
    {

        private CT_TextCharacterProperties rPrField;

        public CT_TextLineBreak()
        {
            this.rPrField = new CT_TextCharacterProperties();
        }

        [XmlElement(Order = 0)]
        public CT_TextCharacterProperties rPr
        {
            get
            {
                return this.rPrField;
            }
            set
            {
                this.rPrField = value;
            }
        }
    }

    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextSpacing
    {
        private CT_TextSpacingPercent spcPctField;
        private CT_TextSpacingPoint spcPtsField;

        public CT_TextSpacingPercent spcPct
        {
            get { return this.spcPctField; }
            set { this.spcPctField = value; }
        }
        public CT_TextSpacingPoint spcPts
        {
            get { return this.spcPtsField; }
            set { this.spcPtsField = value; }
        }
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextParagraphProperties
    {

        private CT_TextSpacing lnSpcField;

        private CT_TextSpacing spcBefField;

        private CT_TextSpacing spcAftField;

        private CT_TextBulletColorFollowText buClrTxField;

        private CT_Color buClrField;

        private CT_TextBulletSizeFollowText buSzTxField;

        private CT_TextBulletSizePercent buSzPctField;

        private CT_TextBulletSizePoint buSzPtsField;

        private CT_TextBulletTypefaceFollowText buFontTxField;

        private CT_TextFont buFontField;

        private CT_TextNoBullet buNoneField;

        private CT_TextAutonumberBullet buAutoNumField;

        private CT_TextCharBullet buCharField;

        private CT_TextBlipBullet buBlipField;

        private List<CT_TextTabStop> tabLstField;

        private CT_TextCharacterProperties defRPrField;

        private CT_OfficeArtExtensionList extLstField;

        private int marLField;

        private bool marLFieldSpecified;

        private int marRField;

        private bool marRFieldSpecified;

        private int lvlField;

        private bool lvlFieldSpecified;

        private int indentField;

        private bool indentFieldSpecified;

        private ST_TextAlignType algnField;

        private bool algnFieldSpecified;

        private int defTabSzField;

        private bool defTabSzFieldSpecified;

        private bool rtlField;

        private bool rtlFieldSpecified;

        private bool eaLnBrkField;

        private bool eaLnBrkFieldSpecified;

        private ST_TextFontAlignType fontAlgnField;

        private bool fontAlgnFieldSpecified;

        private bool latinLnBrkField;

        private bool latinLnBrkFieldSpecified;

        private bool hangingPunctField;

        private bool hangingPunctFieldSpecified;

        public CT_TextParagraphProperties()
        {
            //this.extLstField = new CT_OfficeArtExtensionList();
            //this.defRPrField = new CT_TextCharacterProperties();
            //this.tabLstField = new List<CT_TextTabStop>();
            //this.buBlipField = new CT_TextBlipBullet();
            //this.buCharField = new CT_TextCharBullet();
            //this.buAutoNumField = new CT_TextAutonumberBullet();
            //this.buNoneField = new CT_TextNoBullet();
            //this.buFontField = new CT_TextFont();
            //this.buFontTxField = new CT_TextBulletTypefaceFollowText();
            //this.buSzPtsField = new CT_TextBulletSizePoint();
            //this.buSzPctField = new CT_TextBulletSizePercent();
            //this.buSzTxField = new CT_TextBulletSizeFollowText();
            //this.buClrField = new CT_Color();
            //this.buClrTxField = new CT_TextBulletColorFollowText();
            //this.spcAftField = new CT_TextSpacing();
            //this.spcBefField = new CT_TextSpacing();
            //this.lnSpcField = new CT_TextSpacing();
        }

        [XmlElement(Order = 0)]
        public CT_TextSpacing lnSpc
        {
            get
            {
                return this.lnSpcField;
            }
            set
            {
                this.lnSpcField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_TextSpacing spcBef
        {
            get
            {
                return this.spcBefField;
            }
            set
            {
                this.spcBefField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_TextSpacing spcAft
        {
            get
            {
                return this.spcAftField;
            }
            set
            {
                this.spcAftField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_TextBulletColorFollowText buClrTx
        {
            get
            {
                return this.buClrTxField;
            }
            set
            {
                this.buClrTxField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_Color buClr
        {
            get
            {
                return this.buClrField;
            }
            set
            {
                this.buClrField = value;
            }
        }

        [XmlElement(Order = 5)]
        public CT_TextBulletSizeFollowText buSzTx
        {
            get
            {
                return this.buSzTxField;
            }
            set
            {
                this.buSzTxField = value;
            }
        }

        [XmlElement(Order = 6)]
        public CT_TextBulletSizePercent buSzPct
        {
            get
            {
                return this.buSzPctField;
            }
            set
            {
                this.buSzPctField = value;
            }
        }

        [XmlElement(Order = 7)]
        public CT_TextBulletSizePoint buSzPts
        {
            get
            {
                return this.buSzPtsField;
            }
            set
            {
                this.buSzPtsField = value;
            }
        }

        [XmlElement(Order = 8)]
        public CT_TextBulletTypefaceFollowText buFontTx
        {
            get
            {
                return this.buFontTxField;
            }
            set
            {
                this.buFontTxField = value;
            }
        }

        [XmlElement(Order = 9)]
        public CT_TextFont buFont
        {
            get
            {
                return this.buFontField;
            }
            set
            {
                this.buFontField = value;
            }
        }

        [XmlElement(Order = 10)]
        public CT_TextNoBullet buNone
        {
            get
            {
                return this.buNoneField;
            }
            set
            {
                this.buNoneField = value;
            }
        }

        [XmlElement(Order = 11)]
        public CT_TextAutonumberBullet buAutoNum
        {
            get
            {
                return this.buAutoNumField;
            }
            set
            {
                this.buAutoNumField = value;
            }
        }

        [XmlElement(Order = 12)]
        public CT_TextCharBullet buChar
        {
            get
            {
                return this.buCharField;
            }
            set
            {
                this.buCharField = value;
            }
        }

        [XmlElement(Order = 13)]
        public CT_TextBlipBullet buBlip
        {
            get
            {
                return this.buBlipField;
            }
            set
            {
                this.buBlipField = value;
            }
        }

        [XmlElement(Order = 14)]
        public List<CT_TextTabStop> tabLst
        {
            get
            {
                return this.tabLstField;
            }
            set
            {
                this.tabLstField = value;
            }
        }

        [XmlElement(Order = 15)]
        public CT_TextCharacterProperties defRPr
        {
            get
            {
                return this.defRPrField;
            }
            set
            {
                this.defRPrField = value;
            }
        }

        [XmlElement(Order = 16)]
        public CT_OfficeArtExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [XmlAttribute]
        public int marL
        {
            get
            {
                return this.marLField;
            }
            set
            {
                this.marLField = value;
            }
        }

        [XmlIgnore]
        public bool marLSpecified
        {
            get
            {
                return this.marLFieldSpecified;
            }
            set
            {
                this.marLFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int marR
        {
            get
            {
                return this.marRField;
            }
            set
            {
                this.marRField = value;
            }
        }

        [XmlIgnore]
        public bool marRSpecified
        {
            get
            {
                return this.marRFieldSpecified;
            }
            set
            {
                this.marRFieldSpecified = value;
            }
        }
        /*<xsd:restriction base="xsd:int">
            <xsd:minInclusive value="0" />
            <xsd:maxInclusive value="8" />
          </xsd:restriction>*/
        [XmlAttribute]
        public int lvl
        {
            get
            {
                return this.lvlField;
            }
            set
            {
                this.lvlField = value;
            }
        }

        [XmlIgnore]
        public bool lvlSpecified
        {
            get
            {
                return this.lvlFieldSpecified;
            }
            set
            {
                this.lvlFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int indent
        {
            get
            {
                return this.indentField;
            }
            set
            {
                this.indentField = value;
            }
        }

        [XmlIgnore]
        public bool indentSpecified
        {
            get
            {
                return this.indentFieldSpecified;
            }
            set
            {
                this.indentFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_TextAlignType algn
        {
            get
            {
                return this.algnField;
            }
            set
            {
                this.algnField = value;
            }
        }

        [XmlIgnore]
        public bool algnSpecified
        {
            get
            {
                return this.algnFieldSpecified;
            }
            set
            {
                this.algnFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int defTabSz
        {
            get
            {
                return this.defTabSzField;
            }
            set
            {
                this.defTabSzField = value;
            }
        }

        [XmlIgnore]
        public bool defTabSzSpecified
        {
            get
            {
                return this.defTabSzFieldSpecified;
            }
            set
            {
                this.defTabSzFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool rtl
        {
            get
            {
                return this.rtlField;
            }
            set
            {
                this.rtlField = value;
            }
        }

        [XmlIgnore]
        public bool rtlSpecified
        {
            get
            {
                return this.rtlFieldSpecified;
            }
            set
            {
                this.rtlFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool eaLnBrk
        {
            get
            {
                return this.eaLnBrkField;
            }
            set
            {
                this.eaLnBrkField = value;
            }
        }

        [XmlIgnore]
        public bool eaLnBrkSpecified
        {
            get
            {
                return this.eaLnBrkFieldSpecified;
            }
            set
            {
                this.eaLnBrkFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public ST_TextFontAlignType fontAlgn
        {
            get
            {
                return this.fontAlgnField;
            }
            set
            {
                this.fontAlgnField = value;
            }
        }

        [XmlIgnore]
        public bool fontAlgnSpecified
        {
            get
            {
                return this.fontAlgnFieldSpecified;
            }
            set
            {
                this.fontAlgnFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool latinLnBrk
        {
            get
            {
                return this.latinLnBrkField;
            }
            set
            {
                this.latinLnBrkField = value;
            }
        }

        [XmlIgnore]
        public bool latinLnBrkSpecified
        {
            get
            {
                return this.latinLnBrkFieldSpecified;
            }
            set
            {
                this.latinLnBrkFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool hangingPunct
        {
            get
            {
                return this.hangingPunctField;
            }
            set
            {
                this.hangingPunctField = value;
            }
        }

        [XmlIgnore]
        public bool hangingPunctSpecified
        {
            get
            {
                return this.hangingPunctFieldSpecified;
            }
            set
            {
                this.hangingPunctFieldSpecified = value;
            }
        }
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextAlignType
    {

        /// <remarks/>
        l,

        /// <remarks/>
        ctr,

        /// <remarks/>
        r,

        /// <remarks/>
        just,

        /// <remarks/>
        justLow,

        /// <remarks/>
        dist,

        /// <remarks/>
        thaiDist,
    }


    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public enum ST_TextFontAlignType
    {

        /// <remarks/>
        auto,

        /// <remarks/>
        t,

        /// <remarks/>
        ctr,

        /// <remarks/>
        @base,

        /// <remarks/>
        b,
    }


    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
    public class CT_TextField
    {

        private CT_TextCharacterProperties rPrField;

        private CT_TextParagraphProperties pPrField;

        private string tField;

        private string idField;

        private string typeField;

        public CT_TextField()
        {
            this.pPrField = new CT_TextParagraphProperties();
            this.rPrField = new CT_TextCharacterProperties();
        }

        [XmlElement(Order = 0)]
        public CT_TextCharacterProperties rPr
        {
            get
            {
                return this.rPrField;
            }
            set
            {
                this.rPrField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_TextParagraphProperties pPr
        {
            get
            {
                return this.pPrField;
            }
            set
            {
                this.pPrField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
}