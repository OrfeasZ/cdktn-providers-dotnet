using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedProperties
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedProperties.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedProperties.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "categoryDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CategoryDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "categoryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CategoryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ConfigTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "databaseToolsConnectionTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatabaseToolsConnectionTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hintText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HintText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listOfValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ListOfValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedProperties.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedProperties.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedProperties.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertiesDatabaseToolsDatabaseApiGatewayConfigAdvancedPropertySummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
