using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2InputSourceResourceConfigurationResourceTag), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag")]
    public interface IResiliencehubv2InputSourceResourceConfigurationResourceTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#key Resiliencehubv2InputSource#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#values Resiliencehubv2InputSource#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2InputSourceResourceConfigurationResourceTag), fullyQualifiedName: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#key Resiliencehubv2InputSource#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_input_source#values Resiliencehubv2InputSource#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
