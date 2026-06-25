using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackAdbDbCredentials), fullyQualifiedName: "oci.difStack.DifStackAdbDbCredentials")]
    public interface IDifStackAdbDbCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#secret_id DifStack#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#user_name DifStack#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#user_type DifStack#user_type}.</summary>
        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        string UserType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackAdbDbCredentials), fullyQualifiedName: "oci.difStack.DifStackAdbDbCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackAdbDbCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#secret_id DifStack#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#user_name DifStack#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#user_type DifStack#user_type}.</summary>
            [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
            public string UserType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
