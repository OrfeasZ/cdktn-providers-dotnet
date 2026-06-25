using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRecommendedPatches
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/fleet_apps_management_recommended_patches oci_fleet_apps_management_recommended_patches}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatches), fullyQualifiedName: "oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatches", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesConfig\"}}]")]
    public class DataOciFleetAppsManagementRecommendedPatches : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/fleet_apps_management_recommended_patches oci_fleet_apps_management_recommended_patches} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFleetAppsManagementRecommendedPatches(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRecommendedPatches(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRecommendedPatches(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFleetAppsManagementRecommendedPatches resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFleetAppsManagementRecommendedPatches to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFleetAppsManagementRecommendedPatches that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFleetAppsManagementRecommendedPatches to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFleetAppsManagementRecommendedPatches to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/data-sources/fleet_apps_management_recommended_patches#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFleetAppsManagementRecommendedPatches that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFleetAppsManagementRecommendedPatches to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatches), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiMethod(name: "resetPatchId")]
        public virtual void ResetPatchId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchLevel")]
        public virtual void ResetPatchLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchType")]
        public virtual void ResetPatchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSeverity")]
        public virtual void ResetSeverity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatches))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilterList\"}")]
        public virtual oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilterList>()!;
        }

        [JsiiProperty(name: "recommendedPatchCollection", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesRecommendedPatchCollectionList\"}")]
        public virtual oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesRecommendedPatchCollectionList RecommendedPatchCollection
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesRecommendedPatchCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciFleetAppsManagementRecommendedPatches.IDataOciFleetAppsManagementRecommendedPatchesFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciFleetAppsManagementRecommendedPatches.DataOciFleetAppsManagementRecommendedPatchesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "patchIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "severityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SeverityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "patchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
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
