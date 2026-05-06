using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceAnalyticsResourceAnalyticsInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.resourceAnalyticsResourceAnalyticsInstance.ResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword")]
    public class ResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword : oci.ResourceAnalyticsResourceAnalyticsInstance.IResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#password_type ResourceAnalyticsResourceAnalyticsInstance#password_type}.</summary>
        [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#password ResourceAnalyticsResourceAnalyticsInstance#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#secret_id ResourceAnalyticsResourceAnalyticsInstance#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }
    }
}
