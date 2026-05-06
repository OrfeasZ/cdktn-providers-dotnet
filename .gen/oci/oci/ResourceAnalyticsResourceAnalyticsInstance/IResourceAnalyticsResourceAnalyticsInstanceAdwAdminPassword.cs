using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceAnalyticsResourceAnalyticsInstance
{
    [JsiiInterface(nativeType: typeof(IResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstance.ResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword")]
    public interface IResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#password_type ResourceAnalyticsResourceAnalyticsInstance#password_type}.</summary>
        [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}")]
        string PasswordType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#password ResourceAnalyticsResourceAnalyticsInstance#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#secret_id ResourceAnalyticsResourceAnalyticsInstance#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword), fullyQualifiedName: "oci.resourceAnalyticsResourceAnalyticsInstance.ResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword")]
        internal sealed class _Proxy : DeputyBase, oci.ResourceAnalyticsResourceAnalyticsInstance.IResourceAnalyticsResourceAnalyticsInstanceAdwAdminPassword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#password_type ResourceAnalyticsResourceAnalyticsInstance#password_type}.</summary>
            [JsiiProperty(name: "passwordType", typeJson: "{\"primitive\":\"string\"}")]
            public string PasswordType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#password ResourceAnalyticsResourceAnalyticsInstance#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_resource_analytics_instance#secret_id ResourceAnalyticsResourceAnalyticsInstance#secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
