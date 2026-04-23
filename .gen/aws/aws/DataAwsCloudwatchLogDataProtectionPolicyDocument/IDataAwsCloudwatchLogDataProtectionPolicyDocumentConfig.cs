using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCloudwatchLogDataProtectionPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfig), fullyQualifiedName: "aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfig")]
    public interface IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#name DataAwsCloudwatchLogDataProtectionPolicyDocument#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#statement DataAwsCloudwatchLogDataProtectionPolicyDocument#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatement\"},\"kind\":\"array\"}}]}}")]
        object Statement
        {
            get;
        }

        /// <summary>configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#configuration DataAwsCloudwatchLogDataProtectionPolicyDocument#configuration}
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfiguration? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#description DataAwsCloudwatchLogDataProtectionPolicyDocument#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#id DataAwsCloudwatchLogDataProtectionPolicyDocument#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#version DataAwsCloudwatchLogDataProtectionPolicyDocument#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfig), fullyQualifiedName: "aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#name DataAwsCloudwatchLogDataProtectionPolicyDocument#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#statement DataAwsCloudwatchLogDataProtectionPolicyDocument#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatement\"},\"kind\":\"array\"}}]}}")]
            public object Statement
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#configuration DataAwsCloudwatchLogDataProtectionPolicyDocument#configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentConfiguration\"}", isOptional: true)]
            public aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfiguration? Configuration
            {
                get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#description DataAwsCloudwatchLogDataProtectionPolicyDocument#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#id DataAwsCloudwatchLogDataProtectionPolicyDocument#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#version DataAwsCloudwatchLogDataProtectionPolicyDocument#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
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
