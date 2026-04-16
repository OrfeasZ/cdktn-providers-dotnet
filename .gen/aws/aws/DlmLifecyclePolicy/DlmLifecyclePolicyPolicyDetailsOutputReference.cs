using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiClass(nativeType: typeof(aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsOutputReference), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DlmLifecyclePolicyPolicyDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DlmLifecyclePolicyPolicyDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DlmLifecyclePolicyPolicyDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DlmLifecyclePolicyPolicyDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsAction\"}}]")]
        public virtual void PutAction(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSource\"}}]")]
        public virtual void PutEventSource(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExclusions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions\"}}]")]
        public virtual void PutExclusions(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParameters\"}}]")]
        public virtual void PutParameters(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsSchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyTags")]
        public virtual void ResetCopyTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateInterval")]
        public virtual void ResetCreateInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventSource")]
        public virtual void ResetEventSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclusions")]
        public virtual void ResetExclusions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendDeletion")]
        public virtual void ResetExtendDeletion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyLanguage")]
        public virtual void ResetPolicyLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyType")]
        public virtual void ResetPolicyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceLocations")]
        public virtual void ResetResourceLocations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypes")]
        public virtual void ResetResourceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetainInterval")]
        public virtual void ResetRetainInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTags")]
        public virtual void ResetTargetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsActionOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsActionOutputReference Action
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsActionOutputReference>()!;
        }

        [JsiiProperty(name: "eventSource", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSourceOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSourceOutputReference EventSource
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSourceOutputReference>()!;
        }

        [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusionsOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusionsOutputReference Exclusions
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusionsOutputReference>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParametersOutputReference\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParametersOutputReference Parameters
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParametersOutputReference>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleList\"}")]
        public virtual aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleList Schedule
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsAction\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction? ActionInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTagsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CopyTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CreateIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventSourceInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSource\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource? EventSourceInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exclusionsInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsExclusions\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions? ExclusionsInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsExclusions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendDeletionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ExtendDeletionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsParameters\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters? ParametersInput
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyLanguageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyLanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLocationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceLocationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetainIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TargetTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object CopyTags
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

        [JsiiProperty(name: "createInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CreateInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extendDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ExtendDeletion
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

        [JsiiProperty(name: "policyLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyLanguage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceLocations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retainInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetainInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TargetTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetails\"}", isOptional: true)]
        public virtual aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetails? InternalValue
        {
            get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
