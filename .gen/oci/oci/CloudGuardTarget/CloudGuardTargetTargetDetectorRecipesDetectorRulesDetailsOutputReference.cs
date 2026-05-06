using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiClass(nativeType: typeof(oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsOutputReference), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConditionGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConditionGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConditionGroups")]
        public virtual void ResetConditionGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "conditionGroups", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroupsList\"}")]
        public virtual oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroupsList ConditionGroups
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroupsList>()!;
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsList\"}")]
        public virtual oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsList Configurations
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConfigurationsList>()!;
        }

        [JsiiProperty(name: "isConfigurationAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsConfigurationAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RiskLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConditionGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails\"}", isOptional: true)]
        public virtual oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
