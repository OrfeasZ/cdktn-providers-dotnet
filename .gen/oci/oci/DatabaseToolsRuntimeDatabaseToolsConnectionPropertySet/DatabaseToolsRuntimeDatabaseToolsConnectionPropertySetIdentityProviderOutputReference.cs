using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet
{
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConfigs")]
        public virtual void ResetConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "configsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConfigsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Configs
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
