using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    [JsiiClass(nativeType: typeof(azurerm.NetappVolume.NetappVolumeCoolAccessOutputReference), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeCoolAccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappVolumeCoolAccessOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappVolumeCoolAccessOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetappVolumeCoolAccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeCoolAccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "coolnessPeriodInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoolnessPeriodInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retrievalPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RetrievalPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tieringPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TieringPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "coolnessPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoolnessPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retrievalPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetrievalPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tieringPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TieringPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeCoolAccess\"}", isOptional: true)]
        public virtual azurerm.NetappVolume.INetappVolumeCoolAccess? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappVolume.INetappVolumeCoolAccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
