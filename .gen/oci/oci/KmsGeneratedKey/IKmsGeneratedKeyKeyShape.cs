using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsGeneratedKey
{
    [JsiiInterface(nativeType: typeof(IKmsGeneratedKeyKeyShape), fullyQualifiedName: "oci.kmsGeneratedKey.KmsGeneratedKeyKeyShape")]
    public interface IKmsGeneratedKeyKeyShape
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#algorithm KmsGeneratedKey#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        string Algorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#length KmsGeneratedKey#length}.</summary>
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        double Length
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#curve_id KmsGeneratedKey#curve_id}.</summary>
        [JsiiProperty(name: "curveId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurveId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsGeneratedKeyKeyShape), fullyQualifiedName: "oci.kmsGeneratedKey.KmsGeneratedKeyKeyShape")]
        internal sealed class _Proxy : DeputyBase, oci.KmsGeneratedKey.IKmsGeneratedKeyKeyShape
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#algorithm KmsGeneratedKey#algorithm}.</summary>
            [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string Algorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#length KmsGeneratedKey#length}.</summary>
            [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
            public double Length
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_generated_key#curve_id KmsGeneratedKey#curve_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "curveId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurveId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
