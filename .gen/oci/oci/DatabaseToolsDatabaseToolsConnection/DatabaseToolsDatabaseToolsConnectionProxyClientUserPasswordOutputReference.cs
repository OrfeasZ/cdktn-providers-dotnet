using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPasswordOutputReference), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPasswordOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseToolsDatabaseToolsConnectionProxyClientUserPasswordOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseToolsDatabaseToolsConnectionProxyClientUserPasswordOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseToolsDatabaseToolsConnectionProxyClientUserPasswordOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsDatabaseToolsConnectionProxyClientUserPasswordOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValueTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "valueType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValueType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword\"}", isOptional: true)]
        public virtual oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword?>();
            set => SetInstanceProperty(value);
        }
    }
}
