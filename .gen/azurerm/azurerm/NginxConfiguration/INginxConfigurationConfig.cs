using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxConfiguration
{
    [JsiiInterface(nativeType: typeof(INginxConfigurationConfig), fullyQualifiedName: "azurerm.nginxConfiguration.NginxConfigurationConfig")]
    public interface INginxConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#nginx_deployment_id NginxConfiguration#nginx_deployment_id}.</summary>
        [JsiiProperty(name: "nginxDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
        string NginxDeploymentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#root_file NginxConfiguration#root_file}.</summary>
        [JsiiProperty(name: "rootFile", typeJson: "{\"primitive\":\"string\"}")]
        string RootFile
        {
            get;
        }

        /// <summary>config_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#config_file NginxConfiguration#config_file}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxConfiguration.INginxConfigurationConfigFile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "configFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxConfiguration.NginxConfigurationConfigFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfigFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#id NginxConfiguration#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#package_data NginxConfiguration#package_data}.</summary>
        [JsiiProperty(name: "packageData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PackageData
        {
            get
            {
                return null;
            }
        }

        /// <summary>protected_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#protected_file NginxConfiguration#protected_file}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxConfiguration.INginxConfigurationProtectedFile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "protectedFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxConfiguration.NginxConfigurationProtectedFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProtectedFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#timeouts NginxConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.nginxConfiguration.NginxConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NginxConfiguration.INginxConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INginxConfigurationConfig), fullyQualifiedName: "azurerm.nginxConfiguration.NginxConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.NginxConfiguration.INginxConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#nginx_deployment_id NginxConfiguration#nginx_deployment_id}.</summary>
            [JsiiProperty(name: "nginxDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
            public string NginxDeploymentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#root_file NginxConfiguration#root_file}.</summary>
            [JsiiProperty(name: "rootFile", typeJson: "{\"primitive\":\"string\"}")]
            public string RootFile
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>config_file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#config_file NginxConfiguration#config_file}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxConfiguration.INginxConfigurationConfigFile" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxConfiguration.NginxConfigurationConfigFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConfigFile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#id NginxConfiguration#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#package_data NginxConfiguration#package_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "packageData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PackageData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>protected_file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#protected_file NginxConfiguration#protected_file}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NginxConfiguration.INginxConfigurationProtectedFile" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protectedFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.nginxConfiguration.NginxConfigurationProtectedFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProtectedFile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/nginx_configuration#timeouts NginxConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.nginxConfiguration.NginxConfigurationTimeouts\"}", isOptional: true)]
            public azurerm.NginxConfiguration.INginxConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.NginxConfiguration.INginxConfigurationTimeouts?>();
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
