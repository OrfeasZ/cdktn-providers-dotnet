using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesOutputReference), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInputVariables", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInputVariables(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInputVariables")]
        public virtual void ResetInputVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputVariables")]
        public virtual void ResetOutputVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inputVariables", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariablesList\"}")]
        public virtual oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariablesList InputVariables
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariablesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputVariablesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariablesInputVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InputVariablesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OutputVariablesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "outputVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutputVariables
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariables\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariables? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsExecutionDetailsVariables?>();
            set => SetInstanceProperty(value);
        }
    }
}
