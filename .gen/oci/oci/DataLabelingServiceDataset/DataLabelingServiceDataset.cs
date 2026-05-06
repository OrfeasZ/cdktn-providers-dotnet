using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset oci_data_labeling_service_dataset}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataLabelingServiceDataset.DataLabelingServiceDataset), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDataset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetConfig\"}}]")]
    public class DataLabelingServiceDataset : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset oci_data_labeling_service_dataset} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataLabelingServiceDataset(Constructs.Construct scope, string id, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLabelingServiceDataset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLabelingServiceDataset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataLabelingServiceDataset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataLabelingServiceDataset to import.</param>
        /// <param name="importFromId">The id of the existing DataLabelingServiceDataset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataLabelingServiceDataset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataLabelingServiceDataset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataLabelingServiceDataset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataLabelingServiceDataset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataLabelingServiceDataset.DataLabelingServiceDataset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDatasetFormatDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails\"}}]")]
        public virtual void PutDatasetFormatDetails(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatasetSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetails\"}}]")]
        public virtual void PutDatasetSourceDetails(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitialImportDatasetConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration\"}}]")]
        public virtual void PutInitialImportDatasetConfiguration(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitialRecordGenerationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfiguration\"}}]")]
        public virtual void PutInitialRecordGenerationConfiguration(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLabelSet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSet\"}}]")]
        public virtual void PutLabelSet(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
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

        [JsiiMethod(name: "resetInitialImportDatasetConfiguration")]
        public virtual void ResetInitialImportDatasetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialRecordGenerationConfiguration")]
        public virtual void ResetInitialRecordGenerationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabelingInstructions")]
        public virtual void ResetLabelingInstructions()
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
        = GetStaticProperty<string>(typeof(oci.DataLabelingServiceDataset.DataLabelingServiceDataset))!;

        [JsiiProperty(name: "additionalProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "datasetFormatDetails", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsOutputReference DatasetFormatDetails
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "datasetSourceDetails", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetailsOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetailsOutputReference DatasetSourceDetails
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "initialImportDatasetConfiguration", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference InitialImportDatasetConfiguration
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "initialRecordGenerationConfiguration", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfigurationOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfigurationOutputReference InitialRecordGenerationConfiguration
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "labelSet", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSetOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetLabelSetOutputReference LabelSet
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetLabelSetOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubstate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubstate
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetTimeoutsOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "annotationFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AnnotationFormatInput
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
        [JsiiProperty(name: "datasetFormatDetailsInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails? DatasetFormatDetailsInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetSourceDetailsInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetails\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails? DatasetSourceDetailsInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails?>();
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
        [JsiiProperty(name: "initialImportDatasetConfigurationInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration? InitialImportDatasetConfigurationInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialRecordGenerationConfigurationInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfiguration\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration? InitialRecordGenerationConfigurationInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelingInstructionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LabelingInstructionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelSetInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSet\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet? LabelSetInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "annotationFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnnotationFormat
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

        [JsiiProperty(name: "labelingInstructions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabelingInstructions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
