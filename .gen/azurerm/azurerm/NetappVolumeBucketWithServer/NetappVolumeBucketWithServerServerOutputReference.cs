using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    [JsiiClass(nativeType: typeof(azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerServerOutputReference), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappVolumeBucketWithServerServerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappVolumeBucketWithServerServerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetappVolumeBucketWithServerServerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeBucketWithServerServerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCertificatePem")]
        public virtual void ResetCertificatePem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnCertificateConflictAction")]
        public virtual void ResetOnCertificateConflictAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificatePemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fqdnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FqdnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onCertificateConflictActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnCertificateConflictActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onCertificateConflictAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnCertificateConflictAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServer\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer?>();
            set => SetInstanceProperty(value);
        }
    }
}
