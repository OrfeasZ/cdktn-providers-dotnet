using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteAcl
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteAclConfig), fullyQualifiedName: "cloudflare.magicTransitSiteAcl.MagicTransitSiteAclConfig")]
    public interface IMagicTransitSiteAclConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#account_id MagicTransitSiteAcl#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#lan_1 MagicTransitSiteAcl#lan_1}.</summary>
        [JsiiProperty(name: "lan1", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteAcl.MagicTransitSiteAclLan1\"}")]
        cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan1 Lan1
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#lan_2 MagicTransitSiteAcl#lan_2}.</summary>
        [JsiiProperty(name: "lan2", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteAcl.MagicTransitSiteAclLan2\"}")]
        cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan2 Lan2
        {
            get;
        }

        /// <summary>The name of the ACL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#name MagicTransitSiteAcl#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#site_id MagicTransitSiteAcl#site_id}
        /// </remarks>
        [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}")]
        string SiteId
        {
            get;
        }

        /// <summary>Description for the ACL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#description MagicTransitSiteAcl#description}
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

        /// <summary>The desired forwarding action for this ACL policy.</summary>
        /// <remarks>
        /// If set to "false", the policy will forward traffic to Cloudflare. If set to "true", the policy will forward traffic locally on the Magic Connector. If not included in request, will default to false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#forward_locally MagicTransitSiteAcl#forward_locally}
        /// </remarks>
        [JsiiProperty(name: "forwardLocally", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForwardLocally
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#protocols MagicTransitSiteAcl#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>The desired traffic direction for this ACL policy.</summary>
        /// <remarks>
        /// If set to "false", the policy will allow bidirectional traffic. If set to "true", the policy will only allow traffic in one direction. If not included in request, will default to false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#unidirectional MagicTransitSiteAcl#unidirectional}
        /// </remarks>
        [JsiiProperty(name: "unidirectional", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Unidirectional
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteAclConfig), fullyQualifiedName: "cloudflare.magicTransitSiteAcl.MagicTransitSiteAclConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#account_id MagicTransitSiteAcl#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#lan_1 MagicTransitSiteAcl#lan_1}.</summary>
            [JsiiProperty(name: "lan1", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteAcl.MagicTransitSiteAclLan1\"}")]
            public cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan1 Lan1
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan1>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#lan_2 MagicTransitSiteAcl#lan_2}.</summary>
            [JsiiProperty(name: "lan2", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteAcl.MagicTransitSiteAclLan2\"}")]
            public cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan2 Lan2
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteAcl.IMagicTransitSiteAclLan2>()!;
            }

            /// <summary>The name of the ACL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#name MagicTransitSiteAcl#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#site_id MagicTransitSiteAcl#site_id}
            /// </remarks>
            [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}")]
            public string SiteId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Description for the ACL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#description MagicTransitSiteAcl#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The desired forwarding action for this ACL policy.</summary>
            /// <remarks>
            /// If set to "false", the policy will forward traffic to Cloudflare. If set to "true", the policy will forward traffic locally on the Magic Connector. If not included in request, will default to false.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#forward_locally MagicTransitSiteAcl#forward_locally}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardLocally", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForwardLocally
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#protocols MagicTransitSiteAcl#protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Protocols
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The desired traffic direction for this ACL policy.</summary>
            /// <remarks>
            /// If set to "false", the policy will allow bidirectional traffic. If set to "true", the policy will only allow traffic in one direction. If not included in request, will default to false.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_acl#unidirectional MagicTransitSiteAcl#unidirectional}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unidirectional", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Unidirectional
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
