using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsCloudGateMappingTags), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTags")]
    public interface IIdentityDomainsCloudGateMappingTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#key IdentityDomainsCloudGateMapping#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsCloudGateMappingTags), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#key IdentityDomainsCloudGateMapping#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
