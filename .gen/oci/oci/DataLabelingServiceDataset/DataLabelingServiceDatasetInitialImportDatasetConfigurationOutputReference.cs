using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiClass(nativeType: typeof(oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLabelingServiceDatasetInitialImportDatasetConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImportFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat\"}}]")]
        public virtual void PutImportFormat(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImportMetadataPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath\"}}]")]
        public virtual void PutImportMetadataPath(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath)}, new object[]{@value});
        }

        [JsiiProperty(name: "importFormat", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormatOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormatOutputReference ImportFormat
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormatOutputReference>()!;
        }

        [JsiiProperty(name: "importMetadataPath", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPathOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPathOutputReference ImportMetadataPath
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "importFormatInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat? ImportFormatInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportFormat?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "importMetadataPathInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath? ImportMetadataPathInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfigurationImportMetadataPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetInitialImportDatasetConfiguration\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetInitialImportDatasetConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
