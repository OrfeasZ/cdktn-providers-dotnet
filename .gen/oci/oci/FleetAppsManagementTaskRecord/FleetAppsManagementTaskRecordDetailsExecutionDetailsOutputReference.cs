using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsOutputReference), fullyQualifiedName: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementTaskRecordDetailsExecutionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementTaskRecordDetailsExecutionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementTaskRecordDetailsExecutionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementTaskRecordDetailsExecutionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsContent\"}}]")]
        public virtual void PutContent(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVariables", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariables\"}}]")]
        public virtual void PutVariables(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommand")]
        public virtual void ResetCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigFile")]
        public virtual void ResetConfigFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContent")]
        public virtual void ResetContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpoint")]
        public virtual void ResetEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsExecutableContent")]
        public virtual void ResetIsExecutableContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsLocked")]
        public virtual void ResetIsLocked()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsReadOutputVariableEnabled")]
        public virtual void ResetIsReadOutputVariableEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetCompartmentId")]
        public virtual void ResetTargetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariables")]
        public virtual void ResetVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsContentOutputReference\"}")]
        public virtual oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsContentOutputReference Content
        {
            get => GetInstanceProperty<oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsContentOutputReference>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsCredentialsList\"}")]
        public virtual oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsCredentialsList>()!;
        }

        [JsiiProperty(name: "variables", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesOutputReference\"}")]
        public virtual oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesOutputReference Variables
        {
            get => GetInstanceProperty<oci.FleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsContent\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsContent? ContentInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isExecutableContentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsExecutableContentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isLockedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsLockedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isReadOutputVariableEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsReadOutputVariableEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCompartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetCompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variablesInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariables\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables? VariablesInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Command
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isExecutableContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsExecutableContent
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

        [JsiiProperty(name: "isLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsLocked
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

        [JsiiProperty(name: "isReadOutputVariableEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsReadOutputVariableEnabled
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

        [JsiiProperty(name: "targetCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetCompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
