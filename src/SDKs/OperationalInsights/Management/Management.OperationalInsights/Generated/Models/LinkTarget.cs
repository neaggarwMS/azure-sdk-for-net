// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Metadata for a workspace that isn't linked to an Azure subscription.
    /// </summary>
    public partial class LinkTarget
    {
        /// <summary>
        /// Initializes a new instance of the LinkTarget class.
        /// </summary>
        public LinkTarget() { }

        /// <summary>
        /// Initializes a new instance of the LinkTarget class.
        /// </summary>
        /// <param name="customerId">The GUID that uniquely identifies the
        /// workspace. </param>
        /// <param name="displayName">The display name of the
        /// workspace.</param>
        /// <param name="workspaceName">The DNS valid workspace name.</param>
        /// <param name="location">The location of the workspace.</param>
        public LinkTarget(string customerId = default(string), string displayName = default(string), string workspaceName = default(string), string location = default(string))
        {
            CustomerId = customerId;
            DisplayName = displayName;
            WorkspaceName = workspaceName;
            Location = location;
        }

        /// <summary>
        /// Gets or sets the GUID that uniquely identifies the workspace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the workspace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accountName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the DNS valid workspace name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workspaceName")]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Gets or sets the location of the workspace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
