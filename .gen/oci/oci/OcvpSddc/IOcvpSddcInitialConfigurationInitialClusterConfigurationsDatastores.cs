using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiInterface(nativeType: typeof(IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores")]
    public interface IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#block_volume_ids OcvpSddc#block_volume_ids}.</summary>
        [JsiiProperty(name: "blockVolumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] BlockVolumeIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#datastore_type OcvpSddc#datastore_type}.</summary>
        [JsiiProperty(name: "datastoreType", typeJson: "{\"primitive\":\"string\"}")]
        string DatastoreType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#block_volume_ids OcvpSddc#block_volume_ids}.</summary>
            [JsiiProperty(name: "blockVolumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] BlockVolumeIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#datastore_type OcvpSddc#datastore_type}.</summary>
            [JsiiProperty(name: "datastoreType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatastoreType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
