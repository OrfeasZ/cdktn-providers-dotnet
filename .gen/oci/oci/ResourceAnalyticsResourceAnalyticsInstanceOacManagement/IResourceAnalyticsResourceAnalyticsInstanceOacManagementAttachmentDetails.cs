using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement
{
    [JsiiInterface(nativeType: typeof(IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails")]
    public interface IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#idcs_domain_id ResourceAnalyticsResourceAnalyticsInstanceOacManagement#idcs_domain_id}.</summary>
        [JsiiProperty(name: "idcsDomainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdcsDomainId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#license_model ResourceAnalyticsResourceAnalyticsInstanceOacManagement#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#network_details ResourceAnalyticsResourceAnalyticsInstanceOacManagement#network_details}
        /// </remarks>
        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails? NetworkDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#nsg_ids ResourceAnalyticsResourceAnalyticsInstanceOacManagement#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NsgIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#subnet_id ResourceAnalyticsResourceAnalyticsInstanceOacManagement#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#idcs_domain_id ResourceAnalyticsResourceAnalyticsInstanceOacManagement#idcs_domain_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idcsDomainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdcsDomainId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#license_model ResourceAnalyticsResourceAnalyticsInstanceOacManagement#license_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#network_details ResourceAnalyticsResourceAnalyticsInstanceOacManagement#network_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails\"}", isOptional: true)]
            public oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails? NetworkDetails
            {
                get => GetInstanceProperty<oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#nsg_ids ResourceAnalyticsResourceAnalyticsInstanceOacManagement#nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance_oac_management#subnet_id ResourceAnalyticsResourceAnalyticsInstanceOacManagement#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
