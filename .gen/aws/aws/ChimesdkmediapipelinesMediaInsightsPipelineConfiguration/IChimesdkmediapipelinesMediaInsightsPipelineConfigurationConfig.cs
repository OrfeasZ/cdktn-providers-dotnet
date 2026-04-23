using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration
{
    [JsiiInterface(nativeType: typeof(IChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig), fullyQualifiedName: "aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig")]
    public interface IChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>elements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#elements ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#elements}
        /// </remarks>
        [JsiiProperty(name: "elements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElements\"},\"kind\":\"array\"}}]}}")]
        object Elements
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#name ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#resource_access_role_arn ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#resource_access_role_arn}.</summary>
        [JsiiProperty(name: "resourceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceAccessRoleArn
        {
            get;
        }

        /// <summary>real_time_alert_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#real_time_alert_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#real_time_alert_configuration}
        /// </remarks>
        [JsiiProperty(name: "realTimeAlertConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfiguration? RealTimeAlertConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#region ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#tags ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#tags_all ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#timeouts ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig), fullyQualifiedName: "aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>elements block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#elements ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#elements}
            /// </remarks>
            [JsiiProperty(name: "elements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationElements\"},\"kind\":\"array\"}}]}}")]
            public object Elements
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#name ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#resource_access_role_arn ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#resource_access_role_arn}.</summary>
            [JsiiProperty(name: "resourceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceAccessRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>real_time_alert_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#real_time_alert_configuration ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#real_time_alert_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "realTimeAlertConfiguration", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfiguration\"}", isOptional: true)]
            public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfiguration? RealTimeAlertConfiguration
            {
                get => GetInstanceProperty<aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfiguration?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#region ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#tags ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#tags_all ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chimesdkmediapipelines_media_insights_pipeline_configuration#timeouts ChimesdkmediapipelinesMediaInsightsPipelineConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.chimesdkmediapipelinesMediaInsightsPipelineConfiguration.ChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeouts\"}", isOptional: true)]
            public aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.ChimesdkmediapipelinesMediaInsightsPipelineConfiguration.IChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeouts?>();
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
