using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    [JsiiInterface(nativeType: typeof(INginxDeploymentConfig), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentConfig")]
    public interface INginxDeploymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#location NginxDeployment#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#name NginxDeployment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#resource_group_name NginxDeployment#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#sku NginxDeployment#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        string Sku
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#automatic_upgrade_channel NginxDeployment#automatic_upgrade_channel}.</summary>
        [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutomaticUpgradeChannel
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_scale_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#auto_scale_profile NginxDeployment#auto_scale_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "autoScaleProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentAutoScaleProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoScaleProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#capacity NginxDeployment#capacity}.</summary>
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Capacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#email NginxDeployment#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>frontend_private block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#frontend_private NginxDeployment#frontend_private}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentFrontendPrivate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "frontendPrivate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPrivate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FrontendPrivate
        {
            get
            {
                return null;
            }
        }

        /// <summary>frontend_public block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#frontend_public NginxDeployment#frontend_public}
        /// </remarks>
        [JsiiProperty(name: "frontendPublic", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPublic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NginxDeployment.INginxDeploymentFrontendPublic? FrontendPublic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#id NginxDeployment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#identity NginxDeployment#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NginxDeployment.INginxDeploymentIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#network_interface NginxDeployment#network_interface}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#tags NginxDeployment#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#timeouts NginxDeployment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NginxDeployment.INginxDeploymentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_application_firewall block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#web_application_firewall NginxDeployment#web_application_firewall}
        /// </remarks>
        [JsiiProperty(name: "webApplicationFirewall", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewall\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall? WebApplicationFirewall
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INginxDeploymentConfig), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.NginxDeployment.INginxDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#location NginxDeployment#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#name NginxDeployment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#resource_group_name NginxDeployment#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#sku NginxDeployment#sku}.</summary>
            [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
            public string Sku
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#automatic_upgrade_channel NginxDeployment#automatic_upgrade_channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutomaticUpgradeChannel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>auto_scale_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#auto_scale_profile NginxDeployment#auto_scale_profile}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentAutoScaleProfile" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoScaleProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentAutoScaleProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AutoScaleProfile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#capacity NginxDeployment#capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Capacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#email NginxDeployment#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>frontend_private block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#frontend_private NginxDeployment#frontend_private}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentFrontendPrivate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendPrivate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPrivate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FrontendPrivate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>frontend_public block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#frontend_public NginxDeployment#frontend_public}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendPublic", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentFrontendPublic\"}", isOptional: true)]
            public azurerm.NginxDeployment.INginxDeploymentFrontendPublic? FrontendPublic
            {
                get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentFrontendPublic?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#id NginxDeployment#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#identity NginxDeployment#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentIdentity\"}", isOptional: true)]
            public azurerm.NginxDeployment.INginxDeploymentIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentIdentity?>();
            }

            /// <summary>network_interface block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#network_interface NginxDeployment#network_interface}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxDeployment.INginxDeploymentNetworkInterface" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkInterface
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#tags NginxDeployment#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#timeouts NginxDeployment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentTimeouts\"}", isOptional: true)]
            public azurerm.NginxDeployment.INginxDeploymentTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentTimeouts?>();
            }

            /// <summary>web_application_firewall block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/nginx_deployment#web_application_firewall NginxDeployment#web_application_firewall}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webApplicationFirewall", typeJson: "{\"fqn\":\"azurerm.nginxDeployment.NginxDeploymentWebApplicationFirewall\"}", isOptional: true)]
            public azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall? WebApplicationFirewall
            {
                get => GetInstanceProperty<azurerm.NginxDeployment.INginxDeploymentWebApplicationFirewall?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
