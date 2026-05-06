using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresOutputReference), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseToolsDatabaseToolsConnectionKeyStoresOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseToolsDatabaseToolsConnectionKeyStoresOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseToolsDatabaseToolsConnectionKeyStoresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsDatabaseToolsConnectionKeyStoresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKeyStoreContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent\"}}]")]
        public virtual void PutKeyStoreContent(oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyStorePassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword\"}}]")]
        public virtual void PutKeyStorePassword(oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKeyStoreContent")]
        public virtual void ResetKeyStoreContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyStorePassword")]
        public virtual void ResetKeyStorePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyStoreType")]
        public virtual void ResetKeyStoreType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "keyStoreContent", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContentOutputReference\"}")]
        public virtual oci.DatabaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContentOutputReference KeyStoreContent
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContentOutputReference>()!;
        }

        [JsiiProperty(name: "keyStorePassword", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePasswordOutputReference\"}")]
        public virtual oci.DatabaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePasswordOutputReference KeyStorePassword
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePasswordOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyStoreContentInput", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent\"}", isOptional: true)]
        public virtual oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent? KeyStoreContentInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStoreContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyStorePasswordInput", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword\"}", isOptional: true)]
        public virtual oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword? KeyStorePasswordInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStoresKeyStorePassword?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyStoreTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyStoreTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "keyStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStores\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStores cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionKeyStores).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
