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
    /// Resource_log.
    /// </summary>
    //  *** Start programmer edit section *** (resource_log CustomAttributes)

    //  *** End programmer edit section *** (resource_log CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("resource_logE", new string[] {
            "resource_id as \'Resource_id\'",
            "parent_id as \'Parent_id\'",
            "cfs_id as \'Cfs_id\'",
            "parent_service_id as \'Parent_service_id\'",
            "resource_shared_id as \'Resource_shared_id\'",
            "contragent_id as \'Contragent_id\'",
            "customer_id as \'Customer_id\'",
            "resource_spec_id as \'Resource_spec_id\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "external_id as \'External_id\'",
            "start_time as \'Start_time\'",
            "end_time as \'End_time\'"})]
    [View("resource_logL", new string[] {
            "resource_id as \'Resource_id\'",
            "parent_id as \'Parent_id\'",
            "cfs_id as \'Cfs_id\'",
            "parent_service_id as \'Parent_service_id\'",
            "resource_shared_id as \'Resource_shared_id\'",
            "contragent_id as \'Contragent_id\'",
            "customer_id as \'Customer_id\'",
            "resource_spec_id as \'Resource_spec_id\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "external_id as \'External_id\'",
            "start_time as \'Start_time\'",
            "end_time as \'End_time\'"})]
    public class resource_log : ICSSoft.STORMNET.DataObject
    {
        
        private int fresource_id;
        
        private int fparent_id;
        
        private int fcfs_id;
        
        private int fparent_service_id;
        
        private int fresource_shared_id;
        
        private int fcontragent_id;
        
        private int fcustomer_id;
        
        private int fresource_spec_id;
        
        private string fname;
        
        private string fdescription;
        
        private string fexternal_id;
        
        private System.DateTime fstart_time;
        
        private System.DateTime fend_time;
        
        //  *** Start programmer edit section *** (resource_log CustomMembers)

        //  *** End programmer edit section *** (resource_log CustomMembers)

        
        /// <summary>
        /// resource_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.resource_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.resource_id CustomAttributes)
        [NotNull()]
        public virtual int resource_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.resource_id Get start)

                //  *** End programmer edit section *** (resource_log.resource_id Get start)
                int result = this.fresource_id;
                //  *** Start programmer edit section *** (resource_log.resource_id Get end)

                //  *** End programmer edit section *** (resource_log.resource_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.resource_id Set start)

                //  *** End programmer edit section *** (resource_log.resource_id Set start)
                this.fresource_id = value;
                //  *** Start programmer edit section *** (resource_log.resource_id Set end)

                //  *** End programmer edit section *** (resource_log.resource_id Set end)
            }
        }
        
        /// <summary>
        /// parent_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.parent_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.parent_id CustomAttributes)
        public virtual int parent_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.parent_id Get start)

                //  *** End programmer edit section *** (resource_log.parent_id Get start)
                int result = this.fparent_id;
                //  *** Start programmer edit section *** (resource_log.parent_id Get end)

                //  *** End programmer edit section *** (resource_log.parent_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.parent_id Set start)

                //  *** End programmer edit section *** (resource_log.parent_id Set start)
                this.fparent_id = value;
                //  *** Start programmer edit section *** (resource_log.parent_id Set end)

                //  *** End programmer edit section *** (resource_log.parent_id Set end)
            }
        }
        
        /// <summary>
        /// cfs_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.cfs_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.cfs_id CustomAttributes)
        public virtual int cfs_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.cfs_id Get start)

                //  *** End programmer edit section *** (resource_log.cfs_id Get start)
                int result = this.fcfs_id;
                //  *** Start programmer edit section *** (resource_log.cfs_id Get end)

                //  *** End programmer edit section *** (resource_log.cfs_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.cfs_id Set start)

                //  *** End programmer edit section *** (resource_log.cfs_id Set start)
                this.fcfs_id = value;
                //  *** Start programmer edit section *** (resource_log.cfs_id Set end)

                //  *** End programmer edit section *** (resource_log.cfs_id Set end)
            }
        }
        
        /// <summary>
        /// parent_service_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.parent_service_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.parent_service_id CustomAttributes)
        public virtual int parent_service_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.parent_service_id Get start)

                //  *** End programmer edit section *** (resource_log.parent_service_id Get start)
                int result = this.fparent_service_id;
                //  *** Start programmer edit section *** (resource_log.parent_service_id Get end)

                //  *** End programmer edit section *** (resource_log.parent_service_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.parent_service_id Set start)

                //  *** End programmer edit section *** (resource_log.parent_service_id Set start)
                this.fparent_service_id = value;
                //  *** Start programmer edit section *** (resource_log.parent_service_id Set end)

                //  *** End programmer edit section *** (resource_log.parent_service_id Set end)
            }
        }
        
        /// <summary>
        /// resource_shared_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.resource_shared_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.resource_shared_id CustomAttributes)
        public virtual int resource_shared_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.resource_shared_id Get start)

                //  *** End programmer edit section *** (resource_log.resource_shared_id Get start)
                int result = this.fresource_shared_id;
                //  *** Start programmer edit section *** (resource_log.resource_shared_id Get end)

                //  *** End programmer edit section *** (resource_log.resource_shared_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.resource_shared_id Set start)

                //  *** End programmer edit section *** (resource_log.resource_shared_id Set start)
                this.fresource_shared_id = value;
                //  *** Start programmer edit section *** (resource_log.resource_shared_id Set end)

                //  *** End programmer edit section *** (resource_log.resource_shared_id Set end)
            }
        }
        
        /// <summary>
        /// contragent_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.contragent_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.contragent_id CustomAttributes)
        public virtual int contragent_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.contragent_id Get start)

                //  *** End programmer edit section *** (resource_log.contragent_id Get start)
                int result = this.fcontragent_id;
                //  *** Start programmer edit section *** (resource_log.contragent_id Get end)

                //  *** End programmer edit section *** (resource_log.contragent_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.contragent_id Set start)

                //  *** End programmer edit section *** (resource_log.contragent_id Set start)
                this.fcontragent_id = value;
                //  *** Start programmer edit section *** (resource_log.contragent_id Set end)

                //  *** End programmer edit section *** (resource_log.contragent_id Set end)
            }
        }
        
        /// <summary>
        /// customer_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.customer_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.customer_id CustomAttributes)
        public virtual int customer_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.customer_id Get start)

                //  *** End programmer edit section *** (resource_log.customer_id Get start)
                int result = this.fcustomer_id;
                //  *** Start programmer edit section *** (resource_log.customer_id Get end)

                //  *** End programmer edit section *** (resource_log.customer_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.customer_id Set start)

                //  *** End programmer edit section *** (resource_log.customer_id Set start)
                this.fcustomer_id = value;
                //  *** Start programmer edit section *** (resource_log.customer_id Set end)

                //  *** End programmer edit section *** (resource_log.customer_id Set end)
            }
        }
        
        /// <summary>
        /// resource_spec_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.resource_spec_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.resource_spec_id CustomAttributes)
        public virtual int resource_spec_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.resource_spec_id Get start)

                //  *** End programmer edit section *** (resource_log.resource_spec_id Get start)
                int result = this.fresource_spec_id;
                //  *** Start programmer edit section *** (resource_log.resource_spec_id Get end)

                //  *** End programmer edit section *** (resource_log.resource_spec_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.resource_spec_id Set start)

                //  *** End programmer edit section *** (resource_log.resource_spec_id Set start)
                this.fresource_spec_id = value;
                //  *** Start programmer edit section *** (resource_log.resource_spec_id Set end)

                //  *** End programmer edit section *** (resource_log.resource_spec_id Set end)
            }
        }
        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.name CustomAttributes)

        //  *** End programmer edit section *** (resource_log.name CustomAttributes)
        [StrLen(255)]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.name Get start)

                //  *** End programmer edit section *** (resource_log.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (resource_log.name Get end)

                //  *** End programmer edit section *** (resource_log.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.name Set start)

                //  *** End programmer edit section *** (resource_log.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (resource_log.name Set end)

                //  *** End programmer edit section *** (resource_log.name Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.description CustomAttributes)

        //  *** End programmer edit section *** (resource_log.description CustomAttributes)
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.description Get start)

                //  *** End programmer edit section *** (resource_log.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (resource_log.description Get end)

                //  *** End programmer edit section *** (resource_log.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.description Set start)

                //  *** End programmer edit section *** (resource_log.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (resource_log.description Set end)

                //  *** End programmer edit section *** (resource_log.description Set end)
            }
        }
        
        /// <summary>
        /// external_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.external_id CustomAttributes)

        //  *** End programmer edit section *** (resource_log.external_id CustomAttributes)
        [StrLen(128)]
        public virtual string external_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.external_id Get start)

                //  *** End programmer edit section *** (resource_log.external_id Get start)
                string result = this.fexternal_id;
                //  *** Start programmer edit section *** (resource_log.external_id Get end)

                //  *** End programmer edit section *** (resource_log.external_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.external_id Set start)

                //  *** End programmer edit section *** (resource_log.external_id Set start)
                this.fexternal_id = value;
                //  *** Start programmer edit section *** (resource_log.external_id Set end)

                //  *** End programmer edit section *** (resource_log.external_id Set end)
            }
        }
        
        /// <summary>
        /// start_time.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.start_time CustomAttributes)

        //  *** End programmer edit section *** (resource_log.start_time CustomAttributes)
        [NotNull()]
        public virtual System.DateTime start_time
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.start_time Get start)

                //  *** End programmer edit section *** (resource_log.start_time Get start)
                System.DateTime result = this.fstart_time;
                //  *** Start programmer edit section *** (resource_log.start_time Get end)

                //  *** End programmer edit section *** (resource_log.start_time Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.start_time Set start)

                //  *** End programmer edit section *** (resource_log.start_time Set start)
                this.fstart_time = value;
                //  *** Start programmer edit section *** (resource_log.start_time Set end)

                //  *** End programmer edit section *** (resource_log.start_time Set end)
            }
        }
        
        /// <summary>
        /// end_time.
        /// </summary>
        //  *** Start programmer edit section *** (resource_log.end_time CustomAttributes)

        //  *** End programmer edit section *** (resource_log.end_time CustomAttributes)
        [NotNull()]
        public virtual System.DateTime end_time
        {
            get
            {
                //  *** Start programmer edit section *** (resource_log.end_time Get start)

                //  *** End programmer edit section *** (resource_log.end_time Get start)
                System.DateTime result = this.fend_time;
                //  *** Start programmer edit section *** (resource_log.end_time Get end)

                //  *** End programmer edit section *** (resource_log.end_time Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_log.end_time Set start)

                //  *** End programmer edit section *** (resource_log.end_time Set start)
                this.fend_time = value;
                //  *** Start programmer edit section *** (resource_log.end_time Set end)

                //  *** End programmer edit section *** (resource_log.end_time Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "resource_logE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_logE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_logE", typeof(DataLine.dfdsfdbfghh.resource_log));
                }
            }
            
            /// <summary>
            /// "resource_logL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_logL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_logL", typeof(DataLine.dfdsfdbfghh.resource_log));
                }
            }
        }
    }
}
