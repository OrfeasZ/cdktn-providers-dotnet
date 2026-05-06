using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsKey.KmsKeyKeyShape")]
    public class KmsKeyKeyShape : oci.KmsKey.IKmsKeyKeyShape
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#algorithm KmsKey#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string Algorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#length KmsKey#length}.</summary>
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        public double Length
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#curve_id KmsKey#curve_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "curveId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurveId
        {
            get;
            set;
        }
    }
}
