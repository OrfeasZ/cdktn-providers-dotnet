using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionOutputReference), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementRunbookRunbookVersionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementRunbookRunbookVersionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementRunbookRunbookVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementRunbookRunbookVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExecutionWorkflowDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails\"}}]")]
        public virtual void PutExecutionWorkflowDetails(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollbackWorkflowDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails\"}}]")]
        public virtual void PutRollbackWorkflowDetails(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTasks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTasks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIsLatest")]
        public virtual void ResetIsLatest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollbackWorkflowDetails")]
        public virtual void ResetRollbackWorkflowDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "executionWorkflowDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsOutputReference ExecutionWorkflowDetails
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "groups", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroupsList\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroupsList Groups
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroupsList>()!;
        }

        [JsiiProperty(name: "rollbackWorkflowDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsOutputReference RollbackWorkflowDetails
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "tasks", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksList\"}")]
        public virtual oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksList Tasks
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionWorkflowDetailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails? ExecutionWorkflowDetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionExecutionWorkflowDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isLatestInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsLatestInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollbackWorkflowDetailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails? RollbackWorkflowDetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionRollbackWorkflowDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tasksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TasksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "isLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsLatest
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersion\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersion? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
