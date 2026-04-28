using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    [JsiiInterface(nativeType: typeof(ILbFrontendAcl), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAcl")]
    public interface ILbFrontendAcl
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#action LbFrontend#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclAction\"}")]
        scaleway.LbFrontend.ILbFrontendAclAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#match LbFrontend#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclMatch\"}")]
        scaleway.LbFrontend.ILbFrontendAclMatch Match
        {
            get;
        }

        /// <summary>Description of the ACL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#description LbFrontend#description}
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

        /// <summary>The ACL name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#name LbFrontend#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbFrontendAcl), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAcl")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbFrontend.ILbFrontendAcl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#action LbFrontend#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclAction\"}")]
            public scaleway.LbFrontend.ILbFrontendAclAction Action
            {
                get => GetInstanceProperty<scaleway.LbFrontend.ILbFrontendAclAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#match LbFrontend#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclMatch\"}")]
            public scaleway.LbFrontend.ILbFrontendAclMatch Match
            {
                get => GetInstanceProperty<scaleway.LbFrontend.ILbFrontendAclMatch>()!;
            }

            /// <summary>Description of the ACL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#description LbFrontend#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ACL name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#name LbFrontend#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
