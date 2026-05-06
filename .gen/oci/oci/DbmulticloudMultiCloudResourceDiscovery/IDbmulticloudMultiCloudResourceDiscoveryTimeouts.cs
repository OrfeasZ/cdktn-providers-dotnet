using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudMultiCloudResourceDiscovery
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudMultiCloudResourceDiscoveryTimeouts), fullyQualifiedName: "oci.dbmulticloudMultiCloudResourceDiscovery.DbmulticloudMultiCloudResourceDiscoveryTimeouts")]
    public interface IDbmulticloudMultiCloudResourceDiscoveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#create DbmulticloudMultiCloudResourceDiscovery#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#delete DbmulticloudMultiCloudResourceDiscovery#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#update DbmulticloudMultiCloudResourceDiscovery#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudMultiCloudResourceDiscoveryTimeouts), fullyQualifiedName: "oci.dbmulticloudMultiCloudResourceDiscovery.DbmulticloudMultiCloudResourceDiscoveryTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudMultiCloudResourceDiscovery.IDbmulticloudMultiCloudResourceDiscoveryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#create DbmulticloudMultiCloudResourceDiscovery#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#delete DbmulticloudMultiCloudResourceDiscovery#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#update DbmulticloudMultiCloudResourceDiscovery#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
