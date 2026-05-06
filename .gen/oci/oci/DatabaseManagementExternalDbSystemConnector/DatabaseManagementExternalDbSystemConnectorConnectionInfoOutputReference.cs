using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemConnector
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoOutputReference), fullyQualifiedName: "oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseManagementExternalDbSystemConnectorConnectionInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseManagementExternalDbSystemConnectorConnectionInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseManagementExternalDbSystemConnectorConnectionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementExternalDbSystemConnectorConnectionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnectionCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnectionString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionCredentials")]
        public virtual void ResetConnectionCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionString")]
        public virtual void ResetConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentialsList\"}")]
        public virtual oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentialsList ConnectionCredentials
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentialsList>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionStringList\"}")]
        public virtual oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionStringList>()!;
        }

        [JsiiProperty(name: "databaseCredential", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoDatabaseCredentialList\"}")]
        public virtual oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoDatabaseCredentialList DatabaseCredential
        {
            get => GetInstanceProperty<oci.DatabaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoDatabaseCredentialList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComponentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionCredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfoConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseManagementExternalDbSystemConnector.DatabaseManagementExternalDbSystemConnectorConnectionInfo\"}]}}", isOptional: true)]
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
                        case oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfo cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseManagementExternalDbSystemConnector.IDatabaseManagementExternalDbSystemConnectorConnectionInfo).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
