using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudMultiCloudResourceDiscovery
{
    [JsiiByValue(fqn: "oci.dbmulticloudMultiCloudResourceDiscovery.DbmulticloudMultiCloudResourceDiscoveryTimeouts")]
    public class DbmulticloudMultiCloudResourceDiscoveryTimeouts : oci.DbmulticloudMultiCloudResourceDiscovery.IDbmulticloudMultiCloudResourceDiscoveryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#create DbmulticloudMultiCloudResourceDiscovery#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#delete DbmulticloudMultiCloudResourceDiscovery#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_multi_cloud_resource_discovery#update DbmulticloudMultiCloudResourceDiscovery#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
