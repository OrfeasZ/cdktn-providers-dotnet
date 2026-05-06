using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScaleInConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}}]")]
        public virtual void PutScaleInConfiguration(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleOutConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}}]")]
        public virtual void PutScaleOutConfiguration(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetricType")]
        public virtual void ResetMetricType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scaleInConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationOutputReference ScaleInConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scaleOutConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationOutputReference ScaleOutConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfigurationOutputReference>()!;
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
        [JsiiProperty(name: "scaleInConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration? ScaleInConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleInConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration? ScaleOutConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"}]}}", isOptional: true)]
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
                        case oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyAutoScalingPoliciesRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
