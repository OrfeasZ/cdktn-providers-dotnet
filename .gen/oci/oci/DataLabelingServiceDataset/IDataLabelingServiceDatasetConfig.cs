using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiInterface(nativeType: typeof(IDataLabelingServiceDatasetConfig), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetConfig")]
    public interface IDataLabelingServiceDatasetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#annotation_format DataLabelingServiceDataset#annotation_format}.</summary>
        [JsiiProperty(name: "annotationFormat", typeJson: "{\"primitive\":\"string\"}")]
        string AnnotationFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#compartment_id DataLabelingServiceDataset#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>dataset_format_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#dataset_format_details DataLabelingServiceDataset#dataset_format_details}
        /// </remarks>
        [JsiiProperty(name: "datasetFormatDetails", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails\"}")]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails DatasetFormatDetails
        {
            get;
        }

        /// <summary>dataset_source_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#dataset_source_details DataLabelingServiceDataset#dataset_source_details}
        /// </remarks>
        [JsiiProperty(name: "datasetSourceDetails", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetails\"}")]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails DatasetSourceDetails
        {
            get;
        }

        /// <summary>label_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#label_set DataLabelingServiceDataset#label_set}
        /// </remarks>
        [JsiiProperty(name: "labelSet", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSet\"}")]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet LabelSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#defined_tags DataLabelingServiceDataset#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#description DataLabelingServiceDataset#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#display_name DataLabelingServiceDataset#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#freeform_tags DataLabelingServiceDataset#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#id DataLabelingServiceDataset#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>initial_import_dataset_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#initial_import_dataset_configuration DataLabelingServiceDataset#initial_import_dataset_configuration}
        /// </remarks>
        [JsiiProperty(name: "initialImportDatasetConfiguration", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration? InitialImportDatasetConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>initial_record_generation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#initial_record_generation_configuration DataLabelingServiceDataset#initial_record_generation_configuration}
        /// </remarks>
        [JsiiProperty(name: "initialRecordGenerationConfiguration", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration? InitialRecordGenerationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#labeling_instructions DataLabelingServiceDataset#labeling_instructions}.</summary>
        [JsiiProperty(name: "labelingInstructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LabelingInstructions
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#timeouts DataLabelingServiceDataset#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLabelingServiceDatasetConfig), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#annotation_format DataLabelingServiceDataset#annotation_format}.</summary>
            [JsiiProperty(name: "annotationFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string AnnotationFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#compartment_id DataLabelingServiceDataset#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dataset_format_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#dataset_format_details DataLabelingServiceDataset#dataset_format_details}
            /// </remarks>
            [JsiiProperty(name: "datasetFormatDetails", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails\"}")]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails DatasetFormatDetails
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails>()!;
            }

            /// <summary>dataset_source_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#dataset_source_details DataLabelingServiceDataset#dataset_source_details}
            /// </remarks>
            [JsiiProperty(name: "datasetSourceDetails", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetSourceDetails\"}")]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails DatasetSourceDetails
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetSourceDetails>()!;
            }

            /// <summary>label_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#label_set DataLabelingServiceDataset#label_set}
            /// </remarks>
            [JsiiProperty(name: "labelSet", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSet\"}")]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet LabelSet
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#defined_tags DataLabelingServiceDataset#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#description DataLabelingServiceDataset#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#display_name DataLabelingServiceDataset#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#freeform_tags DataLabelingServiceDataset#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#id DataLabelingServiceDataset#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>initial_import_dataset_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#initial_import_dataset_configuration DataLabelingServiceDataset#initial_import_dataset_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initialImportDatasetConfiguration", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration\"}", isOptional: true)]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration? InitialImportDatasetConfiguration
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration?>();
            }

            /// <summary>initial_record_generation_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#initial_record_generation_configuration DataLabelingServiceDataset#initial_record_generation_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initialRecordGenerationConfiguration", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialRecordGenerationConfiguration\"}", isOptional: true)]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration? InitialRecordGenerationConfiguration
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialRecordGenerationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#labeling_instructions DataLabelingServiceDataset#labeling_instructions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labelingInstructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LabelingInstructions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_labeling_service_dataset#timeouts DataLabelingServiceDataset#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetTimeouts\"}", isOptional: true)]
            public oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
