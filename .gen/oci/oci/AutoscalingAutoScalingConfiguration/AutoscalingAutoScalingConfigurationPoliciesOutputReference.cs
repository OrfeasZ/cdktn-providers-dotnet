using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AutoscalingAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesOutputReference), fullyQualifiedName: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingAutoScalingConfigurationPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AutoscalingAutoScalingConfigurationPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AutoscalingAutoScalingConfigurationPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingAutoScalingConfigurationPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesCapacity\"}}]")]
        public virtual void PutCapacity(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecutionSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesExecutionSchedule\"}}]")]
        public virtual void PutExecutionSchedule(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesExecutionSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesExecutionSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceAction\"}}]")]
        public virtual void PutResourceAction(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesResourceAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesResourceAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacity")]
        public virtual void ResetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionSchedule")]
        public virtual void ResetExecutionSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEnabled")]
        public virtual void ResetIsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAction")]
        public virtual void ResetResourceAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRules")]
        public virtual void ResetRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesCapacityOutputReference\"}")]
        public virtual oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesCapacityOutputReference Capacity
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesCapacityOutputReference>()!;
        }

        [JsiiProperty(name: "executionSchedule", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesExecutionScheduleOutputReference\"}")]
        public virtual oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesExecutionScheduleOutputReference ExecutionSchedule
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesExecutionScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceAction", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceActionOutputReference\"}")]
        public virtual oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceActionOutputReference ResourceAction
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceActionOutputReference>()!;
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesList\"}")]
        public virtual oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesList Rules
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesCapacity\"}", isOptional: true)]
        public virtual oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesCapacity? CapacityInput
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionScheduleInput", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesExecutionSchedule\"}", isOptional: true)]
        public virtual oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesExecutionSchedule? ExecutionScheduleInput
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesExecutionSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceActionInput", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceAction\"}", isOptional: true)]
        public virtual oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesResourceAction? ResourceActionInput
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesResourceAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPolicies\"}]}}", isOptional: true)]
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
                        case oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPolicies cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPolicies).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
