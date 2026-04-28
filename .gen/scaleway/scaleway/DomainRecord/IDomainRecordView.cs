using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    [JsiiInterface(nativeType: typeof(IDomainRecordView), fullyQualifiedName: "scaleway.domainRecord.DomainRecordView")]
    public interface IDomainRecordView
    {
        /// <summary>The data of the view record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#data DomainRecord#data}
        /// </remarks>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        string Data
        {
            get;
        }

        /// <summary>The subnet of the view.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#subnet DomainRecord#subnet}
        /// </remarks>
        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
        string Subnet
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRecordView), fullyQualifiedName: "scaleway.domainRecord.DomainRecordView")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRecord.IDomainRecordView
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The data of the view record.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#data DomainRecord#data}
            /// </remarks>
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
            public string Data
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The subnet of the view.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#subnet DomainRecord#subnet}
            /// </remarks>
            [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
            public string Subnet
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
