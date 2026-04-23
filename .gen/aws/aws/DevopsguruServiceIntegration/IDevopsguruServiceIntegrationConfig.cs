using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruServiceIntegration
{
    [JsiiInterface(nativeType: typeof(IDevopsguruServiceIntegrationConfig), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationConfig")]
    public interface IDevopsguruServiceIntegrationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>kms_server_side_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#kms_server_side_encryption DevopsguruServiceIntegration#kms_server_side_encryption}
        /// </remarks>
        [JsiiProperty(name: "kmsServerSideEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KmsServerSideEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs_anomaly_detection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#logs_anomaly_detection DevopsguruServiceIntegration#logs_anomaly_detection}
        /// </remarks>
        [JsiiProperty(name: "logsAnomalyDetection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogsAnomalyDetection
        {
            get
            {
                return null;
            }
        }

        /// <summary>ops_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#ops_center DevopsguruServiceIntegration#ops_center}
        /// </remarks>
        [JsiiProperty(name: "opsCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpsCenter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#region DevopsguruServiceIntegration#region}
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

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruServiceIntegrationConfig), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kms_server_side_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#kms_server_side_encryption DevopsguruServiceIntegration#kms_server_side_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmsServerSideEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KmsServerSideEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>logs_anomaly_detection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#logs_anomaly_detection DevopsguruServiceIntegration#logs_anomaly_detection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logsAnomalyDetection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogsAnomalyDetection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ops_center block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#ops_center DevopsguruServiceIntegration#ops_center}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opsCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpsCenter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/devopsguru_service_integration#region DevopsguruServiceIntegration#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
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
