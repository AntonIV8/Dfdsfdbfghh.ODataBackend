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
    /// User_role.
    /// </summary>
    //  *** Start programmer edit section *** (user_role CustomAttributes)

    //  *** End programmer edit section *** (user_role CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("user_roleE", new string[] {
            "role_id as \'Role_id\'",
            "role_id.name as \'Name\'",
            "user_id as \'User_id\'",
            "user_id.login as \'Login\'"})]
    [View("user_roleL", new string[] {
            "role_id.name as \'Name\'",
            "user_id.login as \'Login\'"})]
    public class user_role : ICSSoft.STORMNET.DataObject
    {
        
        private DataLine.dfdsfdbfghh.role frole_id;
        
        private DataLine.dfdsfdbfghh.usr fuser_id;
        
        //  *** Start programmer edit section *** (user_role CustomMembers)

        //  *** End programmer edit section *** (user_role CustomMembers)

        
        /// <summary>
        /// User_role.
        /// </summary>
        //  *** Start programmer edit section *** (user_role.role_id CustomAttributes)

        //  *** End programmer edit section *** (user_role.role_id CustomAttributes)
        [PropertyStorage(new string[] {
                "role_id"})]
        [NotNull()]
        public virtual DataLine.dfdsfdbfghh.role role_id
        {
            get
            {
                //  *** Start programmer edit section *** (user_role.role_id Get start)

                //  *** End programmer edit section *** (user_role.role_id Get start)
                DataLine.dfdsfdbfghh.role result = this.frole_id;
                //  *** Start programmer edit section *** (user_role.role_id Get end)

                //  *** End programmer edit section *** (user_role.role_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (user_role.role_id Set start)

                //  *** End programmer edit section *** (user_role.role_id Set start)
                this.frole_id = value;
                //  *** Start programmer edit section *** (user_role.role_id Set end)

                //  *** End programmer edit section *** (user_role.role_id Set end)
            }
        }
        
        /// <summary>
        /// User_role.
        /// </summary>
        //  *** Start programmer edit section *** (user_role.user_id CustomAttributes)

        //  *** End programmer edit section *** (user_role.user_id CustomAttributes)
        [PropertyStorage(new string[] {
                "user_id"})]
        [NotNull()]
        public virtual DataLine.dfdsfdbfghh.usr user_id
        {
            get
            {
                //  *** Start programmer edit section *** (user_role.user_id Get start)

                //  *** End programmer edit section *** (user_role.user_id Get start)
                DataLine.dfdsfdbfghh.usr result = this.fuser_id;
                //  *** Start programmer edit section *** (user_role.user_id Get end)

                //  *** End programmer edit section *** (user_role.user_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (user_role.user_id Set start)

                //  *** End programmer edit section *** (user_role.user_id Set start)
                this.fuser_id = value;
                //  *** Start programmer edit section *** (user_role.user_id Set end)

                //  *** End programmer edit section *** (user_role.user_id Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "user_roleE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View user_roleE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("user_roleE", typeof(DataLine.dfdsfdbfghh.user_role));
                }
            }
            
            /// <summary>
            /// "user_roleL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View user_roleL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("user_roleL", typeof(DataLine.dfdsfdbfghh.user_role));
                }
            }
        }
    }
}
