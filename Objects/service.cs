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
    /// Service.
    /// </summary>
    //  *** Start programmer edit section *** (service CustomAttributes)

    //  *** End programmer edit section *** (service CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("serviceE", new string[] {
            "name as \'Name\'",
            "description as \'Description\'",
            "dt_created as \'Dt_created\'",
            "dt_started as \'Dt_started\'",
            "dt_ended as \'Dt_ended\'",
            "contragent_id as \'Contragent_id\'",
            "contragent_id.contragent as \'Contragent\'",
            "cfs_id as \'Cfs_id\'",
            "cfs_id.name as \'Name\'",
            "service_spec_id as \'Service_spec_id\'",
            "service_spec_id.enum as \'Enum\'",
            "state as \'State\'",
            "state.description as \'Description\'",
            "parent_id as \'Parent_id\'",
            "parent_id.name as \'Name\'",
            "state as \'State\'",
            "state.description as \'Description\'",
            "customer_id as \'Customer_id\'",
            "customer_id.customer as \'Customer\'",
            "contragent_id as \'Contragent_id\'",
            "contragent_id.contragent as \'Contragent\'",
            "cfs_id as \'Cfs_id\'",
            "cfs_id.name as \'Name\'"})]
    [View("serviceL", new string[] {
            "name as \'Name\'",
            "description as \'Description\'",
            "dt_created as \'Dt_created\'",
            "dt_started as \'Dt_started\'",
            "dt_ended as \'Dt_ended\'",
            "contragent_id as \'Contragent\'",
            "cfs_id as \'Name\'",
            "service_spec_id as \'Enum\'",
            "state as \'Description\'",
            "parent_id as \'Name\'",
            "state as \'Description\'",
            "customer_id as \'Customer\'",
            "contragent_id as \'Contragent\'",
            "cfs_id as \'Name\'"}, Hidden=new string[] {
            "contragent_id",
            "cfs_id",
            "service_spec_id",
            "state",
            "parent_id",
            "state",
            "customer_id",
            "contragent_id",
            "cfs_id"})]
    public class service : ICSSoft.STORMNET.DataObject
    {
        
        private string fname;
        
        private string fdescription;
        
        private System.DateTime fdt_created;
        
        private System.DateTime fdt_started;
        
        private System.DateTime fdt_ended;
        
        private DataLine.dfdsfdbfghh.service fparent_id;
        
        private DataLine.dfdsfdbfghh.service fcfs_id;
        
        private DataLine.dfdsfdbfghh.service_state fstate;
        
        private DataLine.dfdsfdbfghh.service_spec fservice_spec_id;
        
        private DataLine.dfdsfdbfghh.contragent fcontragent_id;
        
        private DataLine.dfdsfdbfghh.customer fcustomer_id;
        
        //  *** Start programmer edit section *** (service CustomMembers)

        //  *** End programmer edit section *** (service CustomMembers)

        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (service.name CustomAttributes)

        //  *** End programmer edit section *** (service.name CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (service.name Get start)

                //  *** End programmer edit section *** (service.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (service.name Get end)

                //  *** End programmer edit section *** (service.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.name Set start)

                //  *** End programmer edit section *** (service.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (service.name Set end)

                //  *** End programmer edit section *** (service.name Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (service.description CustomAttributes)

        //  *** End programmer edit section *** (service.description CustomAttributes)
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (service.description Get start)

                //  *** End programmer edit section *** (service.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (service.description Get end)

                //  *** End programmer edit section *** (service.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.description Set start)

                //  *** End programmer edit section *** (service.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (service.description Set end)

                //  *** End programmer edit section *** (service.description Set end)
            }
        }
        
        /// <summary>
        /// dt_created.
        /// </summary>
        //  *** Start programmer edit section *** (service.dt_created CustomAttributes)

        //  *** End programmer edit section *** (service.dt_created CustomAttributes)
        [NotNull()]
        public virtual System.DateTime dt_created
        {
            get
            {
                //  *** Start programmer edit section *** (service.dt_created Get start)

                //  *** End programmer edit section *** (service.dt_created Get start)
                System.DateTime result = this.fdt_created;
                //  *** Start programmer edit section *** (service.dt_created Get end)

                //  *** End programmer edit section *** (service.dt_created Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.dt_created Set start)

                //  *** End programmer edit section *** (service.dt_created Set start)
                this.fdt_created = value;
                //  *** Start programmer edit section *** (service.dt_created Set end)

                //  *** End programmer edit section *** (service.dt_created Set end)
            }
        }
        
        /// <summary>
        /// dt_started.
        /// </summary>
        //  *** Start programmer edit section *** (service.dt_started CustomAttributes)

        //  *** End programmer edit section *** (service.dt_started CustomAttributes)
        public virtual System.DateTime dt_started
        {
            get
            {
                //  *** Start programmer edit section *** (service.dt_started Get start)

                //  *** End programmer edit section *** (service.dt_started Get start)
                System.DateTime result = this.fdt_started;
                //  *** Start programmer edit section *** (service.dt_started Get end)

                //  *** End programmer edit section *** (service.dt_started Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.dt_started Set start)

                //  *** End programmer edit section *** (service.dt_started Set start)
                this.fdt_started = value;
                //  *** Start programmer edit section *** (service.dt_started Set end)

                //  *** End programmer edit section *** (service.dt_started Set end)
            }
        }
        
        /// <summary>
        /// dt_ended.
        /// </summary>
        //  *** Start programmer edit section *** (service.dt_ended CustomAttributes)

        //  *** End programmer edit section *** (service.dt_ended CustomAttributes)
        public virtual System.DateTime dt_ended
        {
            get
            {
                //  *** Start programmer edit section *** (service.dt_ended Get start)

                //  *** End programmer edit section *** (service.dt_ended Get start)
                System.DateTime result = this.fdt_ended;
                //  *** Start programmer edit section *** (service.dt_ended Get end)

                //  *** End programmer edit section *** (service.dt_ended Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.dt_ended Set start)

                //  *** End programmer edit section *** (service.dt_ended Set start)
                this.fdt_ended = value;
                //  *** Start programmer edit section *** (service.dt_ended Set end)

                //  *** End programmer edit section *** (service.dt_ended Set end)
            }
        }
        
        /// <summary>
        /// Service.
        /// </summary>
        //  *** Start programmer edit section *** (service.parent_id CustomAttributes)

        //  *** End programmer edit section *** (service.parent_id CustomAttributes)
        [PropertyStorage(new string[] {
                "parent_id"})]
        public virtual DataLine.dfdsfdbfghh.service parent_id
        {
            get
            {
                //  *** Start programmer edit section *** (service.parent_id Get start)

                //  *** End programmer edit section *** (service.parent_id Get start)
                DataLine.dfdsfdbfghh.service result = this.fparent_id;
                //  *** Start programmer edit section *** (service.parent_id Get end)

                //  *** End programmer edit section *** (service.parent_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.parent_id Set start)

                //  *** End programmer edit section *** (service.parent_id Set start)
                this.fparent_id = value;
                //  *** Start programmer edit section *** (service.parent_id Set end)

                //  *** End programmer edit section *** (service.parent_id Set end)
            }
        }
        
        /// <summary>
        /// Service.
        /// </summary>
        //  *** Start programmer edit section *** (service.cfs_id CustomAttributes)

        //  *** End programmer edit section *** (service.cfs_id CustomAttributes)
        [NotNull()]
        public virtual DataLine.dfdsfdbfghh.service cfs_id
        {
            get
            {
                //  *** Start programmer edit section *** (service.cfs_id Get start)

                //  *** End programmer edit section *** (service.cfs_id Get start)
                DataLine.dfdsfdbfghh.service result = this.fcfs_id;
                //  *** Start programmer edit section *** (service.cfs_id Get end)

                //  *** End programmer edit section *** (service.cfs_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.cfs_id Set start)

                //  *** End programmer edit section *** (service.cfs_id Set start)
                this.fcfs_id = value;
                //  *** Start programmer edit section *** (service.cfs_id Set end)

                //  *** End programmer edit section *** (service.cfs_id Set end)
            }
        }
        
        /// <summary>
        /// Service.
        /// </summary>
        //  *** Start programmer edit section *** (service.state CustomAttributes)

        //  *** End programmer edit section *** (service.state CustomAttributes)
        [NotNull()]
        public virtual DataLine.dfdsfdbfghh.service_state state
        {
            get
            {
                //  *** Start programmer edit section *** (service.state Get start)

                //  *** End programmer edit section *** (service.state Get start)
                DataLine.dfdsfdbfghh.service_state result = this.fstate;
                //  *** Start programmer edit section *** (service.state Get end)

                //  *** End programmer edit section *** (service.state Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.state Set start)

                //  *** End programmer edit section *** (service.state Set start)
                this.fstate = value;
                //  *** Start programmer edit section *** (service.state Set end)

                //  *** End programmer edit section *** (service.state Set end)
            }
        }
        
        /// <summary>
        /// Service.
        /// </summary>
        //  *** Start programmer edit section *** (service.service_spec_id CustomAttributes)

        //  *** End programmer edit section *** (service.service_spec_id CustomAttributes)
        [PropertyStorage(new string[] {
                "service_spec_id"})]
        [NotNull()]
        public virtual DataLine.dfdsfdbfghh.service_spec service_spec_id
        {
            get
            {
                //  *** Start programmer edit section *** (service.service_spec_id Get start)

                //  *** End programmer edit section *** (service.service_spec_id Get start)
                DataLine.dfdsfdbfghh.service_spec result = this.fservice_spec_id;
                //  *** Start programmer edit section *** (service.service_spec_id Get end)

                //  *** End programmer edit section *** (service.service_spec_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.service_spec_id Set start)

                //  *** End programmer edit section *** (service.service_spec_id Set start)
                this.fservice_spec_id = value;
                //  *** Start programmer edit section *** (service.service_spec_id Set end)

                //  *** End programmer edit section *** (service.service_spec_id Set end)
            }
        }
        
        /// <summary>
        /// Service.
        /// </summary>
        //  *** Start programmer edit section *** (service.contragent_id CustomAttributes)

        //  *** End programmer edit section *** (service.contragent_id CustomAttributes)
        [PropertyStorage(new string[] {
                "contragent_id"})]
        public virtual DataLine.dfdsfdbfghh.contragent contragent_id
        {
            get
            {
                //  *** Start programmer edit section *** (service.contragent_id Get start)

                //  *** End programmer edit section *** (service.contragent_id Get start)
                DataLine.dfdsfdbfghh.contragent result = this.fcontragent_id;
                //  *** Start programmer edit section *** (service.contragent_id Get end)

                //  *** End programmer edit section *** (service.contragent_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.contragent_id Set start)

                //  *** End programmer edit section *** (service.contragent_id Set start)
                this.fcontragent_id = value;
                //  *** Start programmer edit section *** (service.contragent_id Set end)

                //  *** End programmer edit section *** (service.contragent_id Set end)
            }
        }
        
        /// <summary>
        /// Service.
        /// </summary>
        //  *** Start programmer edit section *** (service.customer_id CustomAttributes)

        //  *** End programmer edit section *** (service.customer_id CustomAttributes)
        [PropertyStorage(new string[] {
                "customer_id"})]
        [NotNull()]
        public virtual DataLine.dfdsfdbfghh.customer customer_id
        {
            get
            {
                //  *** Start programmer edit section *** (service.customer_id Get start)

                //  *** End programmer edit section *** (service.customer_id Get start)
                DataLine.dfdsfdbfghh.customer result = this.fcustomer_id;
                //  *** Start programmer edit section *** (service.customer_id Get end)

                //  *** End programmer edit section *** (service.customer_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service.customer_id Set start)

                //  *** End programmer edit section *** (service.customer_id Set start)
                this.fcustomer_id = value;
                //  *** Start programmer edit section *** (service.customer_id Set end)

                //  *** End programmer edit section *** (service.customer_id Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "serviceE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View serviceE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("serviceE", typeof(DataLine.dfdsfdbfghh.service));
                }
            }
            
            /// <summary>
            /// "serviceL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View serviceL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("serviceL", typeof(DataLine.dfdsfdbfghh.service));
                }
            }
        }
    }
}
