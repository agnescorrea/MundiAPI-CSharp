/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class CreateAccessTokenRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? esxpiresIn;

        /// <summary>
        /// Minutes to expire the token
        /// </summary>
        [JsonProperty("esxpires_in")]
        public int? EsxpiresIn 
        { 
            get 
            {
                return this.esxpiresIn; 
            } 
            set 
            {
                this.esxpiresIn = value;
                onPropertyChanged("EsxpiresIn");
            }
        }
    }
} 