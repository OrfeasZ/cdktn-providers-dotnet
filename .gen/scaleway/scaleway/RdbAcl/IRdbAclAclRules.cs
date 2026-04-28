using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbAcl
{
    [JsiiInterface(nativeType: typeof(IRdbAclAclRules), fullyQualifiedName: "scaleway.rdbAcl.RdbAclAclRules")]
    public interface IRdbAclAclRules
    {
        /// <summary>IPv4 address or range in CIDR notation (IPv6 is not supported by the Scaleway API).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_acl#ip RdbAcl#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        string Ip
        {
            get;
        }

        /// <summary>Description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_acl#description RdbAcl#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbAclAclRules), fullyQualifiedName: "scaleway.rdbAcl.RdbAclAclRules")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbAcl.IRdbAclAclRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IPv4 address or range in CIDR notation (IPv6 is not supported by the Scaleway API).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_acl#ip RdbAcl#ip}
            /// </remarks>
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
            public string Ip
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Description of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_acl#description RdbAcl#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
