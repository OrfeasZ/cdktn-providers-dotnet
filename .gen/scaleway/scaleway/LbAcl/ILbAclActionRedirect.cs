using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbAcl
{
    [JsiiInterface(nativeType: typeof(ILbAclActionRedirect), fullyQualifiedName: "scaleway.lbAcl.LbAclActionRedirect")]
    public interface ILbAclActionRedirect
    {
        /// <summary>The HTTP redirect code to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#code LbAcl#code}
        /// </remarks>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Code
        {
            get
            {
                return null;
            }
        }

        /// <summary>An URL can be used in case of a location redirect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#target LbAcl#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>The redirect type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#type LbAcl#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbAclActionRedirect), fullyQualifiedName: "scaleway.lbAcl.LbAclActionRedirect")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbAcl.ILbAclActionRedirect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The HTTP redirect code to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#code LbAcl#code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Code
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>An URL can be used in case of a location redirect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#target LbAcl#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The redirect type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_acl#type LbAcl#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
