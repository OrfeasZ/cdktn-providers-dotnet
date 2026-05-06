using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateServer
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsCloudGateServerCloudGate), fullyQualifiedName: "oci.identityDomainsCloudGateServer.IdentityDomainsCloudGateServerCloudGate")]
    public interface IIdentityDomainsCloudGateServerCloudGate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_server#value IdentityDomainsCloudGateServer#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsCloudGateServerCloudGate), fullyQualifiedName: "oci.identityDomainsCloudGateServer.IdentityDomainsCloudGateServerCloudGate")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsCloudGateServer.IIdentityDomainsCloudGateServerCloudGate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_server#value IdentityDomainsCloudGateServer#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
