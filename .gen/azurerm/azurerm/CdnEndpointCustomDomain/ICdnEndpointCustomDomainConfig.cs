using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpointCustomDomain
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointCustomDomainConfig), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainConfig")]
    public interface ICdnEndpointCustomDomainConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#cdn_endpoint_id CdnEndpointCustomDomain#cdn_endpoint_id}.</summary>
        [JsiiProperty(name: "cdnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string CdnEndpointId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#host_name CdnEndpointCustomDomain#host_name}.</summary>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        string HostName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#name CdnEndpointCustomDomain#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>cdn_managed_https block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#cdn_managed_https CdnEndpointCustomDomain#cdn_managed_https}
        /// </remarks>
        [JsiiProperty(name: "cdnManagedHttps", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps? CdnManagedHttps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#id CdnEndpointCustomDomain#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#timeouts CdnEndpointCustomDomain#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_managed_https block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#user_managed_https CdnEndpointCustomDomain#user_managed_https}
        /// </remarks>
        [JsiiProperty(name: "userManagedHttps", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps? UserManagedHttps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointCustomDomainConfig), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#cdn_endpoint_id CdnEndpointCustomDomain#cdn_endpoint_id}.</summary>
            [JsiiProperty(name: "cdnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string CdnEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#host_name CdnEndpointCustomDomain#host_name}.</summary>
            [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
            public string HostName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#name CdnEndpointCustomDomain#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cdn_managed_https block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#cdn_managed_https CdnEndpointCustomDomain#cdn_managed_https}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cdnManagedHttps", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps\"}", isOptional: true)]
            public azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps? CdnManagedHttps
            {
                get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#id CdnEndpointCustomDomain#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#timeouts CdnEndpointCustomDomain#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainTimeouts\"}", isOptional: true)]
            public azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainTimeouts?>();
            }

            /// <summary>user_managed_https block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_endpoint_custom_domain#user_managed_https CdnEndpointCustomDomain#user_managed_https}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userManagedHttps", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps\"}", isOptional: true)]
            public azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps? UserManagedHttps
            {
                get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps?>();
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
