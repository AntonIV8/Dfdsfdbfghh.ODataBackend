﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLine.dfdsfdbfghh
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Product_catalog.
    /// </summary>
    //  *** Start programmer edit section *** (product_catalog CustomAttributes)

    //  *** End programmer edit section *** (product_catalog CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("product_catalogE", new string[] {
            "spec_id as \'Spec_id\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "version as \'Version\'"})]
    [View("product_catalogL", new string[] {
            "spec_id as \'Spec_id\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "version as \'Version\'"})]
    public class product_catalog : ICSSoft.STORMNET.DataObject
    {
        
        private int fspec_id;
        
        private string fname;
        
        private string fdescription;
        
        private int fversion;
        
        //  *** Start programmer edit section *** (product_catalog CustomMembers)

        //  *** End programmer edit section *** (product_catalog CustomMembers)

        
        /// <summary>
        /// spec_id.
        /// </summary>
        //  *** Start programmer edit section *** (product_catalog.spec_id CustomAttributes)

        //  *** End programmer edit section *** (product_catalog.spec_id CustomAttributes)
        [NotNull()]
        public virtual int spec_id
        {
            get
            {
                //  *** Start programmer edit section *** (product_catalog.spec_id Get start)

                //  *** End programmer edit section *** (product_catalog.spec_id Get start)
                int result = this.fspec_id;
                //  *** Start programmer edit section *** (product_catalog.spec_id Get end)

                //  *** End programmer edit section *** (product_catalog.spec_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (product_catalog.spec_id Set start)

                //  *** End programmer edit section *** (product_catalog.spec_id Set start)
                this.fspec_id = value;
                //  *** Start programmer edit section *** (product_catalog.spec_id Set end)

                //  *** End programmer edit section *** (product_catalog.spec_id Set end)
            }
        }
        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (product_catalog.name CustomAttributes)

        //  *** End programmer edit section *** (product_catalog.name CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (product_catalog.name Get start)

                //  *** End programmer edit section *** (product_catalog.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (product_catalog.name Get end)

                //  *** End programmer edit section *** (product_catalog.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (product_catalog.name Set start)

                //  *** End programmer edit section *** (product_catalog.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (product_catalog.name Set end)

                //  *** End programmer edit section *** (product_catalog.name Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (product_catalog.description CustomAttributes)

        //  *** End programmer edit section *** (product_catalog.description CustomAttributes)
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (product_catalog.description Get start)

                //  *** End programmer edit section *** (product_catalog.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (product_catalog.description Get end)

                //  *** End programmer edit section *** (product_catalog.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (product_catalog.description Set start)

                //  *** End programmer edit section *** (product_catalog.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (product_catalog.description Set end)

                //  *** End programmer edit section *** (product_catalog.description Set end)
            }
        }
        
        /// <summary>
        /// version.
        /// </summary>
        //  *** Start programmer edit section *** (product_catalog.version CustomAttributes)

        //  *** End programmer edit section *** (product_catalog.version CustomAttributes)
        [NotNull()]
        public virtual int version
        {
            get
            {
                //  *** Start programmer edit section *** (product_catalog.version Get start)

                //  *** End programmer edit section *** (product_catalog.version Get start)
                int result = this.fversion;
                //  *** Start programmer edit section *** (product_catalog.version Get end)

                //  *** End programmer edit section *** (product_catalog.version Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (product_catalog.version Set start)

                //  *** End programmer edit section *** (product_catalog.version Set start)
                this.fversion = value;
                //  *** Start programmer edit section *** (product_catalog.version Set end)

                //  *** End programmer edit section *** (product_catalog.version Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "product_catalogE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View product_catalogE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("product_catalogE", typeof(DataLine.dfdsfdbfghh.product_catalog));
                }
            }
            
            /// <summary>
            /// "product_catalogL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View product_catalogL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("product_catalogL", typeof(DataLine.dfdsfdbfghh.product_catalog));
                }
            }
        }
    }
}
