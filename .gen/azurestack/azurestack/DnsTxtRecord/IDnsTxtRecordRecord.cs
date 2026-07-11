using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DnsTxtRecord
{
    [JsiiInterface(nativeType: typeof(IDnsTxtRecordRecord), fullyQualifiedName: "azurestack.dnsTxtRecord.DnsTxtRecordRecord")]
    public interface IDnsTxtRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/dns_txt_record#value DnsTxtRecord#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsTxtRecordRecord), fullyQualifiedName: "azurestack.dnsTxtRecord.DnsTxtRecordRecord")]
        internal sealed class _Proxy : DeputyBase, azurestack.DnsTxtRecord.IDnsTxtRecordRecord
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/dns_txt_record#value DnsTxtRecord#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
