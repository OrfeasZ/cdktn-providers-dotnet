using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowApplication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application oci_dataflow_application}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataflowApplication.DataflowApplication), fullyQualifiedName: "oci.dataflowApplication.DataflowApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationConfig\"}}]")]
    public class DataflowApplication : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application oci_dataflow_application} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataflowApplication(Constructs.Construct scope, string id, oci.DataflowApplication.IDataflowApplicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataflowApplication.IDataflowApplicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataflowApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataflowApplication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataflowApplication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataflowApplication to import.</param>
        /// <param name="importFromId">The id of the existing DataflowApplication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataflowApplication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataflowApplication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataflowApplication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataflowApplication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataflowApplication.DataflowApplication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApplicationLogConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationApplicationLogConfig\"}}]")]
        public virtual void PutApplicationLogConfig(oci.DataflowApplication.IDataflowApplicationApplicationLogConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowApplication.IDataflowApplicationApplicationLogConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDriverShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationDriverShapeConfig\"}}]")]
        public virtual void PutDriverShapeConfig(oci.DataflowApplication.IDataflowApplicationDriverShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowApplication.IDataflowApplicationDriverShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecutorShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationExecutorShapeConfig\"}}]")]
        public virtual void PutExecutorShapeConfig(oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataflowApplication.IDataflowApplicationParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataflowApplication.IDataflowApplicationParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataflowApplication.IDataflowApplicationParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataflowApplication.IDataflowApplicationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataflowApplication.IDataflowApplicationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationLogConfig")]
        public virtual void ResetApplicationLogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArchiveUri")]
        public virtual void ResetArchiveUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArguments")]
        public virtual void ResetArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClassName")]
        public virtual void ResetClassName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriverShapeConfig")]
        public virtual void ResetDriverShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecute")]
        public virtual void ResetExecute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutorShapeConfig")]
        public virtual void ResetExecutorShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileUri")]
        public virtual void ResetFileUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdleTimeoutInMinutes")]
        public virtual void ResetIdleTimeoutInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogsBucketUri")]
        public virtual void ResetLogsBucketUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxDurationInMinutes")]
        public virtual void ResetMaxDurationInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetastoreId")]
        public virtual void ResetMetastoreId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolId")]
        public virtual void ResetPoolId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateEndpointId")]
        public virtual void ResetPrivateEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateRunsOnDeletion")]
        public virtual void ResetTerminateRunsOnDeletion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarehouseBucketUri")]
        public virtual void ResetWarehouseBucketUri()
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
        = GetStaticProperty<string>(typeof(oci.DataflowApplication.DataflowApplication))!;

        [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationApplicationLogConfigOutputReference\"}")]
        public virtual oci.DataflowApplication.DataflowApplicationApplicationLogConfigOutputReference ApplicationLogConfig
        {
            get => GetInstanceProperty<oci.DataflowApplication.DataflowApplicationApplicationLogConfigOutputReference>()!;
        }

        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationDriverShapeConfigOutputReference\"}")]
        public virtual oci.DataflowApplication.DataflowApplicationDriverShapeConfigOutputReference DriverShapeConfig
        {
            get => GetInstanceProperty<oci.DataflowApplication.DataflowApplicationDriverShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationExecutorShapeConfigOutputReference\"}")]
        public virtual oci.DataflowApplication.DataflowApplicationExecutorShapeConfigOutputReference ExecutorShapeConfig
        {
            get => GetInstanceProperty<oci.DataflowApplication.DataflowApplicationExecutorShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "ownerPrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerPrincipalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationParametersList\"}")]
        public virtual oci.DataflowApplication.DataflowApplicationParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataflowApplication.DataflowApplicationParametersList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationTimeoutsOutputReference\"}")]
        public virtual oci.DataflowApplication.DataflowApplicationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataflowApplication.DataflowApplicationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationLogConfigInput", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationApplicationLogConfig\"}", isOptional: true)]
        public virtual oci.DataflowApplication.IDataflowApplicationApplicationLogConfig? ApplicationLogConfigInput
        {
            get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationApplicationLogConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "archiveUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchiveUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "argumentsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ArgumentsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "classNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClassNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConfigurationInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverShapeConfigInput", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationDriverShapeConfig\"}", isOptional: true)]
        public virtual oci.DataflowApplication.IDataflowApplicationDriverShapeConfig? DriverShapeConfigInput
        {
            get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationDriverShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DriverShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecuteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executorShapeConfigInput", typeJson: "{\"fqn\":\"oci.dataflowApplication.DataflowApplicationExecutorShapeConfig\"}", isOptional: true)]
        public virtual oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig? ExecutorShapeConfigInput
        {
            get => GetInstanceProperty<oci.DataflowApplication.IDataflowApplicationExecutorShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executorShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutorShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleTimeoutInMinutesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdleTimeoutInMinutesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "languageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsBucketUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogsBucketUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDurationInMinutesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxDurationInMinutesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metastoreIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetastoreIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numExecutorsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumExecutorsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowApplication.DataflowApplicationParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparkVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateRunsOnDeletionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminateRunsOnDeletionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataflowApplication.DataflowApplicationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warehouseBucketUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarehouseBucketUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchiveUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Arguments
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClassName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Configuration
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DriverShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Execute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdleTimeoutInMinutes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogsBucketUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxDurationInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxDurationInMinutes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetastoreId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumExecutors
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateRunsOnDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object TerminateRunsOnDeletion
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarehouseBucketUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
