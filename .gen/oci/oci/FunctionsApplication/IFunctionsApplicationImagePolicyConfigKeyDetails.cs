using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    [JsiiInterface(nativeType: typeof(IFunctionsApplicationImagePolicyConfigKeyDetails), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationImagePolicyConfigKeyDetails")]
    public interface IFunctionsApplicationImagePolicyConfigKeyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#kms_key_id FunctionsApplication#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsApplicationImagePolicyConfigKeyDetails), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationImagePolicyConfigKeyDetails")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsApplication.IFunctionsApplicationImagePolicyConfigKeyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#kms_key_id FunctionsApplication#kms_key_id}.</summary>
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
