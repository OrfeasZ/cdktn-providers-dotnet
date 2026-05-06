using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsCloudGateMappingUpstreamServerGroup), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup")]
    public interface IIdentityDomainsCloudGateMappingUpstreamServerGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#ssl IdentityDomainsCloudGateMapping#ssl}.</summary>
        [JsiiProperty(name: "ssl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ssl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsCloudGateMappingUpstreamServerGroup), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#ssl IdentityDomainsCloudGateMapping#ssl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ssl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ssl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
