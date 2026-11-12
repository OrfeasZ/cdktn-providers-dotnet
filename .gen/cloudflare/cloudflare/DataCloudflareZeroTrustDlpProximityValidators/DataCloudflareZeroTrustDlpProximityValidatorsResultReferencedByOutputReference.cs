using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDlpProximityValidators
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDlpProximityValidators.DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDlpProximityValidators.DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "entries", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpProximityValidators.DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByEntriesList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpProximityValidators.DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByEntriesList Entries
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpProximityValidators.DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedByEntriesList>()!;
        }

        [JsiiProperty(name: "entryCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EntryCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpProximityValidators.DataCloudflareZeroTrustDlpProximityValidatorsResultReferencedBy\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDlpProximityValidators.IDataCloudflareZeroTrustDlpProximityValidatorsResultReferencedBy? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpProximityValidators.IDataCloudflareZeroTrustDlpProximityValidatorsResultReferencedBy?>();
            set => SetInstanceProperty(value);
        }
    }
}
