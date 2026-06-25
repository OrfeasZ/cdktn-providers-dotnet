using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesOutputReference), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules" />)[]</param>
        [JsiiMethod(name: "putRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleInPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy\"}}]")]
        public virtual void PutScaleInPolicy(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleOutPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicy\"}}]")]
        public virtual void PutScaleOutPolicy(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetScaleInPolicy")]
        public virtual void ResetScaleInPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleOutPolicy")]
        public virtual void ResetScaleOutPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesList\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesList Rules
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesList>()!;
        }

        [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference ScaleInPolicy
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "scaleOutPolicy", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicyOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicyOutputReference ScaleOutPolicy
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingPolicyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingPolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInPolicyInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy? ScaleInPolicyInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutPolicyInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicy\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicy? ScaleOutPolicyInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleOutPolicy?>();
        }

        [JsiiProperty(name: "autoScalingPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingPolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPolicies" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPolicies\"}]}}", isOptional: true)]
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
                        case oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPolicies cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPolicies).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
