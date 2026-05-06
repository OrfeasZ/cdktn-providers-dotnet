using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsOutputReference), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataSafeTargetDatabasePeerTargetDatabaseDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataSafeTargetDatabasePeerTargetDatabaseDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataSafeTargetDatabasePeerTargetDatabaseDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeTargetDatabasePeerTargetDatabaseDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatabaseDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails\"}}]")]
        public virtual void PutDatabaseDetails(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTlsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig\"}}]")]
        public virtual void PutTlsConfig(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataguardAssociationId")]
        public virtual void ResetDataguardAssociationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsConfig")]
        public virtual void ResetTlsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetailsOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetailsOutputReference DatabaseDetails
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfigOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfigOutputReference TlsConfig
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseDetailsInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails? DatabaseDetailsInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataguardAssociationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataguardAssociationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsConfigInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig? TlsConfigInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig?>();
        }

        [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataguardAssociationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails\"}]}}", isOptional: true)]
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
                        case oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
