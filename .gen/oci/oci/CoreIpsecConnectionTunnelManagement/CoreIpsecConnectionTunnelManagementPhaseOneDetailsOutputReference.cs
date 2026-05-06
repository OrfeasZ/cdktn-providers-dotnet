using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiClass(nativeType: typeof(oci.CoreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreIpsecConnectionTunnelManagementPhaseOneDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomAuthenticationAlgorithm")]
        public virtual void ResetCustomAuthenticationAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomDhGroup")]
        public virtual void ResetCustomDhGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomEncryptionAlgorithm")]
        public virtual void ResetCustomEncryptionAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsCustomPhaseOneConfig")]
        public virtual void ResetIsCustomPhaseOneConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifetime")]
        public virtual void ResetLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "isIkeEstablished", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIkeEstablished
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "negotiatedAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NegotiatedAuthenticationAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "negotiatedDhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NegotiatedDhGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "negotiatedEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NegotiatedEncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remainingLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemainingLifetime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remainingLifetimeInt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RemainingLifetimeInt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "remainingLifetimeLastRetrieved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemainingLifetimeLastRetrieved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAuthenticationAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomAuthenticationAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDhGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomDhGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customEncryptionAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomEncryptionAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isCustomPhaseOneConfigInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsCustomPhaseOneConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifetimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LifetimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "customAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomAuthenticationAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customDhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDhGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomEncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isCustomPhaseOneConfig", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsCustomPhaseOneConfig
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Lifetime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails\"}", isOptional: true)]
        public virtual oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
