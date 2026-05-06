using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeTargetDatabasesColumns
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeTargetDatabasesColumns.DataOciDataSafeTargetDatabasesColumnsColumnsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeTargetDatabasesColumns.DataOciDataSafeTargetDatabasesColumnsColumnsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeTargetDatabasesColumnsColumnsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeTargetDatabasesColumnsColumnsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeTargetDatabasesColumnsColumnsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeTargetDatabasesColumnsColumnsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "characterLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CharacterLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Length
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "precision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Precision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Scale
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeTargetDatabasesColumns.DataOciDataSafeTargetDatabasesColumnsColumns\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeTargetDatabasesColumns.IDataOciDataSafeTargetDatabasesColumnsColumns? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeTargetDatabasesColumns.IDataOciDataSafeTargetDatabasesColumnsColumns?>();
            set => SetInstanceProperty(value);
        }
    }
}
