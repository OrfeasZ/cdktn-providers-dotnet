using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SAcl
{
    [JsiiInterface(nativeType: typeof(IK8SAclAclRules), fullyQualifiedName: "scaleway.k8SAcl.K8SAclAclRules")]
    public interface IK8SAclAclRules
    {
        /// <summary>The description of the ACL rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#description K8SAcl#description}
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

        /// <summary>The IP subnet to be allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#ip K8SAcl#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow access to cluster from all Scaleway ranges.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#scaleway_ranges K8SAcl#scaleway_ranges}
        /// </remarks>
        [JsiiProperty(name: "scalewayRanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScalewayRanges
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IK8SAclAclRules), fullyQualifiedName: "scaleway.k8SAcl.K8SAclAclRules")]
        internal sealed class _Proxy : DeputyBase, scaleway.K8SAcl.IK8SAclAclRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The description of the ACL rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#description K8SAcl#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IP subnet to be allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#ip K8SAcl#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allow access to cluster from all Scaleway ranges.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_acl#scaleway_ranges K8SAcl#scaleway_ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scalewayRanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ScalewayRanges
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
