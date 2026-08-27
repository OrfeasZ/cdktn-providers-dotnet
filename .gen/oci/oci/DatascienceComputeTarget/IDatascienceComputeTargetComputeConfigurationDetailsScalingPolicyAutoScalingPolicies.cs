using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiInterface(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies")]
    public interface IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#auto_scaling_policy_type DatascienceComputeTarget#auto_scaling_policy_type}.</summary>
        [JsiiProperty(name: "autoScalingPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        string AutoScalingPolicyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#initial_instance_count DatascienceComputeTarget#initial_instance_count}.</summary>
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InitialInstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#maximum_instance_count DatascienceComputeTarget#maximum_instance_count}.</summary>
        [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumInstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#minimum_instance_count DatascienceComputeTarget#minimum_instance_count}.</summary>
        [JsiiProperty(name: "minimumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumInstanceCount
        {
            get;
        }

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#rules DatascienceComputeTarget#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"},\"kind\":\"array\"}}]}}")]
        object Rules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#auto_scaling_policy_type DatascienceComputeTarget#auto_scaling_policy_type}.</summary>
            [JsiiProperty(name: "autoScalingPolicyType", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoScalingPolicyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#initial_instance_count DatascienceComputeTarget#initial_instance_count}.</summary>
            [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InitialInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#maximum_instance_count DatascienceComputeTarget#maximum_instance_count}.</summary>
            [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#minimum_instance_count DatascienceComputeTarget#minimum_instance_count}.</summary>
            [JsiiProperty(name: "minimumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_compute_target#rules DatascienceComputeTarget#rules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"},\"kind\":\"array\"}}]}}")]
            public object Rules
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
