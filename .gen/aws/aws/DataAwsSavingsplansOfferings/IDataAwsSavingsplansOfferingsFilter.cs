using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSavingsplansOfferings
{
    [JsiiInterface(nativeType: typeof(IDataAwsSavingsplansOfferingsFilter), fullyQualifiedName: "aws.dataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsFilter")]
    public interface IDataAwsSavingsplansOfferingsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/savingsplans_offerings#name DataAwsSavingsplansOfferings#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/savingsplans_offerings#values DataAwsSavingsplansOfferings#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsSavingsplansOfferingsFilter), fullyQualifiedName: "aws.dataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsSavingsplansOfferings.IDataAwsSavingsplansOfferingsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/savingsplans_offerings#name DataAwsSavingsplansOfferings#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/savingsplans_offerings#values DataAwsSavingsplansOfferings#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
