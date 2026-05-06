using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources oci_fleet_apps_management_scheduler_job_job_activity_resources}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResources), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResources", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesConfig\"}}]")]
    public class DataOciFleetAppsManagementSchedulerJobJobActivityResources : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources oci_fleet_apps_management_scheduler_job_job_activity_resources} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFleetAppsManagementSchedulerJobJobActivityResources(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementSchedulerJobJobActivityResources(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementSchedulerJobJobActivityResources(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFleetAppsManagementSchedulerJobJobActivityResources resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFleetAppsManagementSchedulerJobJobActivityResources to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFleetAppsManagementSchedulerJobJobActivityResources that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFleetAppsManagementSchedulerJobJobActivityResources to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFleetAppsManagementSchedulerJobJobActivityResources to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFleetAppsManagementSchedulerJobJobActivityResources that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFleetAppsManagementSchedulerJobJobActivityResources to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResources), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTaskId")]
        public virtual void ResetResourceTaskId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSequence")]
        public virtual void ResetSequence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepName")]
        public virtual void ResetStepName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetName")]
        public virtual void ResetTargetName()
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
        = GetStaticProperty<string>(typeof(oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResources))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilterList\"}")]
        public virtual oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilterList>()!;
        }

        [JsiiProperty(name: "resourceCollection", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesResourceCollectionList\"}")]
        public virtual oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesResourceCollectionList ResourceCollection
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesResourceCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobActivityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobActivityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTaskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTaskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulerJobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulerJobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sequenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SequenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobActivityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobActivityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTaskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTaskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulerJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulerJobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sequence
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
