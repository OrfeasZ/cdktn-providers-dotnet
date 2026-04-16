using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbAcl
{
    [JsiiInterface(nativeType: typeof(ILbAclAction), fullyQualifiedName: "scaleway.lbAcl.LbAclAction")]
    public interface ILbAclAction
    {
        /// <summary>The action type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#type LbAcl#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#redirect LbAcl#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbAcl.LbAclActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbAclAction), fullyQualifiedName: "scaleway.lbAcl.LbAclAction")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbAcl.ILbAclAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#type LbAcl#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#redirect LbAcl#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbAcl.LbAclActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Redirect
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
