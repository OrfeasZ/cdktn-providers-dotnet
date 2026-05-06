using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement
{
    [JsiiInterface(nativeType: typeof(IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails")]
    public interface IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails
    {
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

        [JsiiTypeProxy(nativeType: typeof(IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstanceOacManagement.ResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ResourceAnalyticsResourceAnalyticsInstanceOacManagement.IResourceAnalyticsResourceAnalyticsInstanceOacManagementAttachmentDetailsNetworkDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
