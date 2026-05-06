using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiClass(nativeType: typeof(oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsOutputReference), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataLabelingServiceDatasetDatasetFormatDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataLabelingServiceDatasetDatasetFormatDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataLabelingServiceDatasetDatasetFormatDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLabelingServiceDatasetDatasetFormatDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTextFileTypeMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata\"}}]")]
        public virtual void PutTextFileTypeMetadata(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTextFileTypeMetadata")]
        public virtual void ResetTextFileTypeMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "textFileTypeMetadata", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadataOutputReference\"}")]
        public virtual oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadataOutputReference TextFileTypeMetadata
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormatTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textFileTypeMetadataInput", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata? TextFileTypeMetadataInput
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetailsTextFileTypeMetadata?>();
        }

        [JsiiProperty(name: "formatType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FormatType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetDatasetFormatDetails\"}", isOptional: true)]
        public virtual oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetDatasetFormatDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
