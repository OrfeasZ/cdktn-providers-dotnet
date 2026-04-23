using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsReplicationInstance
{
    [JsiiInterface(nativeType: typeof(IDmsReplicationInstanceKerberosAuthenticationSettings), fullyQualifiedName: "aws.dmsReplicationInstance.DmsReplicationInstanceKerberosAuthenticationSettings")]
    public interface IDmsReplicationInstanceKerberosAuthenticationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dms_replication_instance#key_cache_secret_iam_arn DmsReplicationInstance#key_cache_secret_iam_arn}.</summary>
        [JsiiProperty(name: "keyCacheSecretIamArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyCacheSecretIamArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dms_replication_instance#key_cache_secret_id DmsReplicationInstance#key_cache_secret_id}.</summary>
        [JsiiProperty(name: "keyCacheSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyCacheSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dms_replication_instance#krb5_file_contents DmsReplicationInstance#krb5_file_contents}.</summary>
        [JsiiProperty(name: "krb5FileContents", typeJson: "{\"primitive\":\"string\"}")]
        string Krb5FileContents
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsReplicationInstanceKerberosAuthenticationSettings), fullyQualifiedName: "aws.dmsReplicationInstance.DmsReplicationInstanceKerberosAuthenticationSettings")]
        internal sealed class _Proxy : DeputyBase, aws.DmsReplicationInstance.IDmsReplicationInstanceKerberosAuthenticationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dms_replication_instance#key_cache_secret_iam_arn DmsReplicationInstance#key_cache_secret_iam_arn}.</summary>
            [JsiiProperty(name: "keyCacheSecretIamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyCacheSecretIamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dms_replication_instance#key_cache_secret_id DmsReplicationInstance#key_cache_secret_id}.</summary>
            [JsiiProperty(name: "keyCacheSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyCacheSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dms_replication_instance#krb5_file_contents DmsReplicationInstance#krb5_file_contents}.</summary>
            [JsiiProperty(name: "krb5FileContents", typeJson: "{\"primitive\":\"string\"}")]
            public string Krb5FileContents
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
