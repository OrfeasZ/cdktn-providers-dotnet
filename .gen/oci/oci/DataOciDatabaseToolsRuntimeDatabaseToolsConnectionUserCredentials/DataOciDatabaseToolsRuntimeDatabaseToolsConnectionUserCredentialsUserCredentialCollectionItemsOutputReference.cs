using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Enabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedResource", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsRelatedResourceList\"}")]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsRelatedResourceList RelatedResource
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItemsRelatedResourceList>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "windowsDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowsDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentials.IDataOciDatabaseToolsRuntimeDatabaseToolsConnectionUserCredentialsUserCredentialCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
