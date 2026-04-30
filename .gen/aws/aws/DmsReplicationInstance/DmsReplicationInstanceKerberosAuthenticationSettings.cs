using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsReplicationInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dmsReplicationInstance.DmsReplicationInstanceKerberosAuthenticationSettings")]
    public class DmsReplicationInstanceKerberosAuthenticationSettings : aws.DmsReplicationInstance.IDmsReplicationInstanceKerberosAuthenticationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_replication_instance#key_cache_secret_iam_arn DmsReplicationInstance#key_cache_secret_iam_arn}.</summary>
        [JsiiProperty(name: "keyCacheSecretIamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyCacheSecretIamArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_replication_instance#key_cache_secret_id DmsReplicationInstance#key_cache_secret_id}.</summary>
        [JsiiProperty(name: "keyCacheSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyCacheSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dms_replication_instance#krb5_file_contents DmsReplicationInstance#krb5_file_contents}.</summary>
        [JsiiProperty(name: "krb5FileContents", typeJson: "{\"primitive\":\"string\"}")]
        public string Krb5FileContents
        {
            get;
            set;
        }
    }
}
