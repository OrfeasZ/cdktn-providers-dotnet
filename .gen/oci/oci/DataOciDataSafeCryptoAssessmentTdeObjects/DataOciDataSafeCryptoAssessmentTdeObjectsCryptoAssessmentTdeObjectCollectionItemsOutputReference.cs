using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeCryptoAssessmentTdeObjects
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeCryptoAssessmentTdeObjects.DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeCryptoAssessmentTdeObjects.DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionObserved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionObserved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modeObserved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModeObserved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quantumReadiness", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuantumReadiness
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tablespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TablespaceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastAssessed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastAssessed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentTdeObjects.DataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeCryptoAssessmentTdeObjects.IDataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentTdeObjects.IDataOciDataSafeCryptoAssessmentTdeObjectsCryptoAssessmentTdeObjectCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
