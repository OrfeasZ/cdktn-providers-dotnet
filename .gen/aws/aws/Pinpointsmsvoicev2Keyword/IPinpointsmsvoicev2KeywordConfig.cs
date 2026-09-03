using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpointsmsvoicev2Keyword
{
    [JsiiInterface(nativeType: typeof(IPinpointsmsvoicev2KeywordConfig), fullyQualifiedName: "aws.pinpointsmsvoicev2Keyword.Pinpointsmsvoicev2KeywordConfig")]
    public interface IPinpointsmsvoicev2KeywordConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Keyword to configure. 1-30 characters, upper-case, and cannot start or end with a space.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#keyword Pinpointsmsvoicev2Keyword#keyword}
        /// </remarks>
        [JsiiProperty(name: "keyword", typeJson: "{\"primitive\":\"string\"}")]
        string Keyword
        {
            get;
        }

        /// <summary>Message to send when the keyword is received.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#keyword_message Pinpointsmsvoicev2Keyword#keyword_message}
        /// </remarks>
        [JsiiProperty(name: "keywordMessage", typeJson: "{\"primitive\":\"string\"}")]
        string KeywordMessage
        {
            get;
        }

        /// <summary>ARN of the origination identity (phone number or pool) to attach the keyword to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#origination_identity_arn Pinpointsmsvoicev2Keyword#origination_identity_arn}
        /// </remarks>
        [JsiiProperty(name: "originationIdentityArn", typeJson: "{\"primitive\":\"string\"}")]
        string OriginationIdentityArn
        {
            get;
        }

        /// <summary>Action to perform when the keyword is received.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#keyword_action Pinpointsmsvoicev2Keyword#keyword_action}
        /// </remarks>
        [JsiiProperty(name: "keywordAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeywordAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#region Pinpointsmsvoicev2Keyword#region}
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

        [JsiiTypeProxy(nativeType: typeof(IPinpointsmsvoicev2KeywordConfig), fullyQualifiedName: "aws.pinpointsmsvoicev2Keyword.Pinpointsmsvoicev2KeywordConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpointsmsvoicev2Keyword.IPinpointsmsvoicev2KeywordConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Keyword to configure. 1-30 characters, upper-case, and cannot start or end with a space.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#keyword Pinpointsmsvoicev2Keyword#keyword}
            /// </remarks>
            [JsiiProperty(name: "keyword", typeJson: "{\"primitive\":\"string\"}")]
            public string Keyword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Message to send when the keyword is received.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#keyword_message Pinpointsmsvoicev2Keyword#keyword_message}
            /// </remarks>
            [JsiiProperty(name: "keywordMessage", typeJson: "{\"primitive\":\"string\"}")]
            public string KeywordMessage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the origination identity (phone number or pool) to attach the keyword to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#origination_identity_arn Pinpointsmsvoicev2Keyword#origination_identity_arn}
            /// </remarks>
            [JsiiProperty(name: "originationIdentityArn", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginationIdentityArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Action to perform when the keyword is received.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#keyword_action Pinpointsmsvoicev2Keyword#keyword_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keywordAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeywordAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/pinpointsmsvoicev2_keyword#region Pinpointsmsvoicev2Keyword#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
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
