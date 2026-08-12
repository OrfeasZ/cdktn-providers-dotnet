using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationConfig")]
    public interface IGenerativeAiHostedApplicationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#compartment_id GenerativeAiHostedApplication#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#display_name GenerativeAiHostedApplication#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#defined_tags GenerativeAiHostedApplication#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#description GenerativeAiHostedApplication#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#environment_variables GenerativeAiHostedApplication#environment_variables}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationEnvironmentVariables" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationEnvironmentVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#freeform_tags GenerativeAiHostedApplication#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#id GenerativeAiHostedApplication#id}.</summary>
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

        /// <summary>inbound_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#inbound_auth_config GenerativeAiHostedApplication#inbound_auth_config}
        /// </remarks>
        [JsiiProperty(name: "inboundAuthConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig? InboundAuthConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>networking_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#networking_config GenerativeAiHostedApplication#networking_config}
        /// </remarks>
        [JsiiProperty(name: "networkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig? NetworkingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#scaling_config GenerativeAiHostedApplication#scaling_config}
        /// </remarks>
        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationScalingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationScalingConfig? ScalingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#storage_configs GenerativeAiHostedApplication#storage_configs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationStorageConfigs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationStorageConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageConfigs
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#timeouts GenerativeAiHostedApplication#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationConfig), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#compartment_id GenerativeAiHostedApplication#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#display_name GenerativeAiHostedApplication#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#defined_tags GenerativeAiHostedApplication#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#description GenerativeAiHostedApplication#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>environment_variables block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#environment_variables GenerativeAiHostedApplication#environment_variables}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationEnvironmentVariables" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationEnvironmentVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EnvironmentVariables
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#freeform_tags GenerativeAiHostedApplication#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#id GenerativeAiHostedApplication#id}.</summary>
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

            /// <summary>inbound_auth_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#inbound_auth_config GenerativeAiHostedApplication#inbound_auth_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inboundAuthConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationInboundAuthConfig\"}", isOptional: true)]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig? InboundAuthConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationInboundAuthConfig?>();
            }

            /// <summary>networking_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#networking_config GenerativeAiHostedApplication#networking_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationNetworkingConfig\"}", isOptional: true)]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig? NetworkingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationNetworkingConfig?>();
            }

            /// <summary>scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#scaling_config GenerativeAiHostedApplication#scaling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationScalingConfig\"}", isOptional: true)]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationScalingConfig? ScalingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationScalingConfig?>();
            }

            /// <summary>storage_configs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#storage_configs GenerativeAiHostedApplication#storage_configs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationStorageConfigs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationStorageConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageConfigs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#timeouts GenerativeAiHostedApplication#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplication.GenerativeAiHostedApplicationTimeouts\"}", isOptional: true)]
            public oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationTimeouts?>();
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
