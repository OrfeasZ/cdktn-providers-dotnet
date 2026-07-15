using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GdpGdpPipeline
{
    [JsiiInterface(nativeType: typeof(IGdpGdpPipelineBucketDetails), fullyQualifiedName: "oci.gdpGdpPipeline.GdpGdpPipelineBucketDetails")]
    public interface IGdpGdpPipelineBucketDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#bucket_type GdpGdpPipeline#bucket_type}.</summary>
        [JsiiProperty(name: "bucketType", typeJson: "{\"primitive\":\"string\"}")]
        string BucketType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#id GdpGdpPipeline#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#name GdpGdpPipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#namespace GdpGdpPipeline#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGdpGdpPipelineBucketDetails), fullyQualifiedName: "oci.gdpGdpPipeline.GdpGdpPipelineBucketDetails")]
        internal sealed class _Proxy : DeputyBase, oci.GdpGdpPipeline.IGdpGdpPipelineBucketDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#bucket_type GdpGdpPipeline#bucket_type}.</summary>
            [JsiiProperty(name: "bucketType", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#id GdpGdpPipeline#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#name GdpGdpPipeline#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/gdp_gdp_pipeline#namespace GdpGdpPipeline#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
