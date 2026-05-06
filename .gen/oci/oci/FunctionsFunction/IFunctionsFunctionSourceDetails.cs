using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsFunctionSourceDetails), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetails")]
    public interface IFunctionsFunctionSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#pbf_listing_id FunctionsFunction#pbf_listing_id}.</summary>
        [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}")]
        string PbfListingId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#source_type FunctionsFunction#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsFunctionSourceDetails), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsFunction.IFunctionsFunctionSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#pbf_listing_id FunctionsFunction#pbf_listing_id}.</summary>
            [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}")]
            public string PbfListingId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#source_type FunctionsFunction#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
