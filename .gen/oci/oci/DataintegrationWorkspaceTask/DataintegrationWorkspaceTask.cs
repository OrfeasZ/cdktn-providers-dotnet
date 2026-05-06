using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task oci_dataintegration_workspace_task}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTask), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTask", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfig\"}}]")]
    public class DataintegrationWorkspaceTask : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task oci_dataintegration_workspace_task} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataintegrationWorkspaceTask(Constructs.Construct scope, string id, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTask(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataintegrationWorkspaceTask resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataintegrationWorkspaceTask to import.</param>
        /// <param name="importFromId">The id of the existing DataintegrationWorkspaceTask that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataintegrationWorkspaceTask to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataintegrationWorkspaceTask to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataintegrationWorkspaceTask that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataintegrationWorkspaceTask to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTask), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfig\"}}]")]
        public virtual void PutAuthConfig(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCancelRestCallConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfig\"}}]")]
        public virtual void PutCancelRestCallConfig(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfigProviderDelegate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegate\"}}]")]
        public virtual void PutConfigProviderDelegate(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecuteRestCallConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfig\"}}]")]
        public virtual void PutExecuteRestCallConfig(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputPorts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPorts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInputPorts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskInputPorts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskInputPorts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskInputPorts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpConfigValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValues\"}}]")]
        public virtual void PutOpConfigValues(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputPorts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPorts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOutputPorts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOutputPorts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOutputPorts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOutputPorts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParentRef", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRef\"}}]")]
        public virtual void PutParentRef(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPollRestCallConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfig\"}}]")]
        public virtual void PutPollRestCallConfig(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegistryMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadata\"}}]")]
        public virtual void PutRegistryMetadata(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTypedExpressions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTypedExpressions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiCallMode")]
        public virtual void ResetApiCallMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthConfig")]
        public virtual void ResetAuthConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCancelRestCallConfig")]
        public virtual void ResetCancelRestCallConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigProviderDelegate")]
        public virtual void ResetConfigProviderDelegate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecuteRestCallConfig")]
        public virtual void ResetExecuteRestCallConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputPorts")]
        public virtual void ResetInputPorts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSingleLoad")]
        public virtual void ResetIsSingleLoad()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKey")]
        public virtual void ResetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelVersion")]
        public virtual void ResetModelVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStatus")]
        public virtual void ResetObjectStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpConfigValues")]
        public virtual void ResetOpConfigValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperation")]
        public virtual void ResetOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputPorts")]
        public virtual void ResetOutputPorts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelLoadLimit")]
        public virtual void ResetParallelLoadLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentRef")]
        public virtual void ResetParentRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPollRestCallConfig")]
        public virtual void ResetPollRestCallConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTypedExpressions")]
        public virtual void ResetTypedExpressions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTask))!;

        [JsiiProperty(name: "authConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfigOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfigOutputReference AuthConfig
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfigOutputReference>()!;
        }

        [JsiiProperty(name: "cancelRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigOutputReference CancelRestCallConfig
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigOutputReference>()!;
        }

        [JsiiProperty(name: "configProviderDelegate", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateOutputReference ConfigProviderDelegate
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateOutputReference>()!;
        }

        [JsiiProperty(name: "executeRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigOutputReference ExecuteRestCallConfig
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigOutputReference>()!;
        }

        [JsiiProperty(name: "inputPorts", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPortsList\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPortsList InputPorts
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPortsList>()!;
        }

        [JsiiProperty(name: "keyMap", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap KeyMap
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskMetadataList\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskMetadataList>()!;
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opConfigValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesOutputReference OpConfigValues
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValuesOutputReference>()!;
        }

        [JsiiProperty(name: "outputPorts", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPortsList\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPortsList OutputPorts
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPortsList>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersList\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersList>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRefOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRefOutputReference ParentRef
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRefOutputReference>()!;
        }

        [JsiiProperty(name: "pollRestCallConfig", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigOutputReference PollRestCallConfig
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigOutputReference>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadataOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadataOutputReference RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeoutsOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "typedExpressions", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsList\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsList TypedExpressions
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiCallModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiCallModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authConfigInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskAuthConfig\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig? AuthConfigInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskAuthConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cancelRestCallConfigInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfig\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig? CancelRestCallConfigInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configProviderDelegateInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegate\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate? ConfigProviderDelegateInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executeRestCallConfigInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfig\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig? ExecuteRestCallConfigInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputPortsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskInputPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InputPortsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSingleLoadInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSingleLoadInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStatusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ObjectStatusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opConfigValuesInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOpConfigValues\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues? OpConfigValuesInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskOpConfigValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputPortsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskOutputPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutputPortsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelLoadLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParallelLoadLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentRefInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParentRef\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef? ParentRefInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParentRef?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pollRestCallConfigInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfig\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig? PollRestCallConfigInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryMetadataInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskRegistryMetadata\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata? RegistryMetadataInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskRegistryMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typedExpressionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TypedExpressionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiCallMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiCallMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isSingleLoad", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSingleLoad
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

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parallelLoadLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParallelLoadLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
