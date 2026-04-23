using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceRadiusSettings
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceRadiusSettingsConfig), fullyQualifiedName: "aws.directoryServiceRadiusSettings.DirectoryServiceRadiusSettingsConfig")]
    public interface IDirectoryServiceRadiusSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#authentication_protocol DirectoryServiceRadiusSettings#authentication_protocol}.</summary>
        [JsiiProperty(name: "authenticationProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationProtocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#directory_id DirectoryServiceRadiusSettings#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#display_label DirectoryServiceRadiusSettings#display_label}.</summary>
        [JsiiProperty(name: "displayLabel", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayLabel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_port DirectoryServiceRadiusSettings#radius_port}.</summary>
        [JsiiProperty(name: "radiusPort", typeJson: "{\"primitive\":\"number\"}")]
        double RadiusPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_retries DirectoryServiceRadiusSettings#radius_retries}.</summary>
        [JsiiProperty(name: "radiusRetries", typeJson: "{\"primitive\":\"number\"}")]
        double RadiusRetries
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_servers DirectoryServiceRadiusSettings#radius_servers}.</summary>
        [JsiiProperty(name: "radiusServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RadiusServers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_timeout DirectoryServiceRadiusSettings#radius_timeout}.</summary>
        [JsiiProperty(name: "radiusTimeout", typeJson: "{\"primitive\":\"number\"}")]
        double RadiusTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#shared_secret DirectoryServiceRadiusSettings#shared_secret}.</summary>
        [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}")]
        string SharedSecret
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#id DirectoryServiceRadiusSettings#id}.</summary>
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

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#region DirectoryServiceRadiusSettings#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#timeouts DirectoryServiceRadiusSettings#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directoryServiceRadiusSettings.DirectoryServiceRadiusSettingsTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DirectoryServiceRadiusSettings.IDirectoryServiceRadiusSettingsTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#use_same_username DirectoryServiceRadiusSettings#use_same_username}.</summary>
        [JsiiProperty(name: "useSameUsername", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseSameUsername
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceRadiusSettingsConfig), fullyQualifiedName: "aws.directoryServiceRadiusSettings.DirectoryServiceRadiusSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DirectoryServiceRadiusSettings.IDirectoryServiceRadiusSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#authentication_protocol DirectoryServiceRadiusSettings#authentication_protocol}.</summary>
            [JsiiProperty(name: "authenticationProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#directory_id DirectoryServiceRadiusSettings#directory_id}.</summary>
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#display_label DirectoryServiceRadiusSettings#display_label}.</summary>
            [JsiiProperty(name: "displayLabel", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayLabel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_port DirectoryServiceRadiusSettings#radius_port}.</summary>
            [JsiiProperty(name: "radiusPort", typeJson: "{\"primitive\":\"number\"}")]
            public double RadiusPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_retries DirectoryServiceRadiusSettings#radius_retries}.</summary>
            [JsiiProperty(name: "radiusRetries", typeJson: "{\"primitive\":\"number\"}")]
            public double RadiusRetries
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_servers DirectoryServiceRadiusSettings#radius_servers}.</summary>
            [JsiiProperty(name: "radiusServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RadiusServers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#radius_timeout DirectoryServiceRadiusSettings#radius_timeout}.</summary>
            [JsiiProperty(name: "radiusTimeout", typeJson: "{\"primitive\":\"number\"}")]
            public double RadiusTimeout
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#shared_secret DirectoryServiceRadiusSettings#shared_secret}.</summary>
            [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string SharedSecret
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#id DirectoryServiceRadiusSettings#id}.</summary>
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

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#region DirectoryServiceRadiusSettings#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#timeouts DirectoryServiceRadiusSettings#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directoryServiceRadiusSettings.DirectoryServiceRadiusSettingsTimeouts\"}", isOptional: true)]
            public aws.DirectoryServiceRadiusSettings.IDirectoryServiceRadiusSettingsTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.DirectoryServiceRadiusSettings.IDirectoryServiceRadiusSettingsTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/directory_service_radius_settings#use_same_username DirectoryServiceRadiusSettings#use_same_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useSameUsername", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseSameUsername
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
