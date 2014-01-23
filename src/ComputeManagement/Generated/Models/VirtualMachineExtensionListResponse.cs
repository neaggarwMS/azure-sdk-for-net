// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The List Resource Extensions operation response.
    /// </summary>
    public partial class VirtualMachineExtensionListResponse : OperationResponse, IEnumerable<VirtualMachineExtensionListResponse.ResourceExtension>
    {
        private IList<VirtualMachineExtensionListResponse.ResourceExtension> _resourceExtensions;
        
        /// <summary>
        /// The extensions that are available to add to your cloud service.
        /// </summary>
        public IList<VirtualMachineExtensionListResponse.ResourceExtension> ResourceExtensions
        {
            get { return this._resourceExtensions; }
            set { this._resourceExtensions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionListResponse class.
        /// </summary>
        public VirtualMachineExtensionListResponse()
        {
            this._resourceExtensions = new List<VirtualMachineExtensionListResponse.ResourceExtension>();
        }
        
        /// <summary>
        /// Gets the sequence of ResourceExtensions.
        /// </summary>
        public IEnumerator<VirtualMachineExtensionListResponse.ResourceExtension> GetEnumerator()
        {
            return this.ResourceExtensions.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ResourceExtensions.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An extension available to add to your virtual machine.
        /// </summary>
        public partial class ResourceExtension
        {
            private string _description;
            
            /// <summary>
            /// The description of the extension.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// The label that is used to identify the extension.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// The name of the extension.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _privateConfigurationSchema;
            
            /// <summary>
            /// The base64-encoded schema of the private configuration.
            /// </summary>
            public string PrivateConfigurationSchema
            {
                get { return this._privateConfigurationSchema; }
                set { this._privateConfigurationSchema = value; }
            }
            
            private string _publicConfigurationSchema;
            
            /// <summary>
            /// The base64-encoded schema of the public configuration.
            /// </summary>
            public string PublicConfigurationSchema
            {
                get { return this._publicConfigurationSchema; }
                set { this._publicConfigurationSchema = value; }
            }
            
            private string _publisher;
            
            /// <summary>
            /// The provider namespace of the extension. The provider namespace
            /// for Windows Azure extensions is Microsoft.Compute.
            /// </summary>
            public string Publisher
            {
                get { return this._publisher; }
                set { this._publisher = value; }
            }
            
            private string _sampleConfig;
            
            /// <summary>
            /// A sample configuration file for the resource extension.
            /// </summary>
            public string SampleConfig
            {
                get { return this._sampleConfig; }
                set { this._sampleConfig = value; }
            }
            
            private string _version;
            
            /// <summary>
            /// The version of the extension.
            /// </summary>
            public string Version
            {
                get { return this._version; }
                set { this._version = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ResourceExtension class.
            /// </summary>
            public ResourceExtension()
            {
            }
        }
    }
}
