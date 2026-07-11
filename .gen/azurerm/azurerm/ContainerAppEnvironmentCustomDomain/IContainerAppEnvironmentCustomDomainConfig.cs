using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironmentCustomDomain
{
    [JsiiInterface(nativeType: typeof(IContainerAppEnvironmentCustomDomainConfig), fullyQualifiedName: "azurerm.containerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainConfig")]
    public interface IContainerAppEnvironmentCustomDomainConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Custom Domain Certificate Private Key as a base64 encoded PFX or PEM.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#certificate_blob_base64 ContainerAppEnvironmentCustomDomain#certificate_blob_base64}
        /// </remarks>
        [JsiiProperty(name: "certificateBlobBase64", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateBlobBase64
        {
            get;
        }

        /// <summary>The Custom Domain Certificate password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#certificate_password ContainerAppEnvironmentCustomDomain#certificate_password}
        /// </remarks>
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}")]
        string CertificatePassword
        {
            get;
        }

        /// <summary>The Container App Managed Environment ID to configure this Custom Domain on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#container_app_environment_id ContainerAppEnvironmentCustomDomain#container_app_environment_id}
        /// </remarks>
        [JsiiProperty(name: "containerAppEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerAppEnvironmentId
        {
            get;
        }

        /// <summary>The Custom Domain DNS suffix for this Container App Environment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#dns_suffix ContainerAppEnvironmentCustomDomain#dns_suffix}
        /// </remarks>
        [JsiiProperty(name: "dnsSuffix", typeJson: "{\"primitive\":\"string\"}")]
        string DnsSuffix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#id ContainerAppEnvironmentCustomDomain#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#timeouts ContainerAppEnvironmentCustomDomain#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerAppEnvironmentCustomDomain.IContainerAppEnvironmentCustomDomainTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppEnvironmentCustomDomainConfig), fullyQualifiedName: "azurerm.containerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppEnvironmentCustomDomain.IContainerAppEnvironmentCustomDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Custom Domain Certificate Private Key as a base64 encoded PFX or PEM.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#certificate_blob_base64 ContainerAppEnvironmentCustomDomain#certificate_blob_base64}
            /// </remarks>
            [JsiiProperty(name: "certificateBlobBase64", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateBlobBase64
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Custom Domain Certificate password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#certificate_password ContainerAppEnvironmentCustomDomain#certificate_password}
            /// </remarks>
            [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificatePassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Container App Managed Environment ID to configure this Custom Domain on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#container_app_environment_id ContainerAppEnvironmentCustomDomain#container_app_environment_id}
            /// </remarks>
            [JsiiProperty(name: "containerAppEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerAppEnvironmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Custom Domain DNS suffix for this Container App Environment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#dns_suffix ContainerAppEnvironmentCustomDomain#dns_suffix}
            /// </remarks>
            [JsiiProperty(name: "dnsSuffix", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsSuffix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#id ContainerAppEnvironmentCustomDomain#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_environment_custom_domain#timeouts ContainerAppEnvironmentCustomDomain#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerAppEnvironmentCustomDomain.ContainerAppEnvironmentCustomDomainTimeouts\"}", isOptional: true)]
            public azurerm.ContainerAppEnvironmentCustomDomain.IContainerAppEnvironmentCustomDomainTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ContainerAppEnvironmentCustomDomain.IContainerAppEnvironmentCustomDomainTimeouts?>();
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
