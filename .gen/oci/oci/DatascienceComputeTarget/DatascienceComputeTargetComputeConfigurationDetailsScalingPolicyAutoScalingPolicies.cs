using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies")]
    public class DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies : oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#auto_scaling_policy_type DatascienceComputeTarget#auto_scaling_policy_type}.</summary>
        [JsiiProperty(name: "autoScalingPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoScalingPolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#initial_instance_count DatascienceComputeTarget#initial_instance_count}.</summary>
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double InitialInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#maximum_instance_count DatascienceComputeTarget#maximum_instance_count}.</summary>
        [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#minimum_instance_count DatascienceComputeTarget#minimum_instance_count}.</summary>
        [JsiiProperty(name: "minimumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumInstanceCount
        {
            get;
            set;
        }

        private object _rules;

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datascience_compute_target#rules DatascienceComputeTarget#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"},\"kind\":\"array\"}}]}}")]
        public object Rules
        {
            get => _rules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rules = value;
            }
        }
    }
}
