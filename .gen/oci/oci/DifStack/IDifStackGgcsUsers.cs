using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackGgcsUsers), fullyQualifiedName: "oci.difStack.DifStackGgcsUsers")]
    public interface IDifStackGgcsUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#action DifStack#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#secret_id DifStack#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#user_name DifStack#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#user_type DifStack#user_type}.</summary>
        [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
        string UserType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackGgcsUsers), fullyQualifiedName: "oci.difStack.DifStackGgcsUsers")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackGgcsUsers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#action DifStack#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#secret_id DifStack#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#user_name DifStack#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#user_type DifStack#user_type}.</summary>
            [JsiiProperty(name: "userType", typeJson: "{\"primitive\":\"string\"}")]
            public string UserType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
