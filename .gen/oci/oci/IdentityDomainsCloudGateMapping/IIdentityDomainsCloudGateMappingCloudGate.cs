using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsCloudGateMappingCloudGate), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate")]
    public interface IIdentityDomainsCloudGateMappingCloudGate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsCloudGateMappingCloudGate), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
