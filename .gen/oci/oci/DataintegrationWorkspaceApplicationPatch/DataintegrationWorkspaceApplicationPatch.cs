using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationPatch
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch oci_dataintegration_workspace_application_patch}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatch), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatch", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchConfig\"}}]")]
    public class DataintegrationWorkspaceApplicationPatch : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch oci_dataintegration_workspace_application_patch} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataintegrationWorkspaceApplicationPatch(Constructs.Construct scope, string id, oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceApplicationPatch(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceApplicationPatch(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataintegrationWorkspaceApplicationPatch resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataintegrationWorkspaceApplicationPatch to import.</param>
        /// <param name="importFromId">The id of the existing DataintegrationWorkspaceApplicationPatch that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataintegrationWorkspaceApplicationPatch to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataintegrationWorkspaceApplicationPatch to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataintegrationWorkspaceApplicationPatch that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataintegrationWorkspaceApplicationPatch to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatch), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRegistryMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchRegistryMetadata\"}}]")]
        public virtual void PutRegistryMetadata(oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchRegistryMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchRegistryMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentifier")]
        public virtual void ResetIdentifier()
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

        [JsiiMethod(name: "resetObjectKeys")]
        public virtual void ResetObjectKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStatus")]
        public virtual void ResetObjectStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryMetadata")]
        public virtual void ResetRegistryMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatch))!;

        [JsiiProperty(name: "applicationVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dependentObjectMetadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchDependentObjectMetadataList\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchDependentObjectMetadataList DependentObjectMetadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchDependentObjectMetadataList>()!;
        }

        [JsiiProperty(name: "errorMessages", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ErrorMessages
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "keyMap", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap KeyMap
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchMetadataList\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchMetadataList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchParentRefList\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchParentRefList>()!;
        }

        [JsiiProperty(name: "patchObjectMetadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchPatchObjectMetadataList\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchPatchObjectMetadataList PatchObjectMetadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchPatchObjectMetadataList>()!;
        }

        [JsiiProperty(name: "patchStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchRegistryMetadataOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchRegistryMetadataOutputReference RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchRegistryMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchTimeoutsOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timePatched", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePatched
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
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
        [JsiiProperty(name: "objectKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ObjectKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStatusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ObjectStatusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryMetadataInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchRegistryMetadata\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchRegistryMetadata? RegistryMetadataInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchRegistryMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
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

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
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

        [JsiiProperty(name: "objectKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ObjectKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchType
        {
            get => GetInstanceProperty<string>()!;
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
