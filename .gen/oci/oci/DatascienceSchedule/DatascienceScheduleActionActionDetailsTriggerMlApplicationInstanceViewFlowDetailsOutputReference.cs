using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiClass(nativeType: typeof(oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerName")]
        public virtual void ResetTriggerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParametersList\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParametersList Parameters
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParametersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TriggerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TriggerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
