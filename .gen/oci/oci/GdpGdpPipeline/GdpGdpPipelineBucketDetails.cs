using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GdpGdpPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.gdpGdpPipeline.GdpGdpPipelineBucketDetails")]
    public class GdpGdpPipelineBucketDetails : oci.GdpGdpPipeline.IGdpGdpPipelineBucketDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/gdp_gdp_pipeline#bucket_type GdpGdpPipeline#bucket_type}.</summary>
        [JsiiProperty(name: "bucketType", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/gdp_gdp_pipeline#id GdpGdpPipeline#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/gdp_gdp_pipeline#name GdpGdpPipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/gdp_gdp_pipeline#namespace GdpGdpPipeline#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }
    }
}
