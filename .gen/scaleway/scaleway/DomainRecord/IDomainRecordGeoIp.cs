using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    [JsiiInterface(nativeType: typeof(IDomainRecordGeoIp), fullyQualifiedName: "scaleway.domainRecord.DomainRecordGeoIp")]
    public interface IDomainRecordGeoIp
    {
        /// <summary>matches block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#matches DomainRecord#matches}
        /// </remarks>
        [JsiiProperty(name: "matches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIpMatches\"},\"kind\":\"array\"}}]}}")]
        object Matches
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRecordGeoIp), fullyQualifiedName: "scaleway.domainRecord.DomainRecordGeoIp")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRecord.IDomainRecordGeoIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>matches block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#matches DomainRecord#matches}
            /// </remarks>
            [JsiiProperty(name: "matches", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIpMatches\"},\"kind\":\"array\"}}]}}")]
            public object Matches
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
