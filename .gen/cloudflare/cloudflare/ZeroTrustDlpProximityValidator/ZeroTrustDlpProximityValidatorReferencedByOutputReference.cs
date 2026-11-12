using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpProximityValidator
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorReferencedByOutputReference), fullyQualifiedName: "cloudflare.zeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorReferencedByOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustDlpProximityValidatorReferencedByOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustDlpProximityValidatorReferencedByOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustDlpProximityValidatorReferencedByOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustDlpProximityValidatorReferencedByOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "entries", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorReferencedByEntriesList\"}")]
        public virtual cloudflare.ZeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorReferencedByEntriesList Entries
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorReferencedByEntriesList>()!;
        }

        [JsiiProperty(name: "entryCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EntryCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpProximityValidator.ZeroTrustDlpProximityValidatorReferencedBy\"}", isOptional: true)]
        public virtual cloudflare.ZeroTrustDlpProximityValidator.IZeroTrustDlpProximityValidatorReferencedBy? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDlpProximityValidator.IZeroTrustDlpProximityValidatorReferencedBy?>();
            set => SetInstanceProperty(value);
        }
    }
}
