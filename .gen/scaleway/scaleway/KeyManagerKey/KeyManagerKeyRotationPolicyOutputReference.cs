using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KeyManagerKey
{
    [JsiiClass(nativeType: typeof(scaleway.KeyManagerKey.KeyManagerKeyRotationPolicyOutputReference), fullyQualifiedName: "scaleway.keyManagerKey.KeyManagerKeyRotationPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KeyManagerKeyRotationPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KeyManagerKeyRotationPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KeyManagerKeyRotationPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyManagerKeyRotationPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNextRotationAt")]
        public virtual void ResetNextRotationAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "nextRotationAtInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NextRotationAtInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rotationPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RotationPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "nextRotationAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextRotationAt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rotationPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.keyManagerKey.KeyManagerKeyRotationPolicy\"}", isOptional: true)]
        public virtual scaleway.KeyManagerKey.IKeyManagerKeyRotationPolicy? InternalValue
        {
            get => GetInstanceProperty<scaleway.KeyManagerKey.IKeyManagerKeyRotationPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
