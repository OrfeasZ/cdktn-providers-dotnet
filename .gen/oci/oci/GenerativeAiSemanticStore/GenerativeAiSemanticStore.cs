using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_semantic_store oci_generative_ai_semantic_store}.</summary>
    [JsiiClass(nativeType: typeof(oci.GenerativeAiSemanticStore.GenerativeAiSemanticStore), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStore", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreConfig\"}}]")]
    public class GenerativeAiSemanticStore : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_semantic_store oci_generative_ai_semantic_store} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GenerativeAiSemanticStore(Constructs.Construct scope, string id, oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiSemanticStore(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiSemanticStore(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a GenerativeAiSemanticStore resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GenerativeAiSemanticStore to import.</param>
        /// <param name="importFromId">The id of the existing GenerativeAiSemanticStore that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GenerativeAiSemanticStore to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GenerativeAiSemanticStore to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_semantic_store#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GenerativeAiSemanticStore that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GenerativeAiSemanticStore to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.GenerativeAiSemanticStore.GenerativeAiSemanticStore), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSource\"}}]")]
        public virtual void PutDataSource(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRefreshSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreRefreshSchedule\"}}]")]
        public virtual void PutRefreshSchedule(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreRefreshSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreRefreshSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemas", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemas\"}}]")]
        public virtual void PutSchemas(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetRefreshSchedule")]
        public virtual void ResetRefreshSchedule()
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
        = GetStaticProperty<string>(typeof(oci.GenerativeAiSemanticStore.GenerativeAiSemanticStore))!;

        [JsiiProperty(name: "dataSource", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSourceOutputReference\"}")]
        public virtual oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreDataSourceOutputReference DataSource
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreDataSourceOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshSchedule", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreRefreshScheduleOutputReference\"}")]
        public virtual oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreRefreshScheduleOutputReference RefreshSchedule
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreRefreshScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasOutputReference\"}")]
        public virtual oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreSchemasOutputReference Schemas
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreSchemasOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreTimeoutsOutputReference\"}")]
        public virtual oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceInput", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreDataSource\"}", isOptional: true)]
        public virtual oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource? DataSourceInput
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreDataSource?>();
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
        [JsiiProperty(name: "refreshScheduleInput", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreRefreshSchedule\"}", isOptional: true)]
        public virtual oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreRefreshSchedule? RefreshScheduleInput
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreRefreshSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemas\"}", isOptional: true)]
        public virtual oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas? SchemasInput
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
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
    }
}
