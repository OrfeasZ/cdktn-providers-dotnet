using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiClass(nativeType: typeof(oci.CoreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConnectivityAssociationKeySecretVersion")]
        public virtual void ResetConnectivityAssociationKeySecretVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectivityAssociationNameSecretVersion")]
        public virtual void ResetConnectivityAssociationNameSecretVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectivityAssociationKeySecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectivityAssociationKeySecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectivityAssociationKeySecretVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectivityAssociationKeySecretVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectivityAssociationNameSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectivityAssociationNameSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectivityAssociationNameSecretVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectivityAssociationNameSecretVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "connectivityAssociationKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectivityAssociationKeySecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectivityAssociationKeySecretVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectivityAssociationKeySecretVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectivityAssociationNameSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectivityAssociationNameSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectivityAssociationNameSecretVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectivityAssociationNameSecretVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey\"}", isOptional: true)]
        public virtual oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey? InternalValue
        {
            get => GetInstanceProperty<oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey?>();
            set => SetInstanceProperty(value);
        }
    }
}
