using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorizationConnection
{
    [JsiiInterface(nativeType: typeof(IAppfabricAppAuthorizationConnectionConfig), fullyQualifiedName: "aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionConfig")]
    public interface IAppfabricAppAuthorizationConnectionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#app_authorization_arn AppfabricAppAuthorizationConnection#app_authorization_arn}.</summary>
        [JsiiProperty(name: "appAuthorizationArn", typeJson: "{\"primitive\":\"string\"}")]
        string AppAuthorizationArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#app_bundle_arn AppfabricAppAuthorizationConnection#app_bundle_arn}.</summary>
        [JsiiProperty(name: "appBundleArn", typeJson: "{\"primitive\":\"string\"}")]
        string AppBundleArn
        {
            get;
        }

        /// <summary>auth_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#auth_request AppfabricAppAuthorizationConnection#auth_request}
        /// </remarks>
        [JsiiProperty(name: "authRequest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#region AppfabricAppAuthorizationConnection#region}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#timeouts AppfabricAppAuthorizationConnection#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricAppAuthorizationConnectionConfig), fullyQualifiedName: "aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#app_authorization_arn AppfabricAppAuthorizationConnection#app_authorization_arn}.</summary>
            [JsiiProperty(name: "appAuthorizationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AppAuthorizationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#app_bundle_arn AppfabricAppAuthorizationConnection#app_bundle_arn}.</summary>
            [JsiiProperty(name: "appBundleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AppBundleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auth_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#auth_request AppfabricAppAuthorizationConnection#auth_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authRequest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthRequest
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#region AppfabricAppAuthorizationConnection#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appfabric_app_authorization_connection#timeouts AppfabricAppAuthorizationConnection#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeouts\"}", isOptional: true)]
            public aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionTimeouts?>();
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
