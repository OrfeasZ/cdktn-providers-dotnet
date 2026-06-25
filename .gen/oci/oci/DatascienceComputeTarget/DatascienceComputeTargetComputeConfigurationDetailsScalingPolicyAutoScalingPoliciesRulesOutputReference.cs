using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiClass(nativeType: typeof(oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScaleInConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}}]")]
        public virtual void PutScaleInConfiguration(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleOutConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}}]")]
        public virtual void PutScaleOutConfiguration(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetricType")]
        public virtual void ResetMetricType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scaleInConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationOutputReference\"}")]
        public virtual oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationOutputReference ScaleInConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scaleOutConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationOutputReference\"}")]
        public virtual oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationOutputReference ScaleOutConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricExpressionRuleTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricExpressionRuleTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration? ScaleInConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration? ScaleOutConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration?>();
        }

        [JsiiProperty(name: "metricExpressionRuleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricExpressionRuleType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
