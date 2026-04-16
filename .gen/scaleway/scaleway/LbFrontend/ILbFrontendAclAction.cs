using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    [JsiiInterface(nativeType: typeof(ILbFrontendAclAction), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAclAction")]
    public interface ILbFrontendAclAction
    {
        /// <summary>The action type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#type LbFrontend#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#redirect LbFrontend#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Redirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbFrontendAclAction), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAclAction")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbFrontend.ILbFrontendAclAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#type LbFrontend#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#redirect LbFrontend#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Redirect
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
