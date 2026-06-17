using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHubContentReference
{
    [JsiiInterface(nativeType: typeof(ISagemakerHubContentReferenceConfig), fullyQualifiedName: "aws.sagemakerHubContentReference.SagemakerHubContentReferenceConfig")]
    public interface ISagemakerHubContentReferenceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Name of the hub content reference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#hub_content_name SagemakerHubContentReference#hub_content_name}
        /// </remarks>
        [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}")]
        string HubContentName
        {
            get;
        }

        /// <summary>Name of the private SageMaker Hub to add the content reference to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#hub_name SagemakerHubContentReference#hub_name}
        /// </remarks>
        [JsiiProperty(name: "hubName", typeJson: "{\"primitive\":\"string\"}")]
        string HubName
        {
            get;
        }

        /// <summary>ARN of the public SageMaker JumpStart hub content to reference. The ARN must not include a version suffix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#sagemaker_public_hub_content_arn SagemakerHubContentReference#sagemaker_public_hub_content_arn}
        /// </remarks>
        [JsiiProperty(name: "sagemakerPublicHubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        string SagemakerPublicHubContentArn
        {
            get;
        }

        /// <summary>Minimum version of the hub content to reference.</summary>
        /// <remarks>
        /// Use "1.0.0" to support all versions. Changing this value to an empty string forces replacement of the resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#min_version SagemakerHubContentReference#min_version}
        /// </remarks>
        [JsiiProperty(name: "minVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#region SagemakerHubContentReference#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#tags SagemakerHubContentReference#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#timeouts SagemakerHubContentReference#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.sagemakerHubContentReference.SagemakerHubContentReferenceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerHubContentReference.ISagemakerHubContentReferenceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHubContentReferenceConfig), fullyQualifiedName: "aws.sagemakerHubContentReference.SagemakerHubContentReferenceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHubContentReference.ISagemakerHubContentReferenceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the hub content reference.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#hub_content_name SagemakerHubContentReference#hub_content_name}
            /// </remarks>
            [JsiiProperty(name: "hubContentName", typeJson: "{\"primitive\":\"string\"}")]
            public string HubContentName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the private SageMaker Hub to add the content reference to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#hub_name SagemakerHubContentReference#hub_name}
            /// </remarks>
            [JsiiProperty(name: "hubName", typeJson: "{\"primitive\":\"string\"}")]
            public string HubName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the public SageMaker JumpStart hub content to reference. The ARN must not include a version suffix.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#sagemaker_public_hub_content_arn SagemakerHubContentReference#sagemaker_public_hub_content_arn}
            /// </remarks>
            [JsiiProperty(name: "sagemakerPublicHubContentArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SagemakerPublicHubContentArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Minimum version of the hub content to reference.</summary>
            /// <remarks>
            /// Use "1.0.0" to support all versions. Changing this value to an empty string forces replacement of the resource.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#min_version SagemakerHubContentReference#min_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#region SagemakerHubContentReference#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#tags SagemakerHubContentReference#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/sagemaker_hub_content_reference#timeouts SagemakerHubContentReference#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.sagemakerHubContentReference.SagemakerHubContentReferenceTimeouts\"}", isOptional: true)]
            public aws.SagemakerHubContentReference.ISagemakerHubContentReferenceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.SagemakerHubContentReference.ISagemakerHubContentReferenceTimeouts?>();
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
