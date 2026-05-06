using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#policy_type DatascienceModelDeployment#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyType
        {
            get;
        }

        /// <summary>auto_scaling_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#auto_scaling_policies DatascienceModelDeployment#auto_scaling_policies}
        /// </remarks>
        [JsiiProperty(name: "autoScalingPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoScalingPolicies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#cool_down_in_seconds DatascienceModelDeployment#cool_down_in_seconds}.</summary>
        [JsiiProperty(name: "coolDownInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoolDownInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#instance_count DatascienceModelDeployment#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#is_enabled DatascienceModelDeployment#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#policy_type DatascienceModelDeployment#policy_type}.</summary>
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auto_scaling_policies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#auto_scaling_policies DatascienceModelDeployment#auto_scaling_policies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoScalingPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AutoScalingPolicies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#cool_down_in_seconds DatascienceModelDeployment#cool_down_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coolDownInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoolDownInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#instance_count DatascienceModelDeployment#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#is_enabled DatascienceModelDeployment#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
