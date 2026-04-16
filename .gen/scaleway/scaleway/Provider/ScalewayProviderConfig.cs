using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Provider
{
    [JsiiByValue(fqn: "scaleway.provider.ScalewayProviderConfig")]
    public class ScalewayProviderConfig : scaleway.Provider.IScalewayProviderConfig
    {
        /// <summary>The Scaleway access key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#access_key ScalewayProvider#access_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessKey
        {
            get;
            set;
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#alias ScalewayProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>The Scaleway API URL to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#api_url ScalewayProvider#api_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiUrl
        {
            get;
            set;
        }

        /// <summary>The Scaleway organization ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#organization_id ScalewayProvider#organization_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationId
        {
            get;
            set;
        }

        /// <summary>The Scaleway profile to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#profile ScalewayProvider#profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Profile
        {
            get;
            set;
        }

        /// <summary>The Scaleway project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#project_id ScalewayProvider#project_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectId
        {
            get;
            set;
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#region ScalewayProvider#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>The Scaleway secret Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#secret_key ScalewayProvider#secret_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretKey
        {
            get;
            set;
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs#zone ScalewayProvider#zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}
