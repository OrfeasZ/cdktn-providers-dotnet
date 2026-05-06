using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputReference), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FleetAppsManagementRunbookRunbookVersionTasksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FleetAppsManagementRunbookRunbookVersionTasksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected FleetAppsManagementRunbookRunbookVersionTasksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementRunbookRunbookVersionTasksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOutputVariableMappings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOutputVariableMappings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepProperties\"}}]")]
        public virtual void PutStepProperties(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaskRecordDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails\"}}]")]
        public virtual void PutTaskRecordDetails(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOutputVariableMappings")]
        public virtual void ResetOutputVariableMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepProperties")]
        public virtual void ResetStepProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "outputVariableMappings", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsList\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsList OutputVariableMappings
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappingsList>()!;
        }

        [JsiiProperty(name: "stepProperties", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesOutputReference StepProperties
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "taskRecordDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsOutputReference TaskRecordDetails
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputVariableMappingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksOutputVariableMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutputVariableMappingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepPropertiesInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksStepProperties\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties? StepPropertiesInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksStepProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskRecordDetailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails? TaskRecordDetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetails?>();
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasks\"}]}}", isOptional: true)]
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
                        case oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasks cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasks).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
