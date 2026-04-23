using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingPolicy
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingPolicyConfig), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyConfig")]
    public interface IAppautoscalingPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#name AppautoscalingPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#resource_id AppautoscalingPolicy#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#scalable_dimension AppautoscalingPolicy#scalable_dimension}.</summary>
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        string ScalableDimension
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#service_namespace AppautoscalingPolicy#service_namespace}.</summary>
        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#id AppautoscalingPolicy#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#policy_type AppautoscalingPolicy#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>predictive_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predictive_scaling_policy_configuration AppautoscalingPolicy#predictive_scaling_policy_configuration}
        /// </remarks>
        [JsiiProperty(name: "predictiveScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#region AppautoscalingPolicy#region}
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

        /// <summary>step_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#step_scaling_policy_configuration AppautoscalingPolicy#step_scaling_policy_configuration}
        /// </remarks>
        [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyStepScalingPolicyConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyStepScalingPolicyConfiguration? StepScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_tracking_scaling_policy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#target_tracking_scaling_policy_configuration AppautoscalingPolicy#target_tracking_scaling_policy_configuration}
        /// </remarks>
        [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppautoscalingPolicy.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingPolicyConfig), fullyQualifiedName: "aws.appautoscalingPolicy.AppautoscalingPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppautoscalingPolicy.IAppautoscalingPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#name AppautoscalingPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#resource_id AppautoscalingPolicy#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#scalable_dimension AppautoscalingPolicy#scalable_dimension}.</summary>
            [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
            public string ScalableDimension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#service_namespace AppautoscalingPolicy#service_namespace}.</summary>
            [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#id AppautoscalingPolicy#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#policy_type AppautoscalingPolicy#policy_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>predictive_scaling_policy_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#predictive_scaling_policy_configuration AppautoscalingPolicy#predictive_scaling_policy_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predictiveScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyPredictiveScalingPolicyConfiguration\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyPredictiveScalingPolicyConfiguration?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#region AppautoscalingPolicy#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>step_scaling_policy_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#step_scaling_policy_configuration AppautoscalingPolicy#step_scaling_policy_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyStepScalingPolicyConfiguration\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyStepScalingPolicyConfiguration? StepScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyStepScalingPolicyConfiguration?>();
            }

            /// <summary>target_tracking_scaling_policy_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appautoscaling_policy#target_tracking_scaling_policy_configuration AppautoscalingPolicy#target_tracking_scaling_policy_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetTrackingScalingPolicyConfiguration", typeJson: "{\"fqn\":\"aws.appautoscalingPolicy.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration\"}", isOptional: true)]
            public aws.AppautoscalingPolicy.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration
            {
                get => GetInstanceProperty<aws.AppautoscalingPolicy.IAppautoscalingPolicyTargetTrackingScalingPolicyConfiguration?>();
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
